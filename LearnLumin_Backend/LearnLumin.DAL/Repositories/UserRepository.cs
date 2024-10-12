using LearnLumin.DAL.Entities.UsersAndRoles;
using Microsoft.EntityFrameworkCore;

namespace LearnLumin.DAL.Repositories;

public class UserRepository : BaseRepository<User>
{
    private readonly LearnLuminContext _context;
    
    public UserRepository(LearnLuminContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<User>> GetAllAsync()
    {
        try
        {
            return await _context.Users
                .Include(user => user.Profile)
                .Include(user => user.Roles)
                .Include(user => user.LearningPaths)
                .ThenInclude(path => path.Courses)
                .ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve users: {ex.Message}");
        }
    }
    
    public override async Task<User?> GetByIdAsync(string id)
    {
        try
        {
            return await _context.Users
                .Include(user => user.Profile)
                .Include(user => user.Roles)
                .Include(user => user.LearningPaths)
                .ThenInclude(path => path.Courses)
                .FirstOrDefaultAsync(user => user.Id == id);
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve user: {ex.Message}");
        }
    }
}