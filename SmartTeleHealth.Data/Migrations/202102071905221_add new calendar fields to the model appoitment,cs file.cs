namespace SmartTeleHealth.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addnewcalendarfieldstothemodelappoitmentcsfile : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Start", c => c.DateTime(nullable: false));
            AddColumn("dbo.Appointments", "End", c => c.DateTime());
            AddColumn("dbo.Appointments", "ThemeColor", c => c.String());
            AddColumn("dbo.Appointments", "IsFullDay", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "IsFullDay");
            DropColumn("dbo.Appointments", "ThemeColor");
            DropColumn("dbo.Appointments", "End");
            DropColumn("dbo.Appointments", "Start");
        }
    }
}
