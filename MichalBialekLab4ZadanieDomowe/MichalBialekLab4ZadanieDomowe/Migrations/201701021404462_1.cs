namespace MichalBialekLab4ZadanieDomowe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pesel = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 450),
                        Password = c.String(nullable: false),
                        DrivingLicense = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Login, unique: true);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Vin = c.String(nullable: false),
                        Brand = c.String(nullable: false),
                        Model = c.String(nullable: false),
                        Fuel = c.String(nullable: false),
                        Year = c.Int(nullable: false),
                        Description = c.String(nullable: false),
                        available = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        RentId = c.Int(nullable: false, identity: true),
                        Expense = c.Single(nullable: false),
                        DateOfHire = c.DateTime(nullable: false),
                        DateOfEnd = c.DateTime(),
                        Car_id = c.Int(),
                        User_Id = c.Int(),
                    })
                .PrimaryKey(t => t.RentId)
                .ForeignKey("dbo.Cars", t => t.Car_id)
                .ForeignKey("dbo.Users", t => t.User_Id)
                .Index(t => t.Car_id)
                .Index(t => t.User_Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Pesel = c.Int(nullable: false),
                        Login = c.String(nullable: false, maxLength: 450),
                        Password = c.String(nullable: false),
                        DrivingLicense = c.Int(nullable: false),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Adress = c.String(nullable: false),
                        Email = c.String(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Login, unique: true);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rents", "User_Id", "dbo.Users");
            DropForeignKey("dbo.Rents", "Car_id", "dbo.Cars");
            DropIndex("dbo.Users", new[] { "Login" });
            DropIndex("dbo.Rents", new[] { "User_Id" });
            DropIndex("dbo.Rents", new[] { "Car_id" });
            DropIndex("dbo.Administrators", new[] { "Login" });
            DropTable("dbo.Users");
            DropTable("dbo.Rents");
            DropTable("dbo.Cars");
            DropTable("dbo.Administrators");
        }
    }
}
