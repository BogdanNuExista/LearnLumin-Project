namespace LearnLumin.DAL.DTOs.CommunityAndInterraction;

public class PostResponseDto
{
    public string Id { get; set; } = null!;
  
    public string Title { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public string ForumId { get; set; } = null!;
    
    public string UserId { get; set; } = null!;
}