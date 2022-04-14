namespace TestTask.Abstractions
{
    public interface IBaseRepository<TEntity>
    {
        public Task<TEntity> GetByIdAsync(int id);
        public Task<IEnumerable<TEntity>> GetAllAsync(int id);
        public Task<TEntity> CreateAsync(TEntity entity);
        public Task UpdateAsync(TEntity entity);
        public Task DeleteAsync(TEntity entity);
    }
}
