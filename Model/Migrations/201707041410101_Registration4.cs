namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registration4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Enrollments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Room = c.String(nullable: false),
                        Date_from = c.DateTime(nullable: false),
                        Date_to = c.DateTime(nullable: false),
                        Status = c.Int(nullable: false),
                        Note = c.String(),
                        Doctor_Id = c.Int(nullable: false),
                        Patient_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Doctors", t => t.Doctor_Id, cascadeDelete: true)
                .ForeignKey("dbo.Patients", t => t.Patient_Id, cascadeDelete: true)
                .Index(t => t.Doctor_Id)
                .Index(t => t.Patient_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Enrollments", "Patient_Id", "dbo.Patients");
            DropForeignKey("dbo.Enrollments", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.Enrollments", new[] { "Patient_Id" });
            DropIndex("dbo.Enrollments", new[] { "Doctor_Id" });
            DropTable("dbo.Enrollments");
        }
    }
}
