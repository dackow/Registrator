namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registration3 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Schedules", "Doctor_Id", "dbo.Doctors");
            DropForeignKey("dbo.WorkDays", "Schedule_Id", "dbo.Schedules");
            DropIndex("dbo.Schedules", new[] { "Doctor_Id" });
            DropIndex("dbo.WorkDays", new[] { "Schedule_Id" });
            AddColumn("dbo.WorkDays", "Doctor_Id", c => c.Int(nullable: false));
            CreateIndex("dbo.WorkDays", "Doctor_Id");
            AddForeignKey("dbo.WorkDays", "Doctor_Id", "dbo.Doctors", "Id", cascadeDelete: true);
            DropColumn("dbo.WorkDays", "Schedule_Id");
            DropTable("dbo.Schedules");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Schedules",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Doctor_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.WorkDays", "Schedule_Id", c => c.Int());
            DropForeignKey("dbo.WorkDays", "Doctor_Id", "dbo.Doctors");
            DropIndex("dbo.WorkDays", new[] { "Doctor_Id" });
            DropColumn("dbo.WorkDays", "Doctor_Id");
            CreateIndex("dbo.WorkDays", "Schedule_Id");
            CreateIndex("dbo.Schedules", "Doctor_Id");
            AddForeignKey("dbo.WorkDays", "Schedule_Id", "dbo.Schedules", "Id");
            AddForeignKey("dbo.Schedules", "Doctor_Id", "dbo.Doctors", "Id", cascadeDelete: true);
        }
    }
}
