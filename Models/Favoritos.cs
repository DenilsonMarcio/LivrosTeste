using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LivrosTeste.Models
{
    public class Favoritos
    {
        public int Id { get; set; }

        [Display(Name = "Gênero")]
        public string Genero { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Autor(a) / Autores(as)")]
        public string Autor { get; set; }

        [Display(Name = "Número de Páginas")]
        public int Paginas { get; set; }

        [Display(Name = "Ilustração")]
        public bool Ilustracao { get; set; }
        
        [Display(Name = "Series e Franquias")]
        public string SerieDescricao { get; set; }

        

    }
}
