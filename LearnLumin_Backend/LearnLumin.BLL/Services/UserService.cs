using AutoMapper;
using LearnLumin.BLL.Interfaces;
using LearnLumin.DAL.DTOs.UserAndRoles;
using LearnLumin.DAL.Entities.UsersAndRoles;
using LearnLumin.DAL.Repositories;

namespace LearnLumin.BLL.Services;

public class UserService : IUserService
{
    private readonly UserRepository _userRepository;
    private readonly IRepository<Role> _roleRepository;
    private readonly IMapper _mapper;
    
    public UserService(UserRepository userRepository, IRepository<Role> roleRepository, IMapper mapper)
    {
        _userRepository = userRepository;
        _roleRepository = roleRepository;
        _mapper = mapper;
    }
    
    
    /*
    public async Task<IEnumerable<UserResponseDto>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return users.Select(user => new UserResponseDto
        {
            Id = user.Id,
            Username = user.Username,
            Email = user.Email,
            CreatedDate = user.CreatedDate,
            LastLoginDate = user.LastLoginDate,
            
            Roles = user.Roles.Select(role => new RoleResponseDto
            {
                Id = role.Id,
                RoleName = role.RoleName,
                Permissions = role.Permissions
            }).ToList(),
            
            Profile = new ProfileResponseDto
            {
                Id = user.Profile.Id,
                Bio = user.Profile.Bio,
                ProfilePicture = user.Profile.ProfilePicture,
                Location = user.Profile.Location,
                Preferences = user.Profile.Preferences,
                UserId = user.Id
            },
            
            LearningPaths = user.LearningPaths.Select(path => new LearningPathResponseDto
            {
                Id = path.Id,
                Title = path.Title,
                Description = path.Description,
                CreatedDate = path.CreatedDate,
                UserId = path.User.Id,
                CourseTitles = path.Courses.Select(course => course.Title).ToList()
            }).ToList(),
            
            Transactions = user.Transactions.Select(transaction => new TransactionResponseDto
            {
                Id = transaction.Id,
                Amount = transaction.Amount,
                TransactionDate = transaction.TransactionDate,
                UserId = transaction.User.Id,
                CourseId = transaction.Course.Id
            }).ToList(),
            
            CourseAccesses = user.CourseAccesses.Select(access => new UserCourseAccessResponseDto
            {
                Id = access.Id,
                AccessGrantedDate = access.AccessGrantedDate,
                UserId = access.User.Id,
                CourseId = access.Course.Id
            }).ToList(),
            
            Progresses = user.Progresses.Select(progress => new UserProgressResponseDto
            {
                Id = progress.Id,
                ProgressPercentage = progress.ProgressPercentage,
                LastAccessedDate = progress.LastAccessedDate,
                UserId = progress.User.Id,
                CourseId = progress.Course.Id,
                LessonId = progress.Lesson.Id
            }).ToList(),
            
            QuizResults = user.QuizResults.Select(result => new UserQuizResultResponseDto
            {
                Id = result.Id,
                Score = result.Score,
                CompletionDate = result.CompletionDate,
                UserId = result.User.Id,
                QuizId = result.Quiz.Id
            }).ToList(),
            
            GroupMemberships = user.GroupMemberships.Select(membership => new GroupMembershipResponseDto
            {
                Id = membership.Id,
                JoinDate = membership.JoinDate,
                StudyGroupId = membership.StudyGroup.Id,
                UserId = membership.User.Id
            }).ToList(),
            
            StudyGroups = user.StudyGroups.Select(group => new StudyGroupResponseDto
            {
                Id = group.Id,
                Title = group.Title,
                Description = group.Description,
                CreatedDate = group.CreatedDate,
                CreatorUsername = group.Creator.Username
            }).ToList()
            
        });
    }
    */
    
    public async Task<IEnumerable<UserResponseDto>> GetAllUsersAsync()
    {
        var users = await _userRepository.GetAllAsync();
        return _mapper.Map<IEnumerable<UserResponseDto>>(users);
    }

    public async Task<UserResponseDto?> GetUserByIdAsync(string id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        return _mapper.Map<UserResponseDto>(user);
    }

    public async Task<UserResponseDto> CreateUserAsync(UserRequestDto userRequestDto)
    {
        var user = _mapper.Map<User>(userRequestDto);
        
        user.CreatedDate = DateTime.Now;
        user.PasswordHash = BCrypt.Net.BCrypt.HashPassword(userRequestDto.Password);
        
        var defaultRole = _roleRepository.GetAllAsync().Result.FirstOrDefault(role => role.RoleName == "User");
        
        if (defaultRole == null)
        {
            throw new ApplicationException("Default role not found");
        }
        
        user.Roles = new List<Role> {defaultRole};
        
        var createdUser = await _userRepository.AddAsync(user);
        
        return _mapper.Map<UserResponseDto>(createdUser);
    }

    public async Task<UserResponseDto?> UpdateUserAsync(string id, UserRequestDto userRequestDto)
    {
        var user = await _userRepository.GetByIdAsync(id);
        
        if (user == null)
        {
            return null;
        }
        
        _mapper.Map(userRequestDto, user);
        
        var updatedUser = await _userRepository.UpdateAsync(user);
        
        return _mapper.Map<UserResponseDto>(updatedUser);
    }

    public async Task<UserResponseDto?> DeleteUserAsync(string id)
    {
        var user = await _userRepository.GetByIdAsync(id);
        
        if (user == null)
        {
            return null;
        }
        
        await _userRepository.DeleteAsync(user.Id);
        
        return _mapper.Map<UserResponseDto>(user);
    }
    
    
    
    
    public async Task<UserResponseDto?> AddRoleToUserAsync(string userId, string roleId)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        var role = await _roleRepository.GetByIdAsync(roleId);
        
        if (user == null || role == null)
        {
            return null;
        }
        
        if(user.Roles.All(r => r.Id != role.Id))
        {
            user.Roles.Add(role);
            await _userRepository.UpdateAsync(user);
        }
        
        return _mapper.Map<UserResponseDto>(user);
    } 
    
    public async Task<UserResponseDto?> RemoveRoleFromUserAsync(string userId, string roleId)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        var role = await _roleRepository.GetByIdAsync(roleId);
        
        if (user == null || role == null)
        {
            return null;
        }
        
        user.Roles.Remove(role);
        
        var updatedUser = await _userRepository.UpdateAsync(user);
        
        return _mapper.Map<UserResponseDto>(updatedUser);
    }
    
    
    
    
    
    public async Task<UserResponseDto?> UpdateProfileAsync(string userId, ProfileUpdateDto profileUpdateDto)
    {
        var user = await _userRepository.GetByIdAsync(userId);
        
        if (user == null)
        {
            return null;
        }
        
        _mapper.Map(profileUpdateDto, user.Profile);
        
        var updatedUser = await _userRepository.UpdateAsync(user);
        
        return _mapper.Map<UserResponseDto>(updatedUser);
    }
    
}



