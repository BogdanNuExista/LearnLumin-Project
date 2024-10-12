using LearnLumin.DAL.DTOs.LearningAndProgress;
using LearnLumin.DAL.DTOs.PaymentsAndAccesses;
using LearnLumin.DAL.DTOs.StudyGroups;

namespace LearnLumin.DAL.DTOs.UserAndRoles;

public class UserResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Username { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }

    public DateTime? LastLoginDate { get; set; }
    
    
    public ICollection<RoleResponseDto> Roles { get; set; } = new List<RoleResponseDto>();
    
    public ProfileResponseDto Profile { get; set; } = null!;
    
    public ICollection<LearningPathResponseDto> LearningPaths{ get; set; } = new List<LearningPathResponseDto>();
    
    public ICollection<TransactionResponseDto> Transactions { get; set; } = new List<TransactionResponseDto>();
    
    public ICollection<UserCourseAccessResponseDto> CourseAccesses { get; set; } = new List<UserCourseAccessResponseDto>();
    
    public ICollection<UserProgressResponseDto> Progresses { get; set; } = new List<UserProgressResponseDto>();
    
    public ICollection<UserQuizResultResponseDto> QuizResults { get; set; } = new List<UserQuizResultResponseDto>();
    
    public ICollection<GroupMembershipResponseDto> GroupMemberships { get; set; } = new List<GroupMembershipResponseDto>();
    
    public ICollection<StudyGroupResponseDto> StudyGroups { get; set; } = new List<StudyGroupResponseDto>();
    
}
