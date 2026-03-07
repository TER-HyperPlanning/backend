using AutoMapper;
using HP2.Application.DTOs.Auth;
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
                .ReverseMap()
                .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.Id))
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.UpdatedAt));

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
                .ForMember(dest => dest.UpdatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.UpdatedAt : DateTime.UtcNow));
            
            // ===== Teacher Mapping =====
            CreateMap<Teacher, TeacherModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User != null ? src.User.Password : string.Empty))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : string.Empty))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : string.Empty))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow))
                .ForMember(dest => dest.Matricule, opt => opt.MapFrom(src => src.RegistrationNumber))
                .ForMember(dest => dest.TitleId, opt => opt.MapFrom(src => src.TeacherTitleId))
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
                .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId));
            
            // ===== Academic Structure =====
            CreateMap<Program, ProgramModel>().ReverseMap();
            CreateMap<Track, TrackModel>().ReverseMap();
            CreateMap<Course, CourseModel>().ReverseMap();
            CreateMap<Group, GroupModel>().ReverseMap();
            
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
                .ForMember(dest => dest.SessionChanges,opt => opt.Ignore())
                .ForMember(dest => dest.Groups,opt => opt.Ignore())
                .ForMember(dest => dest.Teachers,opt => opt.Ignore());

            CreateMap<SessionType, SessionTypeModel>().ReverseMap();
            CreateMap<SessionStatus, SessionStatusModel>().ReverseMap();
            CreateMap<SessionChange, SessionChangeModel>().ReverseMap();
            
            // ===== Room =====
            CreateMap<Building, BuildingModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.BuildingId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name));
            CreateMap<Room, RoomModel>().ReverseMap();
            CreateMap<RoomType, RoomTypeModel>().ReverseMap();
            
            // ===== Other =====
            CreateMap<TeacherTitle, TeacherTitleModel>().ReverseMap();
            CreateMap<Assign, AssignModel>().ReverseMap();
            CreateMap<Availability, AvailabilityModel>().ReverseMap();
            CreateMap<Notification, NotificationModel>().ReverseMap();
            CreateMap<ChangeStatus, ChangeStatusModel>().ReverseMap();
            CreateMap<UnavailableDay, UnavailableDayModel>().ReverseMap();
            CreateMap<UnavailableDayType, UnavailabilityTypeModel>().ReverseMap();
        }
    }
}
