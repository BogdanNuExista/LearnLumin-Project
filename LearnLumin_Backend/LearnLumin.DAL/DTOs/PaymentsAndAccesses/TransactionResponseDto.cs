namespace LearnLumin.DAL.DTOs.PaymentsAndAccesses;

public class TransactionResponseDto
{
    public string Id { get; set; } = null!;
    
    public decimal Amount { get; set; }
    
    public DateTime TransactionDate { get; set; }
    
    public string UserId { get; set; } = null!;
    
    public string CourseId { get; set; } = null!;
}