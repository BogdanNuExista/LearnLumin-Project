using LearnLumin.DAL.Entities.UsersAndRoles;

namespace LearnLumin.DAL.Entities.LearningAndProgress;

public class UserAchievement
{
    public string Id { get; set; } = null!;

    public DateTime EarnedDate { get; set; }

    public User User { get; set; } = null!;
    public Achievement Achievement { get; set; } = null!;
}