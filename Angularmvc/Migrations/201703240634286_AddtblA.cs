namespace Angularmvc.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddtblA : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String(nullable: false));
            DropColumn("dbo.tblAs", "Datetime");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tblAs", "Datetime", c => c.String());
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String());
        }
    }
}
