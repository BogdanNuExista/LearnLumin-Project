namespace LearnLumin.DAL.DTOs.UserAndRoles;

public class RoleResponseDto
{
    public string Id { get; set; } = null!;
    
    public string RoleName { get; set; } = null!;
    
    public string Permissions { get; set; } = null!;
    
}