using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EconomatoWEB.Models
{
    public class TipoDeArtigo
    {
        [Key()]
        public int IdTipoDeArtigos { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Artigo> Artigos { get; set; }
    }
}