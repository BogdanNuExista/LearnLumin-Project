namespace LearnLumin.DAL.DTOs.PaymentsAndAccesses;

public class TransactionRequestDto
{
    public decimal Amount { get; set; }
    
    public string UserId { get; set; } = null!;
    
    public string CourseId { get; set; } = null!;
}