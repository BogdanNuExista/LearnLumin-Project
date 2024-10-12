using Microsoft.EntityFrameworkCore;

namespace LearnLumin.DAL.Repositories;

public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly LearnLuminContext _context;
    
    public BaseRepository(LearnLuminContext context)
    {
        _context = context;
    }


    public virtual async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        try
        {  
            return await _context.Set<TEntity>().ToListAsync();
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve entities: {ex.Message}");
        }
    }

    public virtual async Task<TEntity?> GetByIdAsync(string id)
    {
        try
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't retrieve entity: {ex.Message}");
        }
    }

    public virtual async Task<TEntity> AddAsync(TEntity entity)
    {
        try
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't add entity: {ex.Message}");
        }
    }

    public virtual async Task<TEntity> UpdateAsync(TEntity entity)
    {
        try
        {
            _context.Set<TEntity>().Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't update entity: {ex.Message}");
        }
    }

    public virtual async Task<TEntity> DeleteAsync(string id)
    {
        try
        {
            var entity = await _context.Set<TEntity>().FindAsync(id);
            if (entity == null)
            {
                throw new Exception("Entity not found");
            }
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
        catch (Exception ex)
        {
            throw new Exception($"Couldn't delete entity: {ex.Message}");
        }
    }
}