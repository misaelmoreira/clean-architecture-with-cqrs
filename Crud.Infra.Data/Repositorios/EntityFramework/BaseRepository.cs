using Crud.Domain.Entities;
using Crud.Domain.Interfaces;
using Crud.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infra.Data.Repositorios.EntityFramework;
public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly ApplicationDbContext Context;

    public BaseRepository(ApplicationDbContext context)
    {   
        Context = context;       
    }

    public void Create(T entity)
    {
        entity.DateCreated = DateTimeOffset.UtcNow;
        Context.Add(entity);
    }

    public void Update(T entity)
    {
        entity.DateUpdated = DateTimeOffset.UtcNow;
        Context.Update(entity);
    }

    public async Task<T> GetById(Guid id)
    {
        return await Context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await Context.Set<T>().ToListAsync();
    }

    public void Delete(T entity)
    {
        entity.DateDeleted = DateTimeOffset.UtcNow;
        Context.Remove(entity);
    }
}
