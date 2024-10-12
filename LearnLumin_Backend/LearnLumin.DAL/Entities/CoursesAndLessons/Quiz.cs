using LearnLumin.DAL.Entities.LearningAndProgress;

namespace LearnLumin.DAL.Entities.CoursesAndLessons;

public class Quiz
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? UpdatedDate { get; set; }
    

    
    public Lesson Lesson { get; set; } = null!;
    
    public Course Course { get; set; } = null!;
    
    public ICollection<Question> Questions { get; set; } = new List<Question>();
    
    public ICollection<UserQuizResult> UserResults { get; set; } = new List<UserQuizResult>();
    
}