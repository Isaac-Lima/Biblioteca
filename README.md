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

