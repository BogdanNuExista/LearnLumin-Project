using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.CommunityAndInterraction;

public class Post
{
    public string Id { get; set; } = null!;
  
    public string Title { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    

    public DiscussionForum Forum { get; set; } = null!;
    public User User { get; set; } = null!;
    public ICollection<Comment> Comments { get; set; } = new List<Comment>();
}