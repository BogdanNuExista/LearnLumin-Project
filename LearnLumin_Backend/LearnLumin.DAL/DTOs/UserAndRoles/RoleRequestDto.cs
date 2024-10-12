namespace LearnLumin.DAL.DTOs.UserAndRoles;

public class RoleRequestDto
{
    public string RoleName { get; set; } = null!;
    
    public string Permissions { get; set; } = null!;
    
    public ICollection<string> UserIds { get; set; } = new List<string>();
    
}