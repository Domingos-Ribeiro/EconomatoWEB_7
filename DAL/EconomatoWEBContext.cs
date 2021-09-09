using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EconomatoWEB.Models;
using System.Data.Entity;

namespace EconomatoWEB.DAL
{
    public class EconomatoWEBContext : DbContext
    {
        //Preparação para a criação das tabelas através do EntityFrameWork
        public DbSet<Entidade> Entidades { get; set; }

        public DbSet<Movimento> Movimentos { get; set; }

        public DbSet<TipoDeArtigo> TipoDeArtigos { get; set; }

        public DbSet<Artigo> Artigos { get; set; }
    }
}