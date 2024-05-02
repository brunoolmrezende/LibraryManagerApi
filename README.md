# LibraryManagerApi

## Descrição

Este projeto é uma API para uma Livraria Online, desenvolvida como parte de um exercício inicial para testar conhecimentos sobre APIs e endpoints. A API permite criar, visualizar, editar e excluir livros de uma lista estática.

## Objetivo

O objetivo principal deste projeto é implementar e testar os conceitos básicos de desenvolvimento de APIs usando ASP.NET Core. A lista de livros é estática e serve como um conjunto de dados simples para validar o funcionamento dos endpoints conforme as regras de negócio.

## Funcionalidades

Um livro é representado pelos seguintes campos:

- ID único para identificação do livro.
- Título.
- Autor.
- Gênero (por exemplo, ficção, romance, mistério).
- Preço.
- Quantidade em estoque.

### Endpoints disponíveis:

- **Criar um Livro**: Permite adicionar um novo livro à lista.
- **Listar todos os Livros**: Retorna a lista de todos os livros disponíveis.
- **Editar um Livro**: Permite atualizar as informações de um livro existente.
- **Excluir um Livro**: Permite remover um livro da lista.

## Observações

Este projeto não utiliza um banco de dados real e a lista de livros é estática. O objetivo é demonstrar o funcionamento dos endpoints sem a complexidade de integração com um banco de dados ou outras camadas de aplicação.

