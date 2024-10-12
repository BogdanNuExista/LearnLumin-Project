using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.AdministrationAndModeration;

public class ContentReport
{
    public string Id { get; set; } = null!;
    
    public string ContentType { get; set; } = null!;

    public string ReportReason { get; set; } = null!;
    
    public DateTime ReportDate { get; set; }
    
    public string ResolutionStatus { get; set; } = null!;
    

    public User ReportedBy { get; set; } = null!;
}