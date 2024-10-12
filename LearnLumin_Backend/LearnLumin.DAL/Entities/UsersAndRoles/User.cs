using LearnLumin.DAL.Entities.LearningAndProgress;
using LearnLumin.DAL.Entities.PaymentsAndAccess;
using LearnLumin.DAL.Entities.StudyGroups;

namespace LearnLumin.DAL.Entities.UsersAndRoles;

public class User
{
    public string Id { get; set; } = null!;
    
    public string Username { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    
    public string PasswordHash { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? LastLoginDate { get; set; }
    
    
    public ICollection<Role> Roles { get; set; } = new List<Role>();
    public Profile Profile { get; set; } = null!;
    public ICollection<LearningPath> LearningPaths { get; set; } = new List<LearningPath>();
    public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
    public ICollection<UserCourseAccess> CourseAccesses { get; set; } = new List<UserCourseAccess>();
    public ICollection<UserProgress> Progresses { get; set; } = new List<UserProgress>();
    public ICollection<UserQuizResult> QuizResults { get; set; } = new List<UserQuizResult>();
    public ICollection<GroupMembership> GroupMemberships { get; set; } = new List<GroupMembership>();
    
    public ICollection<StudyGroup> StudyGroups { get; set; } = new List<StudyGroup>();
    
}