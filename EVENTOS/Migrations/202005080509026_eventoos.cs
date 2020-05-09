namespace EVENTOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class eventoos : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventoes", "Descripción", c => c.String());
            DropColumn("dbo.Eventoes", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eventoes", "Description", c => c.String());
            DropColumn("dbo.Eventoes", "Descripción");
        }
    }
}
