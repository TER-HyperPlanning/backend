/* =========================
   DATABASE & CONFIG
   ========================= */
IF DB_ID(N'ter_hyperplanning') IS NULL CREATE DATABASE ter_hyperplanning;
GO
USE ter_hyperplanning;
GO

/* =========================
   REFERENCE TABLES
   ========================= */
CREATE TABLE [Building] (
    building_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [Program] (
    program_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL,
    field VARCHAR(50) NOT NULL
);

CREATE TABLE [Course] (
    course_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL,
    code VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [SessionType] (
    session_type_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    label VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [RoomType] (
    room_type_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [SessionStatus] (
    session_status_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    label VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [TeacherTitle] (
    teacher_title_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [WeekDay] (
    weekday_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    order_index TINYINT NOT NULL UNIQUE,
    name VARCHAR(50) NOT NULL UNIQUE
);

/* =========================
   USERS
   ========================= */
CREATE TABLE [Admin] (
    admin_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    last_name VARCHAR(50) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL, -- Augmenté pour le hashage
    phone_number VARCHAR(50),
    created_at DATETIME DEFAULT GETDATE() NOT NULL
);

CREATE TABLE [Notification] (
    notification_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    title VARCHAR(100) NOT NULL,
    message VARCHAR(MAX) NOT NULL,
    created_at DATETIME DEFAULT GETDATE() NOT NULL
);

/* =========================
   UNAVAILABLE DAYS
   ========================= */
CREATE TABLE [UnavailableDayType] (
    unavailable_day_type_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [UnavailableDay] (
    unavailable_day_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    start_time TIME,
    end_time TIME,
    unavailable_day_type_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (unavailable_day_type_id) REFERENCES [UnavailableDayType](unavailable_day_type_id)
);

/* =========================
   SESSIONS & TEACHERS
   ========================= */
CREATE TABLE [Room] (
    room_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    room_number VARCHAR(50) NOT NULL UNIQUE,
    available BIT DEFAULT 1 NOT NULL,
    capacity INT NOT NULL,
    building_id VARCHAR(50) NOT NULL,
    room_type_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (building_id) REFERENCES [Building](building_id),
    FOREIGN KEY (room_type_id) REFERENCES [RoomType](room_type_id)
);


CREATE TABLE [Session] (
    session_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    date DATE NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    mode VARCHAR(50) NOT NULL,
    session_type_id VARCHAR(50) NOT NULL,
    course_id VARCHAR(50) NOT NULL,
    session_status_id VARCHAR(50) NOT NULL,
    room_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (session_type_id) REFERENCES [SessionType](session_type_id),
    FOREIGN KEY (course_id) REFERENCES [Course](course_id),
    FOREIGN KEY (session_status_id) REFERENCES [SessionStatus](session_status_id),
    FOREIGN KEY (room_id) REFERENCES [Room](room_id)
);

CREATE TABLE [Teacher] (
    teacher_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    last_name VARCHAR(50) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    phone_number VARCHAR(50),
    registration_number VARCHAR(50) UNIQUE,
    created_at DATETIME DEFAULT GETDATE() NOT NULL,
    teacher_title_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (teacher_title_id) REFERENCES [TeacherTitle](teacher_title_id)
);

CREATE TABLE [Availability] (
    availability_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    start_date DATE NOT NULL,
    end_date DATE NOT NULL,
    weekday_id VARCHAR(50) NOT NULL,
    start_time TIME NOT NULL,
    end_time TIME NOT NULL,
    teacher_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (teacher_id) REFERENCES [Teacher](teacher_id),
    FOREIGN KEY (weekday_id) REFERENCES [WeekDay](weekday_id)
);

/* =========================
   CHANGES & ROOMS
   ========================= */
CREATE TABLE [ChangeStatus] (
    change_status_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    label VARCHAR(50) NOT NULL UNIQUE
);

CREATE TABLE [SessionChange] (
    session_change_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    date DATETIME DEFAULT GETDATE() NOT NULL,
    reason VARCHAR(255) NOT NULL,
    teacher_id VARCHAR(50) NOT NULL,
    admin_id VARCHAR(50),
    session_id VARCHAR(50) NOT NULL,
    change_status_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (teacher_id) REFERENCES [Teacher](teacher_id),
    FOREIGN KEY (admin_id) REFERENCES [Admin](admin_id),
    FOREIGN KEY (session_id) REFERENCES [Session](session_id),
    FOREIGN KEY (change_status_id) REFERENCES [ChangeStatus](change_status_id)
);

/* =========================
   STUDY MODE & STUDENTS
   ========================= */
CREATE TABLE [StudyMode] (
    study_mode_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL, -- ex: Initiale, Alternance
    teacher_id VARCHAR(50) NOT NULL, -- ex: Responsable de formation
    program_id VARCHAR(50) NOT NULL, -- ex: M1 MIAGE
    FOREIGN KEY (teacher_id) REFERENCES [Teacher](teacher_id),
    FOREIGN KEY (program_id) REFERENCES [Program](program_id)
);

CREATE TABLE [Group] (
    group_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    name VARCHAR(50) NOT NULL,
    academic_year VARCHAR(50) NOT NULL,
    study_mode_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (study_mode_id) REFERENCES [StudyMode](study_mode_id)
);

CREATE TABLE [Student] (
    student_id VARCHAR(50) PRIMARY KEY DEFAULT NEWID(),
    last_name VARCHAR(50) NOT NULL,
    first_name VARCHAR(50) NOT NULL,
    email VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL,
    phone_number VARCHAR(50),
    created_at DATETIME DEFAULT GETDATE() NOT NULL,
    group_id VARCHAR(50) NOT NULL,
    FOREIGN KEY (group_id) REFERENCES [Group](group_id)
);

/* =========================
   ASSOCIATIONS (Many-to-Many)
   ========================= */
CREATE TABLE [Assign] (
    study_mode_id VARCHAR(50) NOT NULL,
    course_id VARCHAR(50) NOT NULL,
    hourly_volume INT NOT NULL,
    PRIMARY KEY (study_mode_id, course_id),
    FOREIGN KEY (study_mode_id) REFERENCES [StudyMode](study_mode_id),
    FOREIGN KEY (course_id) REFERENCES [Course](course_id)
);

CREATE TABLE [Teach] (
    session_id VARCHAR(50) NOT NULL,
    teacher_id VARCHAR(50) NOT NULL,
    PRIMARY KEY (session_id, teacher_id),
    FOREIGN KEY (session_id) REFERENCES [Session](session_id),
    FOREIGN KEY (teacher_id) REFERENCES [Teacher](teacher_id)
);

CREATE TABLE [Attend] (
    group_id VARCHAR(50) NOT NULL,
    session_id VARCHAR(50) NOT NULL,
    PRIMARY KEY (group_id, session_id),
    FOREIGN KEY (group_id) REFERENCES [Group](group_id),
    FOREIGN KEY (session_id) REFERENCES [Session](session_id)
);

CREATE TABLE [Receive] (
    teacher_id VARCHAR(50),
    student_id VARCHAR(50),
    admin_id VARCHAR(50),
    notification_id VARCHAR(50) NOT NULL,
    -- Pas de PK stricte ici car on peut vouloir envoyer à l'un ou l'autre
    FOREIGN KEY (teacher_id) REFERENCES [Teacher](teacher_id),
    FOREIGN KEY (student_id) REFERENCES [Student](student_id),
    FOREIGN KEY (admin_id) REFERENCES [Admin](admin_id),
    FOREIGN KEY (notification_id) REFERENCES [Notification](notification_id)
);