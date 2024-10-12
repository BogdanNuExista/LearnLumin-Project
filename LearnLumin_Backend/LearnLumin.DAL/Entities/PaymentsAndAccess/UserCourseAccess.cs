using LearnLumin.DAL.Entities.CoursesAndLessons;
using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.PaymentsAndAccess;

public class UserCourseAccess
{
    public string Id { get; set; } = null!;
        
    public DateTime AccessGrantedDate { get; set; }

        
    public User User { get; set; } = null!;
        
    public Course Course { get; set; } = null!;
}