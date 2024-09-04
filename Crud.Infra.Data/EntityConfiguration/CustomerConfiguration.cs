using Crud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Crud.Infra.Data.EntityConfiguration;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.Property(c => c.Nome).HasMaxLength(100).IsRequired();

        builder.HasData(
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
        );
    }
}