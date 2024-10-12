
namespace LearnLumin.DAL.Entities.CoursesAndLessons;

public class Question
{
    public string Id { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public string QuestionType { get; set; } = null!;
    
    public int Order { get; set; }
    

    public Quiz Quiz { get; set; } = null!;
    
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
}