namespace Crud.Application.UseCases.Shared;

public sealed record CustomerResponse
{
    public Guid Id { get; set; }
    public string? Nome { get; set; }
    public string? Email { get; set; }
}