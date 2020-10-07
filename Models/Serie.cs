using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrosTeste.Models
{
    public class Serie
    {
        public int Id { get; set; }

        [Display(Name = "Série ou Franquia")]
        public string Descricao { get; set; }

        public List<Livro> Livros { get; set; }
    }
}
