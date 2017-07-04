namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rep : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "DOB", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Patients", "DOD", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "DOD", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Patients", "DOB", c => c.DateTime(nullable: false));
        }
    }
}
