namespace LearnLumin.DAL.Entities.CoursesAndLessons;

public class Lesson
{
    public string Id { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string Content { get; set; } = null!;
    
    public int Order { get; set; }
    
    public DateTime CreatedDate { get; set; }
    
    public DateTime? UpdatedDate { get; set; }
    

    public Course Course { get; set; } = null!;
}