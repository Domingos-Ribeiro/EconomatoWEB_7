using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EconomatoWEB.Models
{
    public class Entidade
    {
        [Key()]
        public int IdEntidade { get; set; }

        [Display(Name = "Designação")]
        public string Designacao { get; set; }

        public virtual ICollection<Movimento> Movimentos { get; set; }
    }
}