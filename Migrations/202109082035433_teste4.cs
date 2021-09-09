namespace EconomatoWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.TipoDeArtigoes", "Nome", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.TipoDeArtigoes", "Nome", c => c.Int(nullable: false));
        }
    }
}
