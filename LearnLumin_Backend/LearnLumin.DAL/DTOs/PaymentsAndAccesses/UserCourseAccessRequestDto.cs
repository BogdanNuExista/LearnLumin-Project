
namespace LearnLumin.DAL.DTOs.PaymentsAndAccesses;

public class UserCourseAccessRequestDto
{
    public DateTime AccessGrantedDate { get; set; }
    
    public string UserId { get; set; } = null!;
    
    public string CourseId { get; set; } = null!;
}