using LearnLumin.DAL.Configurations.AdministrationAndModeration;
using LearnLumin.DAL.Configurations.CommunityAndInteraction;
using LearnLumin.DAL.Configurations.CoursesAndLessons;
using LearnLumin.DAL.Configurations.IntegrationAndExternal;
using LearnLumin.DAL.Configurations.LearningAndProgress;
using LearnLumin.DAL.Configurations.PaymentsAndAccesses;
using LearnLumin.DAL.Configurations.PaymentsAndAccessesConfiguration;
using LearnLumin.DAL.Configurations.StudyGroups;
using LearnLumin.DAL.Configurations.UserAndRoles;
using LearnLumin.DAL.Entities.AdministrationAndModeration;
using LearnLumin.DAL.Entities.CommunityAndInterraction;
using LearnLumin.DAL.Entities.CoursesAndLessons;
using LearnLumin.DAL.Entities.IntegrationAndExternal;
using LearnLumin.DAL.Entities.LearningAndProgress;
using LearnLumin.DAL.Entities.PaymentsAndAccess;
using LearnLumin.DAL.Entities.StudyGroups;
using LearnLumin.DAL.Entities.UsersAndRoles;
using Microsoft.EntityFrameworkCore;

namespace LearnLumin.DAL;

public class LearnLuminContext(DbContextOptions<LearnLuminContext> options) : DbContext(options)
{
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<Profile> Profiles { get; set; }
    
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Quiz> Quizzes { get; set; }
    public DbSet<Lesson> Lessons { get; set; }
    public DbSet<Course> Courses { get; set; }
    
    public DbSet<StudyGroup> StudyGroups { get; set; }
    public DbSet<GroupMembership> GroupMemberships { get; set; }
    
    public DbSet<Achievement> Achievements { get; set; }
    public DbSet<LearningPath> LearningPaths { get; set; }
    public DbSet<UserAchievement> UserAchievements { get; set; }
    public DbSet<UserProgress> UserProgresses { get; set; }
    public DbSet<UserQuizResult> UserQuizResults { get; set; }
    
    public DbSet<Transaction> Transactions { get; set; }
    public DbSet<UserCourseAccess> UserCourseAccesses { get; set; }
    
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Post> Posts { get; set; }
    public DbSet<DiscussionForum> DiscussionForums { get; set; }
    
    public DbSet<ContentReport> ContentReports { get; set; }
    public DbSet<UserActivityLog> UserActivityLogs { get; set; }
    
    public DbSet<CorporateClient> CorporateClients { get; set; }
    public DbSet<LmsIntegration> LmsIntegrations { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        base.OnModelCreating(modelBuilder);

        //  modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly); // This line will apply all configurations in the assembly

        new UserConfiguration().Configure(modelBuilder.Entity<User>());
        new RoleConfiguration().Configure(modelBuilder.Entity<Role>());
        modelBuilder.Entity<Role>().HasData(
            new Role { Id = Guid.NewGuid().ToString(), RoleName = "Admin", Permissions = "FullAccess" },
            new Role { Id = Guid.NewGuid().ToString(), RoleName = "User", Permissions = "ReadOnly" },
            new Role { Id = Guid.NewGuid().ToString(), RoleName = "Moderator", Permissions = "ReadWrite" }
            );
        new ProfileConfiguration().Configure(modelBuilder.Entity<Profile>());
        
        new AnswerConfiguration().Configure(modelBuilder.Entity<Answer>());
        new QuestionConfiguration().Configure(modelBuilder.Entity<Question>());
        new QuizConfiguration().Configure(modelBuilder.Entity<Quiz>());
        new LessonConfiguration().Configure(modelBuilder.Entity<Lesson>());
        new CourseConfiguration().Configure(modelBuilder.Entity<Course>());
        
        new StudyGroupConfiguration().Configure(modelBuilder.Entity<StudyGroup>());
        new GroupMembershipConfiguration().Configure(modelBuilder.Entity<GroupMembership>());
        
        new AchievementConfiguration().Configure(modelBuilder.Entity<Achievement>());
        new LearningPathConfiguration().Configure(modelBuilder.Entity<LearningPath>());
        new UserAchievementConfiguration().Configure(modelBuilder.Entity<UserAchievement>());
        new UserProgressConfiguration().Configure(modelBuilder.Entity<UserProgress>());
        new UserQuizResultConfiguration().Configure(modelBuilder.Entity<UserQuizResult>());
        
        new TransactionConfiguration().Configure(modelBuilder.Entity<Transaction>()); 
        new UserCourseAccessConfiguration().Configure(modelBuilder.Entity<UserCourseAccess>());
        
        new CommentConfiguration().Configure(modelBuilder.Entity<Comment>());
        new PostConfiguration().Configure(modelBuilder.Entity<Post>());
        new DiscussionForumConfiguration().Configure(modelBuilder.Entity<DiscussionForum>());
        
        new ContentReportConfiguration().Configure(modelBuilder.Entity<ContentReport>());
        new UserActivityLogConfiguration().Configure(modelBuilder.Entity<UserActivityLog>());
        
        new CorporateClientConfiguration().Configure(modelBuilder.Entity<CorporateClient>());
        new LMSIntegrationConfiguration().Configure(modelBuilder.Entity<LmsIntegration>());
    }
}