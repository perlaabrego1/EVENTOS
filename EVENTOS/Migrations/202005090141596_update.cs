namespace EVENTOS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Eventoes", "Status", c => c.String());
            DropColumn("dbo.Eventoes", "Tipo");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Eventoes", "Tipo", c => c.String());
            DropColumn("dbo.Eventoes", "Status");
        }
    }
}
