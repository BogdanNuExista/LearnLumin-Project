namespace LearnLumin.DAL.Repositories;

public interface IRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<TEntity>> GetAllAsync();
    
    Task<TEntity?> GetByIdAsync(string id);
    
    Task<TEntity> AddAsync(TEntity entity);
    
    Task<TEntity> UpdateAsync(TEntity entity);
    
    Task<TEntity> DeleteAsync(string id);
}