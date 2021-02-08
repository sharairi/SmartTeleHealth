namespace SmartTeleHealth.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_appointment_table_add_start_time : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "Start", c => c.DateTime());
            AddColumn("dbo.Appointments", "End", c => c.DateTime());
            AddColumn("dbo.Appointments", "ThemeColor", c => c.String());
            AddColumn("dbo.Appointments", "IsFullDay", c => c.Boolean());

        }

        public override void Down()
        {
            DropColumn("dbo.Appointments", "Start");
            DropColumn("dbo.Appointments", "End");
            DropColumn("dbo.Appointments", "ThemeColor");
            DropColumn("dbo.Appointments", "IsFullDay");

        }
    }
}
