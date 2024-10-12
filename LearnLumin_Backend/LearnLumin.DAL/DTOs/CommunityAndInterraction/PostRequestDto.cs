namespace LearnLumin.DAL.DTOs.CommunityAndInterraction;

public class PostRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public string ForumId { get; set; } = null!;
    
    public string UserId { get; set; } = null!;
    
}