USE ter_hyperplanning;
GO
SET NOCOUNT ON;

/* =================================================
   0. INITIALISATION DES VARIABLES
   ================================================= */
-- Variables globales pour réutilisation dans les scénarios
DECLARE @Adm1 VARCHAR(50), @Adm2 VARCHAR(50);
DECLARE @Tch1 VARCHAR(50), @Tch2 VARCHAR(50);
DECLARE @Pr1 VARCHAR(50), @Co1 VARCHAR(50), @Co2 VARCHAR(50);
DECLARE @Sm1 VARCHAR(50), @Gr1 VARCHAR(50);
DECLARE @Room1 VARCHAR(50), @Room2 VARCHAR(50);
DECLARE @Sess1 VARCHAR(50), @Sess2 VARCHAR(50);

/* =================================================
   1. TABLES DE RÉFÉRENCE (Data Statique)
   ================================================= */
INSERT INTO [SessionType] (label) VALUES ('Cours Magistral'), ('Travaux Dirigés');
INSERT INTO [SessionStatus] (label) VALUES ('Programmé'), ('En attente'), ('Annulé');
INSERT INTO [TeacherTitle] (name) VALUES ('Professeur'), ('Maître de Conférences'), ('Intervenant');
INSERT INTO [RoomType] (name) VALUES ('Amphithéâtre'), ('Salle TP Informatique'), ('Salle de TD');
INSERT INTO [Building] (name) VALUES ('Bâtiment A'), ('Bâtiment B'), ('Bâtiment C'); 
INSERT INTO [WeekDay] (order_index, name) VALUES (1, 'Lundi'), (2, 'Mardi'), (3, 'Mercredi'), (4, 'Jeudi'), (5, 'Vendredi');
INSERT INTO [ChangeStatus] (label) VALUES ('Validé'), ('Refusé'), ('En cours');
INSERT INTO [UnavailableDayType] (name) VALUES ('Maintenance'), ('Jour Férié'), ('Fermeture Exceptionnelle');

/* =================================================
   2. INFRASTRUCTURE (Buildings & Rooms)
   ================================================= */
INSERT INTO [Room] (room_number, capacity, building_id, room_type_id)
VALUES ('A-102', 40, (SELECT TOP 1 building_id FROM Building WHERE name='Bâtiment A'), (SELECT TOP 1 room_type_id FROM RoomType WHERE name='Salle TP Informatique'));
SELECT @Room1 = room_id FROM [Room] WHERE room_number = 'A-102';

-- AJOUTER TES SALLES ICI --
INSERT INTO [Room] (room_number, capacity, building_id, room_type_id)
VALUES ('IBGBI-1-108', 35, (SELECT TOP 1 building_id FROM Building), (SELECT TOP 1 room_type_id FROM RoomType));

DECLARE @RoomMGL VARCHAR(50);
SELECT @RoomMGL = room_id FROM [Room] WHERE room_number = 'IBGBI-1-108';

/* =================================================
   3. ACTEURS (Admins, Teachers, Students)
   ================================================= */
-- Admins
INSERT INTO [Admin] (last_name, first_name, email, password) 
VALUES ('Zidane', 'Zinedine', 'admin.zizou@univ.fr', 'hash_secure');
SELECT @Adm1 = admin_id FROM [Admin] WHERE email = 'admin.zizou@univ.fr';

-- Teachers
INSERT INTO [Teacher] (last_name, first_name, email, password, teacher_title_id, registration_number) 
VALUES ('Curie', 'Marie', 'marie.curie@univ.fr', 'pass123', (SELECT TOP 1 teacher_title_id FROM TeacherTitle), 'REG_001');
SELECT @Tch1 = teacher_id FROM [Teacher] WHERE email = 'marie.curie@univ.fr';

-- Programs & Groups
INSERT INTO [Program] (name, field) VALUES ('Master MIAGE', 'Informatique');
SELECT @Pr1 = program_id FROM [Program] WHERE name = 'Master MIAGE';

INSERT INTO [StudyMode] (name, teacher_id, program_id) VALUES ('Formation Initiale', @Tch1, @Pr1);
SELECT @Sm1 = study_mode_id FROM [StudyMode] WHERE teacher_id = @Tch1;

INSERT INTO [Group] (name, academic_year, study_mode_id) VALUES ('Groupe A1', '2025-2026', @Sm1);
SELECT @Gr1 = group_id FROM [Group] WHERE name = 'Groupe A1';

-- Students
INSERT INTO [Student] (last_name, first_name, email, password, group_id) 
VALUES ('Dupont', 'Jean', 'jean.dupont@etud.fr', 'pass_jean', @Gr1);

-- AJOUTER TES UTILISATEURS ICI --

-- Le Professeur
INSERT INTO [Teacher] (last_name, first_name, email, password, teacher_title_id, registration_number) 
VALUES ('JAOUADI', 'Mohamed', 'm.jaouadi@univ.fr', 'secure_pass', (SELECT TOP 1 teacher_title_id FROM TeacherTitle), 'TCH_888');

