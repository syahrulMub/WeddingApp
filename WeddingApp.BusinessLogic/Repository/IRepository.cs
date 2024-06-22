using System.Linq.Expressions;
using WeddingApp.BusinessLogic.DatabaseContext.Entity.Interface;

namespace WeddingApp.BusinessLogic.Repository;

public interface IRepository<TEntity> where TEntity : class, IEntity
{
    IQueryable<TEntity> GetAll(bool includeDeleted = false);
    Task<TEntity> GetById(int id, bool includeDeleted = false);
    Task<TEntity> Add(TEntity entity, int userId);
    Task<TEntity> Update(TEntity entity, int userId);
    Task UpdateBatch(List<TEntity> entities, int userId);
    Task<TEntity> SoftDelete(int id, int userId);
    Task<TEntity> Delete(int id, int userId);
    IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression);
}
