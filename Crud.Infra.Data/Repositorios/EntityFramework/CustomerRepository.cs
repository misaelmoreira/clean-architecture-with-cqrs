using Crud.Domain.Entities;
using Crud.Domain.Interfaces;
using Crud.Infra.Data.Context;

namespace Crud.Infra.Data.Repositorios.EntityFramework;
public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
{
    public CustomerRepository(ApplicationDbContext context) : base(context)
    {
    }
}
