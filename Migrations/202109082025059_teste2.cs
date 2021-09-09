namespace EconomatoWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Artigoes",
                c => new
                    {
                        IdArtigo = c.Int(nullable: false, identity: true),
                        IdEntidade = c.Int(nullable: false),
                        Nome = c.String(),
                        Preco = c.Double(nullable: false),
                        IdTipoDeArtigos = c.Int(nullable: false),
                        StockMinimo = c.Int(nullable: false),
                        Movimento_IdMovimentos = c.Int(),
                    })
                .PrimaryKey(t => t.IdArtigo)
                .ForeignKey("dbo.Movimentoes", t => t.Movimento_IdMovimentos)
                .ForeignKey("dbo.TipoDeArtigoes", t => t.IdTipoDeArtigos, cascadeDelete: true)
                .Index(t => t.IdTipoDeArtigos)
                .Index(t => t.Movimento_IdMovimentos);
            
            CreateTable(
                "dbo.Movimentoes",
                c => new
                    {
                        IdMovimentos = c.Int(nullable: false, identity: true),
                        IdArtigo = c.Int(nullable: false),
                        IdEntidade = c.Int(nullable: false),
                        NumDoc = c.String(),
                        Quantidade = c.Int(nullable: false),
                        TipoMovimento = c.String(),
                        Artigo_IdArtigo = c.Int(),
                        Artigo_IdArtigo1 = c.Int(),
                    })
                .PrimaryKey(t => t.IdMovimentos)
                .ForeignKey("dbo.Artigoes", t => t.Artigo_IdArtigo)
                .ForeignKey("dbo.Entidades", t => t.IdEntidade, cascadeDelete: true)
                .ForeignKey("dbo.Artigoes", t => t.Artigo_IdArtigo1)
                .Index(t => t.IdEntidade)
                .Index(t => t.Artigo_IdArtigo)
                .Index(t => t.Artigo_IdArtigo1);
            
            CreateTable(
                "dbo.Entidades",
                c => new
                    {
                        IdEntidade = c.Int(nullable: false, identity: true),
                        Designacao = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdEntidade);
            
            CreateTable(
                "dbo.TipoDeArtigoes",
                c => new
                    {
                        IdTipoDeArtigos = c.Int(nullable: false, identity: true),
                        Nome = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdTipoDeArtigos);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Artigoes", "IdTipoDeArtigos", "dbo.TipoDeArtigoes");
            DropForeignKey("dbo.Movimentoes", "Artigo_IdArtigo1", "dbo.Artigoes");
            DropForeignKey("dbo.Artigoes", "Movimento_IdMovimentos", "dbo.Movimentoes");
            DropForeignKey("dbo.Movimentoes", "IdEntidade", "dbo.Entidades");
            DropForeignKey("dbo.Movimentoes", "Artigo_IdArtigo", "dbo.Artigoes");
            DropIndex("dbo.Movimentoes", new[] { "Artigo_IdArtigo1" });
            DropIndex("dbo.Movimentoes", new[] { "Artigo_IdArtigo" });
            DropIndex("dbo.Movimentoes", new[] { "IdEntidade" });
            DropIndex("dbo.Artigoes", new[] { "Movimento_IdMovimentos" });
            DropIndex("dbo.Artigoes", new[] { "IdTipoDeArtigos" });
            DropTable("dbo.TipoDeArtigoes");
            DropTable("dbo.Entidades");
            DropTable("dbo.Movimentoes");
            DropTable("dbo.Artigoes");
        }
    }
}
