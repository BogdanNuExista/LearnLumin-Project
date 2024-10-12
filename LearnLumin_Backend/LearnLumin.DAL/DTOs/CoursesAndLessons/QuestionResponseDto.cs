namespace LearnLumin.DAL.DTOs.CoursesAndLessons;

public class QuestionResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public string QuestionType { get; set; } = null!;
    
    public int Order { get; set; }
    
    public string QuizId { get; set; } = null!;
    
    public ICollection<AnswerResponseDto> Answers { get; set; } = new List<AnswerResponseDto>();
}