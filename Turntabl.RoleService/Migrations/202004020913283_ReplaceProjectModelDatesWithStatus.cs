namespace Turntabl.RoleService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ReplaceProjectModelDatesWithStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Projects", "Status", c => c.String());
            DropColumn("dbo.Projects", "StartDate");
            DropColumn("dbo.Projects", "EndDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Projects", "EndDate", c => c.String());
            AddColumn("dbo.Projects", "StartDate", c => c.String());
            DropColumn("dbo.Projects", "Status");
        }
    }
}
