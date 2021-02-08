namespace SmartTeleHealth.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class change_appointment_table : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "AppointmentDesc", c => c.String());


        }

        public override void Down()
        {
            DropColumn("dbo.Appointments", "AppointmentDesc");
            DropColumn("dbo.Appointments", "VisitingTime");

        }
    }
}
