using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EconomatoWEB.Models
{
    public class Movimento
    {
        [Key()]
        public int IdMovimentos { get; set; }

        public int IdArtigo { get; set; }
        public virtual Artigo Artigo { get; set; }


        [ForeignKey("Entidade")]
        public int IdEntidade { get; set; }
        public virtual Entidade Entidade { get; set; }


        public string NumDoc { get; set; }

        public int Quantidade { get; set; }

        public string TipoMovimento { get; set; }

        

       
    }
}