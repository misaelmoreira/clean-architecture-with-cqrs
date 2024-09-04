using Crud.Domain.Entities;
using Crud.Domain.Interfaces;

namespace Crud.Infra.Data.Repositorios.Memoria
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        public static List<Customer> _context = new List<Customer>
        {
            new Customer
            {
                Id = Guid.NewGuid(),
                Nome = "tester",
                Email = "tester@teste.com",
                Telefone = "15 151515",
            },
            new Customer
            {
                Id = Guid.NewGuid(),
                Nome = "tester2",
                Email = "tester2@teste.com",
                Telefone = "15 151515",
            }
        };

        public CustomerRepository() : base(_context)
        {
        }
    }
}
