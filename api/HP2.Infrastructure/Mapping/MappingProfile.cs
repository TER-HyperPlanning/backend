using AutoMapper;
using HP2.Application.DTOs.Auth;
using HP2.Application.DTOs.Availability;
using HP2.Application.DTOs.Course;
using HP2.Application.DTOs.Group;
using HP2.Application.DTOs.Track;
using HP2.Domain.Enums;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;


namespace HP2.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, UserModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => Enum.Parse<HP2.Domain.Enums.UserRole>(src.UserRole.Name, true)))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                .ReverseMap()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt));

            CreateMap<UserModel, CurrentUserResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.Email))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.FirstName))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.LastName))
                .ForMember(dest => dest.PhoneNumber, opt => opt.MapFrom(src => src.Phone))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.CreatedAt));

            // ===== Admin Mapping =====
            CreateMap<Admin, AdminModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User != null ? src.User.Password : string.Empty))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : string.Empty))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : string.Empty))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.User != null && src.User.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.User != null ? src.User.DeletedAt : null))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.UpdatedAt : DateTime.UtcNow));

            // ===== Teacher Mapping =====
            CreateMap<Teacher, TeacherModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User != null ? src.User.Password : string.Empty))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : string.Empty))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : string.Empty))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src =>
                    src.User != null
                        ? Enum.Parse<HP2.Domain.Enums.UserRole>(src.User.UserRole.Name, true)
                        : HP2.Domain.Enums.UserRole.TEACHER))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.User != null && src.User.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.User != null ? src.User.DeletedAt : null))
                .ForMember(dest => dest.Matricule, opt => opt.MapFrom(src => src.RegistrationNumber))
                .ForMember(dest => dest.Title, opt => opt.MapFrom(src =>
                    src.TeacherTitle != null
                        ? (HP2.Domain.Enums.TeacherTitle?)Enum.Parse<HP2.Domain.Enums.TeacherTitle>(src.TeacherTitle.Name.ToUpper())
                        : null))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.UpdatedAt : DateTime.UtcNow));

            // ===== Student Mapping =====
            CreateMap<Student, StudentModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User != null ? src.User.Password : string.Empty))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : string.Empty))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : string.Empty))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.UpdatedAt : DateTime.UtcNow))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.User != null && src.User.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.User != null ? src.User.DeletedAt : null))
                .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId));

            // ===== Academic Structure =====
            CreateMap<Program, ProgramModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ProgramId))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt))
                .ReverseMap()
                .ForMember(dest => dest.ProgramId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt));
            CreateMap<Track, TrackModel>()
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Lieu, opt => opt.MapFrom(src => src.Lieu))
            .ReverseMap();
            CreateMap<TrackModel, TrackResponse>().ReverseMap();
            CreateMap<CreateTrackRequest, TrackModel>()
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Lieu, opt => opt.MapFrom(src => src.Lieu))
            .ReverseMap();
            CreateMap<UpdateTrackRequest, TrackModel>()
            .ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description))
            .ForMember(dest => dest.Lieu, opt => opt.MapFrom(src => src.Lieu))
            .ReverseMap();

            CreateMap<Course, CourseModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CourseId))
                .ReverseMap()
                .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Id));

            CreateMap<CourseModel, CourseResponse>();
            CreateMap<CreateCourseRequest, CourseModel>();
            CreateMap<UpdateCourseRequest, CourseModel>();

            CreateMap<Group, GroupModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.GroupId))
                .ForMember(dest => dest.AcademicYear, opt => opt.MapFrom(src => src.AcademicYear))
                .ForMember(dest => dest.TrackId, opt => opt.MapFrom(src => src.TrackId))
                .ReverseMap()
                .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.AcademicYear, opt => opt.MapFrom(src => src.AcademicYear))
                .ForMember(dest => dest.TrackId, opt => opt.MapFrom(src => src.TrackId));

            CreateMap<CreateGroupRequest, GroupModel>()
                .ForMember(dest => dest.AcademicYear, opt => opt.MapFrom(src => src.AcademicYear))
                .ForMember(dest => dest.TrackId, opt => opt.MapFrom(src => src.TrackId));

            CreateMap<UpdateGroupRequest, GroupModel>()
                .ForMember(dest => dest.AcademicYear, opt => opt.MapFrom(src => src.AcademicYear))
                .ForMember(dest => dest.TrackId, opt => opt.MapFrom(src => src.TrackId));
            CreateMap<Course, CourseModel>()
            .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.CourseId))
            .ReverseMap()
            .ForMember(dest => dest.CourseId, opt => opt.MapFrom(src => src.Id));
            CreateMap<CourseModel, CourseResponse>();
            CreateMap<CreateCourseRequest, CourseModel>();
            CreateMap<UpdateCourseRequest, CourseModel>();
            
            // ===== Session Mapping =====
            CreateMap<Session, SessionModel>()
                .ForMember(dest => dest.Id,opt => opt.MapFrom(src => src.SessionId))
                .ForMember(dest => dest.StartDateTime, opt => opt.MapFrom(src => src.Date.Date + src.StartTime))
                .ForMember(dest => dest.EndDateTime,opt => opt.MapFrom(src => src.Date.Date + src.EndTime))
                .ForMember(dest => dest.Mode,opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.SessionTypeId,opt => opt.MapFrom(src => src.SessionTypeId))
                .ForMember(dest => dest.CourseId,opt => opt.MapFrom(src => src.CourseId))
                .ForMember(dest => dest.SessionStatusId,opt => opt.MapFrom(src => src.SessionStatusId))
                .ForMember(dest => dest.RoomId,opt => opt.MapFrom(src => src.RoomId))
                .ForMember(dest => dest.Description,opt => opt.Ignore())
                .ReverseMap()
                .ForMember(dest => dest.SessionId,opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Date,opt => opt.MapFrom(src => src.StartDateTime.Date))
                .ForMember(dest => dest.StartTime,opt => opt.MapFrom(src => src.StartDateTime.TimeOfDay))
                .ForMember(dest => dest.EndTime,opt => opt.MapFrom(src => src.EndDateTime.TimeOfDay))
                .ForMember(dest => dest.Mode,opt => opt.MapFrom(src => src.Mode))
                .ForMember(dest => dest.SessionTypeId,opt => opt.MapFrom(src => src.SessionTypeId))
                .ForMember(dest => dest.CourseId,opt => opt.MapFrom(src => src.CourseId))
                .ForMember(dest => dest.SessionStatusId,opt => opt.MapFrom(src => src.SessionStatusId))
                .ForMember(dest => dest.RoomId,opt => opt.MapFrom(src => src.RoomId))
                .ForMember(dest => dest.Course,opt => opt.Ignore())
                .ForMember(dest => dest.Room,opt => opt.Ignore())
                .ForMember(dest => dest.SessionStatus,opt => opt.Ignore())
                .ForMember(dest => dest.SessionType,opt => opt.Ignore())
                .ForMember(dest => dest.SessionRoomChanges, opt => opt.Ignore())
                .ForMember(dest => dest.SessionRecoveryChanges, opt => opt.Ignore())
                .ForMember(dest => dest.Groups,opt => opt.Ignore())
                .ForMember(dest => dest.Teachers,opt => opt.Ignore());

            CreateMap<SessionType, SessionTypeModel>().ReverseMap();
            CreateMap<SessionStatus, SessionStatusModel>().ReverseMap();

            CreateMap<SessionRoomChange, SessionRoomChangeModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.SessionRoomChangeId))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.ChangeDate))
                .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                .ForMember(dest => dest.TeacherId, opt => opt.MapFrom(src => src.TeacherId))
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => src.SessionId))
                .ForMember(dest => dest.ChangeStatusId, opt => opt.MapFrom(src => src.ChangeStatusId))
                .ForMember(dest => dest.ApprovedRoomId, opt => opt.MapFrom(src => src.ApprovedRoomId))
                .ForMember(dest => dest.RejectionReason, opt => opt.MapFrom(src => src.RejectionReason));

            CreateMap<SessionRoomChangeModel, SessionRoomChange>()
                .ForMember(dest => dest.SessionRoomChangeId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ChangeDate, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.ChangeStatus, opt => opt.Ignore())
                .ForMember(dest => dest.Session, opt => opt.Ignore())
                .ForMember(dest => dest.Teacher, opt => opt.Ignore())
                .ForMember(dest => dest.ApprovedRoom, opt => opt.Ignore());

            CreateMap<SessionRecoveryChange, SessionRecoveryChangeModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.SessionRecoveryChangeId))
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.ChangeDate))
                .ForMember(dest => dest.Reason, opt => opt.MapFrom(src => src.Reason))
                .ForMember(dest => dest.TeacherId, opt => opt.MapFrom(src => src.TeacherId))
                .ForMember(dest => dest.SessionId, opt => opt.MapFrom(src => src.SessionId))
                .ForMember(dest => dest.ChangeStatusId, opt => opt.MapFrom(src => src.ChangeStatusId))
                .ForMember(dest => dest.ProposedDate, opt => opt.MapFrom(src => src.ProposedDate))
                .ForMember(dest => dest.ProposedStartTime, opt => opt.MapFrom(src => src.ProposedStartTime))
                .ForMember(dest => dest.ProposedEndTime, opt => opt.MapFrom(src => src.ProposedEndTime))
                .ForMember(dest => dest.ProposedRoomId, opt => opt.MapFrom(src => src.ProposedRoomId))
                .ForMember(dest => dest.CounterProposalDate, opt => opt.MapFrom(src => src.CounterProposalDate))
                .ForMember(dest => dest.CounterProposalStartTime, opt => opt.MapFrom(src => src.CounterProposalStartTime))
                .ForMember(dest => dest.CounterProposalEndTime, opt => opt.MapFrom(src => src.CounterProposalEndTime))
                .ForMember(dest => dest.CounterProposalRoomId, opt => opt.MapFrom(src => src.CounterProposalRoomId))
                .ForMember(dest => dest.RejectionReason, opt => opt.MapFrom(src => src.RejectionReason));

            CreateMap<SessionRecoveryChangeModel, SessionRecoveryChange>()
                .ForMember(dest => dest.SessionRecoveryChangeId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.ChangeDate, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.ChangeStatus, opt => opt.Ignore())
                .ForMember(dest => dest.Session, opt => opt.Ignore())
                .ForMember(dest => dest.Teacher, opt => opt.Ignore())
                .ForMember(dest => dest.ProposedRoom, opt => opt.Ignore())
                .ForMember(dest => dest.CounterProposalRoom, opt => opt.Ignore());
            // ===== Room =====
            CreateMap<Building, BuildingModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BuildingId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
                .ForMember(dest => dest.IsDeleted, opt => opt.MapFrom(src => src.IsDeleted))
                .ForMember(dest => dest.DeletedAt, opt => opt.MapFrom(src => src.DeletedAt));

            CreateMap<Room, RoomModel>().ReverseMap();
            CreateMap<RoomType, RoomTypeModel>().ReverseMap();

            // ===== Availability =====
            CreateMap<Availability, AvailabilityModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AvailabilityId))
                .ForMember(dest => dest.WeekDayId, opt => opt.MapFrom(src => src.WeekdayId))
                .ReverseMap()
                .ForMember(dest => dest.AvailabilityId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.WeekdayId, opt => opt.MapFrom(src => src.WeekDayId));

            CreateMap<Availability, AvailabilityResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AvailabilityId))
                .ForMember(dest => dest.WeekDay, opt => opt.MapFrom(src =>
                    src.Weekday != null
                        ? Enum.Parse<HP2.Domain.Enums.WeekDay>(src.Weekday.Name, true)
                        : HP2.Domain.Enums.WeekDay.Lundi))
                .ForMember(dest => dest.TeacherId, opt => opt.MapFrom(src => src.TeacherId))
                .ForMember(dest => dest.StartTime, opt => opt.MapFrom(src => src.StartTime))
                .ForMember(dest => dest.EndTime, opt => opt.MapFrom(src => src.EndTime))
                .ForMember(dest => dest.StartDate, opt => opt.MapFrom(src => src.StartDate))
                .ForMember(dest => dest.EndDate, opt => opt.MapFrom(src => src.EndDate))
                .ForMember(dest => dest.AvailabilityGroupId, opt => opt.MapFrom(src => src.AvailabilityGroupId));

            // ===== AvailabilityGroup =====
            CreateMap<AvailabilityGroup, AvailabilityGroupModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AvailabilityGroupId))
                .ReverseMap()
                .ForMember(dest => dest.AvailabilityGroupId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.Availabilities, opt => opt.Ignore());

            CreateMap<AvailabilityGroup, AvailabilityGroupResponse>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.AvailabilityGroupId))
                .ForMember(dest => dest.TeacherId, opt => opt.MapFrom(src => src.TeacherId))
                .ForMember(dest => dest.NumberOfAvailableDays, opt => opt.MapFrom(src => src.NumberOfAvailableDays));

            // ===== Other =====
           // ===== Other =====
            CreateMap<HP2.Infrastructure.Persistence.Entities.TeacherTitle, TeacherTitleModel>().ReverseMap();
            CreateMap<HP2.Infrastructure.Persistence.Entities.Assign, AssignModel>().ReverseMap();
            CreateMap<HP2.Infrastructure.Persistence.Entities.Notification, NotificationModel>().ReverseMap();
            CreateMap<HP2.Infrastructure.Persistence.Entities.ChangeStatus, ChangeStatusModel>().ReverseMap();
            CreateMap<HP2.Infrastructure.Persistence.Entities.UnavailableDay, UnavailableDayModel>().ReverseMap();
            CreateMap<HP2.Infrastructure.Persistence.Entities.UnavailableDayType, UnavailabilityTypeModel>().ReverseMap();
        }
    }
}