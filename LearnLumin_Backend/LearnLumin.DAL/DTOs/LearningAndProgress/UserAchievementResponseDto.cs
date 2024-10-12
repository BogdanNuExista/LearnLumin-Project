namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class UserAchievementResponseDto
{
    public string Id { get; set; } = null!;

    public DateTime EarnedDate { get; set; }
    
    public string UserId { get; set; } = null!;
    
    public string AchievementId { get; set; } = null!;
}