using AutoMapper;
using HP2.Domain.Models;
using HP2.Infrastructure.Persistence.Entities;

namespace HP2.Infrastructure.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // User mappings
            CreateMap<User, UserModel>().ReverseMap();
            
            // Admin mapping - Map from Admin entity (with User navigation) to AdminModel
            CreateMap<Admin, AdminModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User != null ? src.User.Password : string.Empty))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : string.Empty))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : string.Empty))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow));
            
            // Teacher mapping - Map from Teacher entity (with User navigation) to TeacherModel
            CreateMap<Teacher, TeacherModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User != null ? src.User.Password : string.Empty))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : string.Empty))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : string.Empty))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow))
                .ForMember(dest => dest.Matricule, opt => opt.MapFrom(src => src.RegistrationNumber))
                .ForMember(dest => dest.TitleId, opt => opt.MapFrom(src => src.TeacherTitleId));
            
            // Student mapping - Map from Student entity (with User navigation) to StudentModel
            CreateMap<Student, StudentModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.UserId))
                .ForMember(dest => dest.Email, opt => opt.MapFrom(src => src.User != null ? src.User.Email : string.Empty))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => src.User != null ? src.User.Password : string.Empty))
                .ForMember(dest => dest.FirstName, opt => opt.MapFrom(src => src.User != null ? src.User.FirstName : string.Empty))
                .ForMember(dest => dest.LastName, opt => opt.MapFrom(src => src.User != null ? src.User.LastName : string.Empty))
                .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.User != null ? src.User.PhoneNumber : null))
                .ForMember(dest => dest.CreatedAt, opt => opt.MapFrom(src => src.User != null ? src.User.CreatedAt : DateTime.UtcNow))
                .ForMember(dest => dest.GroupId, opt => opt.MapFrom(src => src.GroupId));
            
            // Academic structure mappings
            CreateMap<Program, ProgramModel>().ReverseMap();
            CreateMap<Track, TrackModel>().ReverseMap();
            CreateMap<Course, CourseModel>().ReverseMap();
            CreateMap<Group, GroupModel>().ReverseMap();
            
            // Session mappings
            CreateMap<Session, SessionModel>().ReverseMap();
            CreateMap<SessionType, SessionTypeModel>().ReverseMap();
            CreateMap<SessionStatus, SessionStatusModel>().ReverseMap();
            CreateMap<SessionChange, SessionChangeModel>().ReverseMap();
            
            // Room mappings
            CreateMap<Building, BuildingModel>().ReverseMap();
            CreateMap<Room, RoomModel>().ReverseMap();
            CreateMap<RoomType, RoomTypeModel>().ReverseMap();
            
            // Other mappings
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
