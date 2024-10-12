namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class UserQuizResultResponseDto
{
    public string Id { get; set; } = null!;

    public decimal Score { get; set; }
    
    public DateTime CompletionDate { get; set; }

    public string UserId { get; set; } = null!;
    public string QuizId { get; set; } = null!;
}