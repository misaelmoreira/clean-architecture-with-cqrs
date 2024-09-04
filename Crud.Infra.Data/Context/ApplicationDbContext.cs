using Crud.Domain.Entities;
using Crud.Infra.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Crud.Infra.Data.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) {}

    public DbSet<Customer> Customers { get; set;}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfiguration(new CustomerConfiguration());
    }    
}