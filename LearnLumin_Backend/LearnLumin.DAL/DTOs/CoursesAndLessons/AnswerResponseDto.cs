namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class AnswerResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public bool IsCorrect { get; set; }
    
    public string QuestionId { get; set; } = null!;
}