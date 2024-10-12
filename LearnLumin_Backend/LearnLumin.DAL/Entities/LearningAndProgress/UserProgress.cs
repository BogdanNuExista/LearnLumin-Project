using LearnLumin.DAL.Entities.CoursesAndLessons;
using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.LearningAndProgress;

public class UserProgress
{
    public string Id { get; set; } = null!;

    public decimal ProgressPercentage { get; set; }
    
    public DateTime LastAccessedDate { get; set; }

    public User User { get; set; } = null!;
    public Course Course { get; set; } = null!;
    public Lesson Lesson { get; set; } = null!;
}