DECLARE @TchMGL VARCHAR(50);
SELECT @TchMGL = teacher_id FROM [Teacher] WHERE email = 'm.jaouadi@univ.fr';

-- Le Mode d'étude (Initiale) et le Groupe
INSERT INTO [StudyMode] (name, teacher_id, program_id) 
VALUES ('Initiale', @TchMGL, (SELECT TOP 1 program_id FROM Program)); -- On l'associe au Master MIAGE

DECLARE @SmMGL VARCHAR(50);
SELECT @SmMGL = study_mode_id FROM [StudyMode] WHERE teacher_id = @TchMGL AND name = 'Initiale';

INSERT INTO [Group] (name, academic_year, study_mode_id) 
VALUES ('M1 MIAGE', '2025-2026', @SmMGL);

DECLARE @GrMGL VARCHAR(50);
SELECT @GrMGL = group_id FROM [Group] WHERE name = 'M1 MIAGE';

/* =================================================
   4. PÉDAGOGIE (Courses & Sessions)
   ================================================= */
INSERT INTO [Course] (name, code) VALUES ('Bases de données', 'BDD_101');
SELECT @Co1 = course_id FROM [Course] WHERE code = 'BDD_101';

-- Session 1
INSERT INTO [Session] (date, start_time, end_time, mode, session_type_id, course_id, session_status_id, room_id)
VALUES ('2026-02-10', '08:00:00', '10:00:00', 'Présentiel', 
       (SELECT TOP 1 session_type_id FROM SessionType), @Co1, (SELECT TOP 1 session_status_id FROM SessionStatus), @Room1);
SELECT @Sess1 = session_id FROM [Session] WHERE course_id = @Co1 AND date = '2026-02-10';

-- Liaisons (Qui enseigne quoi et qui assiste à quoi)
IF @Sess1 IS NOT NULL AND @Tch1 IS NOT NULL INSERT INTO [Teach] (session_id, teacher_id) VALUES (@Sess1, @Tch1);
IF @Gr1 IS NOT NULL AND @Sess1 IS NOT NULL INSERT INTO [Attend] (group_id, session_id) VALUES (@Gr1, @Sess1);

-- AJOUTER TES COURS/SESSIONS ICI --

-- La Matière
INSERT INTO [Course] (name, code) VALUES ('Méthodes de Génie Logiciel', 'MGL_501');
DECLARE @CoMGL VARCHAR(50); SELECT @CoMGL = course_id FROM [Course] WHERE code = 'MGL_501';

-- La Séance du Mercredi 04 Février 2026
INSERT INTO [Session] (date, start_time, end_time, mode, session_type_id, course_id, session_status_id, room_id)
VALUES ('2026-02-04', '08:30:00', '11:45:00', 'Présentiel', 
       (SELECT session_type_id FROM SessionType WHERE label = 'Cours Magistral'), 
       @CoMGL, 
       (SELECT session_status_id FROM SessionStatus WHERE label = 'Programmé'),
       @RoomMGL);

DECLARE @SessMGL VARCHAR(50);
SELECT @SessMGL = session_id FROM [Session] WHERE date = '2026-02-04' AND room_id = @RoomMGL;

-- Liaisons
INSERT INTO [Teach] (session_id, teacher_id) VALUES (@SessMGL, @TchMGL);
INSERT INTO [Attend] (group_id, session_id) VALUES (@GrMGL, @SessMGL);

-- Disponibilité : Tous les mercredis de Janvier à Mai 2026
INSERT INTO [Availability] (start_date, end_date, weekday_id, start_time, end_time, teacher_id)
VALUES ('2026-01-01', '2026-05-31', (SELECT weekday_id FROM WeekDay WHERE name = 'Mercredi'), '08:00:00', '19:00:00', @TchMGL);

/* =================================================
   5. COMMUNICATIONS (Notifications)
   ================================================= */
INSERT INTO [Notification] (title, message) VALUES ('Alerte Système', 'Maintenance prévue.');

-- Notifier tous les admins
INSERT INTO [Receive] (admin_id, notification_id)
SELECT admin_id, (SELECT TOP 1 notification_id FROM [Notification] ORDER BY created_at DESC) FROM [Admin];

-- AJOUTER TES NOTIFS CIBLÉES ICI --

/* =================================================
   6. SCÉNARIOS LIBRES (À remplir à la main)
   ================================================= */

INSERT INTO [Student] (last_name, first_name, email, password, group_id) 
VALUES ('Doe', 'John', 'john.doe@etud.univ.fr', 'pass', @GrMGL);
INSERT INTO [Student] (last_name, first_name, email, password, group_id) 
VALUES ('RAHMANI', 'Mohamed', 'mohamed.rahmani@etud.univ.fr', 'pass', @GrMGL);


PRINT 'Seed complet et organisé ! Prêt pour ajouts manuels.';
GO