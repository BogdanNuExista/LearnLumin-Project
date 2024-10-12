namespace LearnLumin.DAL.DTOs.CommunityAndInterraction;

public class DiscussionForumRequestDto
{
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public string CreatorId { get; set; } = null!;
}