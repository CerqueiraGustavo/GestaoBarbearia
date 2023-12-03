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
    git clone https://github.com/seu-usuario/sistema-agendamento-barbearia.git
    

2. Abra o projeto no Visual Studio.

3. Execute a aplicação pressionando `F5` ou usando o comando:

    bash
    dotnet run
    

4. Abra o navegador e acesse `http://localhost:5000`.

## Contribuição

Contribuições são bem-vindas! Se você quiser contribuir para o projeto, siga os passos abaixo:

1. Faça o fork do projeto.
2. Crie uma branch para a sua feature (`git checkout -b feature/nova-feature`).
3. Faça commit das suas mudanças (`git commit -am 'Adicione nova feature'`).
4. Faça o push para a branch (`git push origin feature/nova-feature`).
5. Abra um Pull Request.

## Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
