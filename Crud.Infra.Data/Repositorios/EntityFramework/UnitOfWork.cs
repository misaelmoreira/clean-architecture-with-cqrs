using Crud.Domain.Interfaces;
using Crud.Infra.Data.Context;

namespace Crud.Infra.Data.Repositorios.EntityFramework;

public class UnitOfWork : IUnitOfWork
{
    protected readonly ApplicationDbContext _context;

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Commit(CancellationToken cancellationToken)
    {
        await _context.SaveChangesAsync(cancellationToken);
    }
}
