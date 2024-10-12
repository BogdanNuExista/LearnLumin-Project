using LearnLumin.DAL.Entities.CoursesAndLessons;
using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.LearningAndProgress;

public class UserQuizResult
{
    public string Id { get; set; } = null!;

    public decimal Score { get; set; }
    
    public DateTime CompletionDate { get; set; }

    public User User { get; set; } = null!;
    public Quiz Quiz { get; set; } = null!;
}