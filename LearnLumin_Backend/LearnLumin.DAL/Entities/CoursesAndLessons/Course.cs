using LearnLumin.DAL.Entities.LearningAndProgress;
using LearnLumin.DAL.Entities.PaymentsAndAccess;
using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.CoursesAndLessons;

public class Course
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Category { get; set; } = null!;
    
    public decimal Price { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? UpdatedDate { get; set; }
    
    
    public User Creator { get; set; } = null!;
    public LearningPath LearningPath { get; set; } = null!;
    public ICollection<Lesson> Lessons { get; set; } = new List<Lesson>();
    public ICollection<Quiz> Quizzes { get; set; } = new List<Quiz>();
    public ICollection<UserCourseAccess> UserAccesses { get; set; } = new List<UserCourseAccess>();
    public ICollection<UserProgress> UserProgresses { get; set; } = new List<UserProgress>();
    
}