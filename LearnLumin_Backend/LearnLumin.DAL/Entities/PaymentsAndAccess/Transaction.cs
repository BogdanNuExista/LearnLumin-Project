using LearnLumin.DAL.Entities.CoursesAndLessons;
using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.PaymentsAndAccess;

public class Transaction
{
    public string Id { get; set; } = null!;
    
    public decimal Amount { get; set; }
    
    public DateTime TransactionDate { get; set; }

    
    public User User { get; set; } = null!;
    
    public Course Course { get; set; } = null!;
}