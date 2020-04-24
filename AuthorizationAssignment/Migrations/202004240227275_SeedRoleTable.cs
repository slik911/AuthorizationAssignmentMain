namespace AuthorizationAssignment.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedRoleTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Roles(Name) VALUES ('Admin')");
            Sql("INSERT INTO Roles(Name) VALUES ('Teacher')");
            Sql("INSERT INTO Roles(Name) VALUES ('Student')");
        }
        
        public override void Down()
        {
        }
    }
}
