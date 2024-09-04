using Crud.Domain.Interfaces;

namespace Crud.Infra.Data.Repositorios.Memoria;

public class UnitOfWork : IUnitOfWork
{
    protected readonly List<string> _context;

    public UnitOfWork()
    {
        _context = new List<string>();
    }

    public async Task Commit(CancellationToken cancellationToken)
    {
        await Task.Delay(100, cancellationToken); // Simula um atraso para a operação assíncrona
        Console.WriteLine("Changes saved to the context.");
    }
}
