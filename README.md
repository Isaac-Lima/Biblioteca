# 📚 Web API - Biblioteca

Esta é uma Web API desenvolvida em C# com ASP.NET Core e Entity Framework Core. A API permite gerenciar livros e autores, oferecendo funcionalidades completas de CRUD (Create, Read, Update, Delete).

## 🚀 Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server
- Swagger

## 📦 Funcionalidades

- Criar, listar, atualizar e excluir para **Livros**
- Criar, listar, atualizar e excluir para **Autores**
- Obter livro por ID
- Obter livro por ID do autor
- Obter autor por ID
- Obter autor por ID do livro
- Listagem de todos os livros
- Listagem de todos os autores

## 📁 Endpoints

### 📚 Livros

| Método | Endpoint                                  | Descrição                         |
|--------|-------------------------------------------|-----------------------------------|
| GET    | `/api/ListarLivros`                       | Retorna todos os livros           |
| GET    | `/api/BuscarLivroPorId/{idLivro}`         | Retorna um livro por ID           |
| GET    | `/api/BuscarLivroPorAutorId/{idAutor}`    | Retorna livros de um autor        |
| POST   | `/api/CriarLivro`                         | Cria um novo livro                |
| PUT    | `/api/EditarLivro/{idLivro}`              | Atualiza um livro existente       |
| DELETE | `/api/ExcluirLivro/{idLivro}`             | Remove um livro                   |

### ✍️ Autores

| Método | Endpoint                                      | Descrição                            |
|--------|-----------------------------------------------|----------------------------------------|
| GET    | `/api/ListarAutores`                          | Retorna todos os autores               |
| GET    | `/api/BuscarAutorPorId/{idAutor}`             | Retorna um autor por ID                |
| GET    | `/api/BuscarAutorPorIdLivro/{idLivro}`        | Retorna o autor de um livro            |
| POST   | `/api/CriarAutor`                             | Cria um novo autor                     |
| PUT    | `/api/EditarAutor/{idAutor}`                  | Atualiza um autor existente            |
| DELETE | `/api/ExcluirAutor/{idAutor}`                 | Remove um autor                        |


## ▶️ Como Executar a Aplicação

Siga os passos abaixo para configurar e executar a API localmente.

### 1. Pré-requisitos

* [.NET 8 SDK ou superior](https://dotnet.microsoft.com/download)
* [SQL Server](https://www.microsoft.com/pt-br/sql-server/sql-server-downloads)
* [Visual Studio 2022](https://visualstudio.microsoft.com/) ou [Visual Studio Code](https://code.visualstudio.com/)
* Ferramenta de chamadas HTTP (Postman, Insomnia, ou Swagger)

### 2. Clonar o Repositório

```bash
git clone https://github.com/Isaac-Lima/Locadora.git
cd Locadora
```

### 3. Configurar a Connection String

No arquivo `appsettings.json`, configure a conexão com o banco de dados. Exemplo:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=Locadora;Trusted_Connection=True;"
}
```

> 💡 Você pode usar  outro servidor SQL de sua preferência. Acesse [ConnectionStrings](https://www.connectionstrings.com/) para obter a conexão do banco de dados escolhido. 

### 4. Instale os pacotes necessários

```bash
dotnet restore
```

### 5. Crie o banco de dados com migrations

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 6. Execute o projeto

```bash
dotnet run



