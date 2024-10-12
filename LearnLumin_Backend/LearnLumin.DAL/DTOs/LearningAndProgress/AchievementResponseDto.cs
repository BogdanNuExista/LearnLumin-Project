﻿namespace LearnLumin.DAL.DTOs.LearningAndProgress;

public class AchievementResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public int Points { get; set; }
    
    public ICollection<UserAchievementResponseDto> UserAchievements { get; set; } = new List<UserAchievementResponseDto>();
}