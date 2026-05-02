
# Folio

![Status Em Construção](https://img.shields.io/badge/status-em_construção-orange?style=for-the-badge)
![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge&logo=dotnet)
![Blazor](https://img.shields.io/badge/Blazor-SSR-5C2D91?style=for-the-badge&logo=blazor)

O **Folio** é um motor de blog extremamente minimalista desenvolvido em **.NET 8** utilizando Blazor Web App (SSR). 

A ideia principal do projeto é o **atrito zero**: ele não usa nenhum banco de dados tradicional. Todo o conteúdo do blog é lido diretamente de arquivos **Markdown** organizados em pastas (arquitetura *Flat-file*).

## Como funciona?
Em vez de salvar posts no SQL, você escreve em Markdown. A estrutura de pastas dita o conteúdo:
`/Content/nome-do-post/index.md`

O sistema lê essa pasta, converte o texto para HTML e renderiza na tela de forma incrivelmente rápida.

## Tecnologias Base
* **C# / .NET 8** (Blazor SSR)
* **Markdig** (Para converter Markdown em HTML)
* **Pico.css** (Para um design limpo e automático sem precisar escrever CSS)

## Como testar localmente
1. Clone este repositório.
2. Abra no Visual Studio ou VS Code.
3. Rode o comando:
	```bash 
	dotnet run
	```
4. **Área Admin:** Para testar a criação de posts via painel, acesse a rota `/login` no navegador.

-   **Usuário:** admin
    
-   **Senha:** admin
