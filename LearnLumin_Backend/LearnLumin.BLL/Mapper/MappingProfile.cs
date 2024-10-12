using LearnLumin.DAL.DTOs.LearningAndProgress;
using LearnLumin.DAL.DTOs.PaymentsAndAccesses;
using LearnLumin.DAL.DTOs.StudyGroups;
using LearnLumin.DAL.DTOs.UserAndRoles;
using LearnLumin.DAL.Entities.LearningAndProgress;
using LearnLumin.DAL.Entities.PaymentsAndAccess;
using LearnLumin.DAL.Entities.StudyGroups;
using LearnLumin.DAL.Entities.UsersAndRoles;
using Profile = AutoMapper.Profile;
using ProfileClass = LearnLumin.DAL.Entities.UsersAndRoles.Profile;

namespace LearnLumin.BLL.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        // User to UserResponseDto
        CreateMap<User, UserResponseDto>()
            .ForMember(dest => dest.Roles, opt => opt.MapFrom(src => src.Roles
                .Select(role => new RoleResponseDto
                {
                    Id = role.Id,
                    RoleName = role.RoleName,
                    Permissions = role.Permissions
                })))
            .ForMember(dest => dest.Profile, opt => opt.MapFrom(src => src.Profile))
            .ForMember(dest => dest.LearningPaths, opt => opt.MapFrom(src => src.LearningPaths))
            .ForMember(dest => dest.Transactions, opt => opt.MapFrom(src => src.Transactions))
            .ForMember(dest => dest.CourseAccesses, opt => opt.MapFrom(src => src.CourseAccesses))
            .ForMember(dest => dest.Progresses, opt => opt.MapFrom(src => src.Progresses))
            .ForMember(dest => dest.QuizResults, opt => opt.MapFrom(src => src.QuizResults))
            .ForMember(dest => dest.GroupMemberships, opt => opt.MapFrom(src => src.GroupMemberships))
            .ForMember(dest => dest.StudyGroups, opt => opt.MapFrom(src => src.StudyGroups));

        // UserRequestDto to User
        CreateMap<UserRequestDto, User>()
            .ForMember(dest => dest.Id, opt => opt.Ignore())
            .ForMember(dest => dest.PasswordHash, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedDate, opt => opt.Ignore())
            .ForMember(dest => dest.LastLoginDate, opt => opt.Ignore())
            .ForMember(dest => dest.Roles, opt => opt.Ignore())
            .ForMember(dest => dest.Profile, opt => opt.Ignore())
            .ForMember(dest => dest.LearningPaths, opt => opt.Ignore())
            .ForMember(dest => dest.Transactions, opt => opt.Ignore())
            .ForMember(dest => dest.CourseAccesses, opt => opt.Ignore())
            .ForMember(dest => dest.Progresses, opt => opt.Ignore())
            .ForMember(dest => dest.QuizResults, opt => opt.Ignore())
            .ForMember(dest => dest.GroupMemberships, opt => opt.Ignore())
            .ForMember(dest => dest.StudyGroups, opt => opt.Ignore());
        
        // Profile to ProfileResponseDto
        CreateMap<ProfileClass, ProfileResponseDto>()
            .ForMember(dest => dest.UserId, opt => opt.MapFrom(src => src.User.Id))
            ;
        
        // ProfileRequestDto to Profile
        CreateMap<ProfileRequestDto, ProfileClass>()
            .ForMember(dest=>dest.Id, opt=>opt.Ignore())
            ;
        
        // ProfileRequestDto to ProfileResponseDto
        CreateMap<ProfileRequestDto, ProfileResponseDto>()
            .ForMember(dest=>dest.UserId, opt=>opt.Ignore())
            ;
        
        // ProfileUpdateDto to Profile
        CreateMap<ProfileUpdateDto, ProfileClass>()
            .ForMember(dest=>dest.Id, opt=>opt.Ignore())
            ;
        
        
        
        CreateMap<Role, RoleResponseDto>();
        CreateMap<LearningPath, LearningPathResponseDto>();
        CreateMap<Transaction, TransactionResponseDto>();
        CreateMap<UserCourseAccess, UserCourseAccessResponseDto>();
        CreateMap<UserProgress, UserProgressResponseDto>();
        CreateMap<UserQuizResult, UserQuizResultResponseDto>();
        CreateMap<GroupMembership, GroupMembershipResponseDto>();
        CreateMap<StudyGroup, StudyGroupResponseDto>();
        
    }
}