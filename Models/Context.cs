using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LivrosTeste.Models;

namespace LivrosTeste.Models
{
    public class Context : DbContext
    {
        public DbSet<Serie> Series { get; set; }
        public DbSet <Livro> Livros { get; set; }
        public DbSet <Favoritos> Favoritos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;");
                                        // Inserir aqui a string de conexão do banco
        }

    }
}
