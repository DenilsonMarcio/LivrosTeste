using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrosTeste.Models
{
    public class Livro
    {
        public int Id { get; set; }

        [Display(Name = "Gênero")]
        [Required(ErrorMessage ="Este campo é obrigatório")]
        public string Genero { get; set; }

        [Display(Name = "Título")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Titulo { get; set; }

        [Display(Name = "Autor(a) / Autores(as)")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        public string Autor { get; set; }

        [Display(Name = "Número de Páginas")]
        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(0, 1000, ErrorMessage ="Número Máximo de Páginas 1000")]
        public int Paginas { get; set; }

        [Display(Name = "Possui Ilustrações ?")]
        public bool Ilustracao { get; set; }
                
        [Display(Name = "Series ou Franquias")]
        public int SerieId { get; set; }

        [Display(Name = "Series ou Franquias")]
        public Serie Serie { get; set; }

        

    }
}
