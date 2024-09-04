namespace Crud.Domain.Entities;

public sealed class Customer : BaseEntity
{
    public string Nome { get; set;}
    public string Email { get; set;}
    public string Telefone { get; set;}
    public DateTime DataNascimento { get; set;}

    public Customer() { }
}