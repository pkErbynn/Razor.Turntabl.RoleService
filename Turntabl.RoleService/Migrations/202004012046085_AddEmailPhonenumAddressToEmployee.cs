namespace Turntabl.RoleService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddEmailPhonenumAddressToEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Email", c => c.String());
            AddColumn("dbo.Employees", "PhoneNumber", c => c.String());
            AddColumn("dbo.Employees", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Address");
            DropColumn("dbo.Employees", "PhoneNumber");
            DropColumn("dbo.Employees", "Email");
        }
    }
}
