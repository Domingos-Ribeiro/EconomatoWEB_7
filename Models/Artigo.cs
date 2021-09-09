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

        public int IdEntidade { get; set; }

        public string Nome { get; set; }

        public double Preco { get; set; }


        [ForeignKey("TipoDeArtigo")]
        public int IdTipoDeArtigos { get; set; }
        public virtual TipoDeArtigo TipoDeArtigo { get; set; }



        public int StockMinimo { get; set; }

        public virtual ICollection<Movimento> Movimentos { get; set; }

        public virtual Movimento Movimento { get; set; }

        
    }
}