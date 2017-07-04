namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Doctor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id, cascadeDelete: true)
                .Index(t => t.Doctor_Id);
            
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Type = c.Int(nullable: false),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Email = c.String(),
                        Address1_Street = c.String(),
                        Address1_City = c.String(),
                        Address2_Street = c.String(),
                        Address2_City = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkDays",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        From_hour = c.Int(nullable: false),
                        From_minute = c.Int(nullable: false),
                        To_hour = c.Int(nullable: false),
                        To_minute = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        UnavailabilityReason = c.String(),
                        Schedule_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Schedules", t => t.Schedule_Id)
                .Index(t => t.Schedule_Id);
            
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sex = c.Int(nullable: false),
                        Pesel = c.String(),
                        DOB = c.DateTime(nullable: false),
                        DOD = c.DateTime(nullable: false),
                        FirstName = c.String(nullable: false),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        Phone1 = c.String(),
                        Phone2 = c.String(),
                        Email = c.String(),
                        Address1_Street = c.String(),
                        Address1_City = c.String(),
                        Address2_Street = c.String(),
                        Address2_City = c.String(),
                        Note = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkDays", "Schedule_Id", "dbo.Schedules");
            DropForeignKey("dbo.Schedules", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.WorkDays", new[] { "Schedule_Id" });
            DropIndex("dbo.Schedules", new[] { "Doctor_Id" });
            DropTable("dbo.Patients");
            DropTable("dbo.WorkDays");
            DropTable("dbo.Doctors");
            DropTable("dbo.Schedules");
        }
    }
}
