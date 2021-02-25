namespace SmartTeleHealth.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changedatestodatetime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Appointments", "Date", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Schedules", "Dates", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Waitings", "Date", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Waitings", "Date", c => c.String());
            AlterColumn("dbo.Schedules", "Dates", c => c.String());
            AlterColumn("dbo.Appointments", "Date", c => c.String());
        }
    }
}
