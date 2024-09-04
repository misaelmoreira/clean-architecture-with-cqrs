namespace Crud.Domain.Params;

public class ClienteParams
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Telefone { get; set; }
    public DateTime DataNascimento { get; set; }

    public ClienteParams(string nome, string email, string telefone, DateTime dataNascimento)
    {
        Nome = nome;
        Email = email;
        Telefone = telefone;
        DataNascimento = dataNascimento;
    }
}