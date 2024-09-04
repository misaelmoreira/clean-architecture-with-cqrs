using Crud.Domain.Entities;
using Crud.Domain.Interfaces;

namespace Crud.Infra.Data.Repositorios.Memoria;
public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
{
    protected readonly List<T> _context;

    public BaseRepository(List<T> context)
    {
         _context = context;        
    }

    public void Create(T entity)
    {
        entity.DateCreated = DateTimeOffset.UtcNow;
        entity.Id = Guid.NewGuid();
        _context.Add(entity);
    }

    public void Update(T entity)
    {
        entity.DateUpdated = DateTimeOffset.UtcNow;
        var dado = _context.FirstOrDefault(d => d.Id == entity.Id);

        if (dado != null)
        {
            var index = _context.IndexOf(dado);
            _context[index] = dado;
        }
    }

    public async Task<T> GetById(Guid id)
    {
        var dado = _context.FirstOrDefault(d => d.Id == id);
        return await Task.FromResult(dado);
    }

    public async Task<IEnumerable<T>> GetAll()
    {
        return await Task.FromResult(_context);
    }

    public void Delete(T entity)
    {
        entity.DateDeleted = DateTimeOffset.UtcNow;
        _context.Remove(entity);
    }
}
