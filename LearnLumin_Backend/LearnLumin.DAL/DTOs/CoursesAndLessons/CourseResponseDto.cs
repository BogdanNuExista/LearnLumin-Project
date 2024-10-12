using LearnLumin.DAL.DTOs.LearningAndProgress;
using LearnLumin.DAL.DTOs.PaymentsAndAccesses;

namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class CourseResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public string Category { get; set; } = null!;
    
    public decimal Price { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? UpdatedDate { get; set; }

    public string CreatorId { get; set; } = null!;
    
    public string LearningPathId { get; set; } = null!;
    
    public ICollection<LessonResponseDto> Lessons { get; set; } = new List<LessonResponseDto>();
    
    public ICollection<QuizResponseDto> Quizzes { get; set; } = new List<QuizResponseDto>();
    
    public ICollection<UserCourseAccessResponseDto> UserAccesses { get; set; } = new List<UserCourseAccessResponseDto>();
    
    public ICollection<UserProgressResponseDto> UserProgresses { get; set; } = new List<UserProgressResponseDto>();
}