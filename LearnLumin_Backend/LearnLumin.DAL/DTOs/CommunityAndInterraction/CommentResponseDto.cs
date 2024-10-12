namespace LearnLumin.DAL.DTOs.CommunityAndInterraction;

public class CommentResponseDto
{
    public string Id { get; set; } = null!;

    public string Content { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    
    public string PostId { get; set; } = null!;
    
    public string UserId { get; set; } = null!;
}