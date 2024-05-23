namespace COVID_19Monitoring.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Barangays",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        BrgyName = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        MiddleName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Age = c.Int(nullable: false),
                        Gender = c.String(maxLength: 50),
                        CivilStatus = c.String(),
                        Nationality = c.String(maxLength: 50),
                        HouseNo = c.String(maxLength: 50),
                        Street = c.String(maxLength: 100),
                        Mobile = c.String(maxLength: 11),
                        BrgyID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Barangays", t => t.BrgyID, cascadeDelete: true)
                .Index(t => t.BrgyID);
            
            CreateTable(
                "dbo.PUIs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        DateArrived = c.DateTime(nullable: false),
                        Time = c.String(maxLength: 15),
                        Bus = c.String(maxLength: 20),
                        Symptoms = c.String(),
                        Onset = c.DateTime(nullable: false),
                        Status = c.String(maxLength: 50),
                        StatusUpdateDate = c.DateTime(),
                        PlaceOfOrigin = c.String(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.PUMs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PersonID = c.Int(nullable: false),
                        DateArrived = c.DateTime(nullable: false),
                        Time = c.String(maxLength: 15),
                        Bus = c.String(maxLength: 20),
                        Status = c.String(maxLength: 50),
                        StatusUpdateDate = c.DateTime(),
                        PlaceOfOrigin = c.String(maxLength: 15),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.PersonID, cascadeDelete: true)
                .Index(t => t.PersonID);
            
            CreateTable(
                "dbo.Places",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        PlaceOfOrigin = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Symptoms",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Indication = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PUMs", "PersonID", "dbo.People");
            DropForeignKey("dbo.PUIs", "PersonID", "dbo.People");
            DropForeignKey("dbo.People", "BrgyID", "dbo.Barangays");
            DropIndex("dbo.PUMs", new[] { "PersonID" });
            DropIndex("dbo.PUIs", new[] { "PersonID" });
            DropIndex("dbo.People", new[] { "BrgyID" });
            DropTable("dbo.Symptoms");
            DropTable("dbo.Places");
            DropTable("dbo.PUMs");
            DropTable("dbo.PUIs");
            DropTable("dbo.People");
            DropTable("dbo.Barangays");
        }
    }
}
