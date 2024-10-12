namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class UserAchievementRequestDto
{
    public DateTime EarnedDate { get; set; }
    
    public string UserId { get; set; } = null!;
    
    public string AchievementId { get; set; } = null!;
}