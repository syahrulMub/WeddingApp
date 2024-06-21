using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using WeddingApp.BusinessLogic.DatabaseContext;
using WeddingApp.BusinessLogic.DatabaseContext.Entity;
using WeddingApp.BusinessLogic.DatabaseContext.Entity.Interface;

namespace WeddingApp.BusinessLogic.Repository;

public abstract class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class, IEntity
{
    private readonly ApplicationDbContext _context;
    public BaseRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public IQueryable<TEntity> GetAll(bool includeDeleted = false)
    {
        if(includeDeleted == true)
        {
            return _context.Set<TEntity>().AsNoTracking();
        }
        else
        {
            return _context.Set<TEntity>().Where(x => x.IsActive == true).AsNoTracking();
        }
    }
    public async Task<TEntity> GetById(int id, bool includeDeleted = false)
    {
        if(includeDeleted == true)
        {
            return await _context.Set<TEntity>().Where(x => x.Id == id).AsNoTracking().FirstOrDefaultAsync();
        }
        else
        {
            return await _context.Set<TEntity>().Where(x => x.Id == id && x.IsActive == true).AsNoTracking().FirstOrDefaultAsync();
        }
    }
    public async Task<TEntity> Add(TEntity entity, int userId)
    {
        entity.IsActive = true;
        entity.CreatedDate = DateTime.Now;
        entity.CreatedBy = userId;
        _context.Set<TEntity>().Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<TEntity> Update(TEntity entity, int userId)
    {
        entity.UpdatedDate = DateTime.Now;
        entity.UpdatedBy = userId;
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<TEntity> SoftDelete(int id, int userId)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        if(entity == null)
        {
            return entity;
        }
        entity.IsActive = false;
        entity.UpdatedDate = DateTime.Now;
        entity.UpdatedBy = userId;
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }
    public async Task<TEntity> Delete(int id, int userId)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id);
        if(entity == null)
        {
            return entity;
        }
        _context.Set<TEntity>().Remove(entity);
        await _context.SaveChangesAsync();   
        return entity;
    }
    public IQueryable<TEntity> GetByCondition(Expression<Func<TEntity, bool>> expression)
    {
        return _context.Set<TEntity>().Where(expression);
    }
}
