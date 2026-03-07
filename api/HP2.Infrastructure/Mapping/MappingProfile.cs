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
                .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.User != null ? Enum.Parse<HP2.Domain.Enums.UserRole>(src.User.UserRole.Name, true) : HP2.Domain.Enums.UserRole.TEACHER))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow))
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
                .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId));
            
            // ===== Academic Structure =====
            CreateMap<Program, ProgramModel>().ReverseMap();
            CreateMap<Track, TrackModel>().ReverseMap();
            CreateMap<Course, CourseModel>().ReverseMap();
            CreateMap<Group, GroupModel>().ReverseMap();
            
            // ===== Session =====
            CreateMap<Session, SessionModel>().ReverseMap();
            CreateMap<SessionType, SessionTypeModel>().ReverseMap();
            CreateMap<SessionStatus, SessionStatusModel>().ReverseMap();
            CreateMap<SessionChange, SessionChangeModel>().ReverseMap();
            
            // ===== Room =====
            CreateMap<Building, BuildingModel>().ReverseMap();
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
