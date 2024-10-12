namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class AchievementRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public int Points { get; set; }
    
    public ICollection<UserAchievementResponseDto> UserAchievements { get; set; } = new List<UserAchievementResponseDto>();
}