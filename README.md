# Sistema de Agendamento de Barbearia

## Descrição

O Sistema de Agendamento de Barbearia é uma aplicação web desenvolvida em ASP.NET Core 7 MVC que permite gerenciar os agendamentos de uma barbearia. A aplicação utiliza o Entity Framework para interagir com o banco de dados.

## Pré-requisitos

Certifique-se de ter os seguintes pré-requisitos instalados:

- [ASP.NET Core 7](https://dotnet.microsoft.com/download/dotnet/7.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/pt-br/visual-cpp-build-tools/)
- [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)

## Configuração do Banco de Dados

1. Abra o Visual Studio e acesse a janela do Gerenciador de Pacotes do NuGet.

2. Execute o seguinte comando para criar o banco de dados:

    bash
    Update-Database
    

3. Certifique-se de ajustar a string de conexão no arquivo `appsettings.json` para refletir as configurações do seu ambiente.

    json
    "ConnectionStrings": {
        "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SuaBaseDeDados;Trusted_Connection=True;MultipleActiveResultSets=true"
    },
    

## Instalação e Execução

1. Clone o repositório:

    bash
    git clone https://github.com/CerqueiraGustavo/GestaoBarbearia.git
    

2. Abra o projeto no Visual Studio.

3. Execute a aplicação pressionando `F5` ou usando o comando:

    bash
    dotnet run

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
