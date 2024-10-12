namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class QuestionRequestDto
{
    public string Content { get; set; } = null!;
    
    public string QuestionType { get; set; } = null!;
    
    public int Order { get; set; }
    
    public string QuizId { get; set; } = null!;
}