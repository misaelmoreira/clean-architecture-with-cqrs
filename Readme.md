# Aplica��o CRUD com Clean Architecture em .NET 8

Este projeto � uma aplica��o CRUD constru�da usando os princ�pios da Clean Architecture, .NET 8 e o padr�o CQRS. Utiliza o Entity Framework Core com SQL Server para persist�ncia de dados.

## Funcionalidades

- Clean Architecture
- Padr�o CQRS
- Entity Framework Core
- SQL Server

## Come�ando

### Pr�-requisitos

- SDK do .NET 8
- SQL Server

### Instala��o

1. Clone o reposit�rio:
    ```bash
    git clone https://github.com/seuusuario/seu-repo.git
    cd seu-repo
    ```

2. Configure a string de conex�o no `appsettings.json`:
    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=nome_do_servidor;Database=nome_do_banco;User Id=seu_usuario;Password=sua_senha;"
      }
    }
    ```

3. Aplique as migra��es e atualize o banco de dados:
    ```bash
    dotnet ef database update
    ```

4. Execute a aplica��o:
    ```bash
    dotnet run
    ```

## Uso

Uma vez que a aplica��o esteja em execu��o, voc� pode realizar opera��es CRUD atrav�s dos endpoints da API fornecidos.
