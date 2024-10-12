namespace LearnLumin.DAL.Entities.UsersAndRoles;

public class Role
{
    public string Id { get; set; } = null!;
    
    public string RoleName { get; set; } = null!;
    
    public string Permissions { get; set; } = null!;
    
    
    public ICollection<User> Users { get; set; } = new List<User>();
}