# Livraria Dev

## Teste realizado utilizando as tecnologias:
  * Visual Studio Community 2019
  * Asp.Net Core 3.1
  * EntityFramework
  * SqlServer Express Edition
  * MVC

## Documentação
 * Clonar o repositório e instalar as dependências.
 * Ter uma versão do Sqlserver instalada (Sql Community).
 * Utilizar o Nugget para configurar as dependências.
 * instalar o EntityFrameworkCore.SqlServer e EntityFrameworkCore.Tools.
     Install-Package Microsoft.EntityFrameworkCore.SqlServer
     Install-Package Microsoft.EntityFrameworkCore.Tools
 * Alterar a String de conexão dentro do arquivo Context na pasta Models.
 * Realizar a migração das classes para crianção do banco de dados utilizando o Migration.
     Add-Migration InitialCreate
 * Criar e sincronizar o banco de dados com o comando Update-Database.
     Update-Database
     Obs: Migration e Update-Database precisam rodar toda vez que fizer alguma mudança na estrutura 
     do banco de dados.

## Requisitos Solicitados e status de realização: 
  * Criar Cadastro de Livros com as informações
  * Possuir uma (Serie / Franquia) ou não no cadastro 
  * Enviar imagem da Capa do livro cadastrado pelo usuário
  * Consultar cadastros
  * Filtros de pesquisa
  * Adicionar aos Favoritos
  
Requisitos                      | Status 
------------------------------- | --------------
Cadastro de Livros              | REALIZADO
Possuir uma (Serie / Franquia)  | REALIZADO
Enviar imagem da Capa           | NÃO REALIZADO
Consultar cadastros             | REALIZADO
Filtros de pesquisa             | NÃO REALIZADO  
Adicionar aos Favoritos         | REALIZADO



