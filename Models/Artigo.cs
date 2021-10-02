using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EconomatoWEB.Models
{
    public class Artigo
    {
        [Key()]
        public int IdArtigo { get; set; }

        [Display(Name = "Forneçedor")]
        public int IdEntidade { get; set; }

        [Display(Name = "Nome do Artigo")]
        public string Nome { get; set; }

        [Display(Name = "Preço")]
        public double Preco { get; set; }


        //[ForeignKey("TipoDeArtigo"), Display(Name = "Família")]
        [ForeignKey("TipoDeArtigo")]
        public int IdTipoDeArtigos { get; set; }

        public virtual TipoDeArtigo TipoDeArtigo { get; set; }


        [Display(Name ="Stock Minimo")]
        public int StockMinimo { get; set; }

        public virtual ICollection<Movimento> Movimentos { get; set; }

        public virtual Movimento Movimento { get; set; }

        
    }
}