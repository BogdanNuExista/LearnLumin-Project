namespace LearnLumin.DAL.Entities.CoursesAndLessons;

public class Answer
{
    public string Id { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public bool IsCorrect { get; set; }
    

    public Question Question { get; set; } = null!;
}