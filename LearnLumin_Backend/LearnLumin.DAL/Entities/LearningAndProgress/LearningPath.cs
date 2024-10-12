using LearnLumin.DAL.Entities.CoursesAndLessons;
using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.LearningAndProgress;

public class LearningPath
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public User User { get; set; } = null!;
    
    public ICollection<Course> Courses { get; set; } = new List<Course>();
}