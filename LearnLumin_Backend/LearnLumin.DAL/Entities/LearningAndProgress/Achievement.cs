namespace LearnLumin.DAL.Entities.LearningAndProgress;

public class Achievement
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public int Points { get; set; }

    public ICollection<UserAchievement> UserAchievements { get; set; } = new List<UserAchievement>();
}