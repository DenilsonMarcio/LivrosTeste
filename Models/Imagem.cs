using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrosTeste.Models
{
    public class Imagem
    {

        public int Id { get; set; }

        public string NomeImagem { get; set; }
        public string ImagemCapa { get; set; }

        public List<Livro> Livros { get; set; }

    }
}
