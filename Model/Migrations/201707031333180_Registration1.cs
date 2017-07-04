namespace Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Registration1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Patients", "DOB", c => c.DateTime());
            AlterColumn("dbo.Patients", "DOD", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Patients", "DOD", c => c.DateTime(precision: 7, storeType: "datetime2"));
            AlterColumn("dbo.Patients", "DOB", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
