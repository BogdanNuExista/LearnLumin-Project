namespace LearnLumin.DAL.DTOs.CommunityAndInterraction;

public class DiscussionForumResponseDto
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public string CreatorId { get; set; } = null!;
}