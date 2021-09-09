namespace EconomatoWEB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Entidades", "Designacao", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Entidades", "Designacao", c => c.Int(nullable: false));
        }
    }
}
