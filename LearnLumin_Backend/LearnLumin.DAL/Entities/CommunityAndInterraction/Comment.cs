using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.CommunityAndInterraction;

public class Comment
{
    public string Id { get; set; } = null!;

    public string Content { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }

    public Post Post { get; set; } = null!;
    public User User { get; set; } = null!;
}