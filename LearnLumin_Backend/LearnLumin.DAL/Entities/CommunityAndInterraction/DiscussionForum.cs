using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.CommunityAndInterraction;

public class DiscussionForum
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Description { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }
    

    public User Creator { get; set; } = null!;
    public ICollection<Post> Posts { get; set; } = new List<Post>();
}