namespace LearnLumin.DAL.DTOs.PaymentsAndAccesses;

public class UserCourseAccessResponseDto
{
    public string Id { get; set; } = null!;
    
    public DateTime AccessGrantedDate { get; set; }
    
    public string UserId { get; set; } = null!;
    
    public string CourseId { get; set; } = null!;
}