# Aplicação CRUD com Clean Architecture em .NET 8

Este projeto é uma aplicação CRUD construída usando os princípios da Clean Architecture, .NET 8 e o padrão CQRS. Utiliza o Entity Framework Core com SQL Server para persistência de dados.

## Funcionalidades

- Clean Architecture
- Padrão CQRS
- Entity Framework Core
- SQL Server

## Começando

### Pré-requisitos

- SDK do .NET 8
- SQL Server

### Instalação

1. Clone o repositório:
    ```bash
    git clone https://github.com/seuusuario/seu-repo.git
    cd seu-repo
    ```

2. Configure a string de conexão no `appsettings.json`:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=nome_do_servidor;Database=nome_do_banco;User Id=seu_usuario;Password=sua_senha;"
      }
    }
    ```

3. Aplique as migrações e atualize o banco de dados:
    ```bash
    dotnet ef database update
    ```

4. Execute a aplicação:
    ```bash
    dotnet run
    ```

## Uso

Uma vez que a aplicação esteja em execução, você pode realizar operações CRUD através dos endpoints da API fornecidos.
