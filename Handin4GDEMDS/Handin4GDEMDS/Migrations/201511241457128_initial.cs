namespace Handin4GDEMDS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            /*CreateTable(
                "dbo.AppartmentcharacteristicSet",
                c => new
                    {
                        appartmentId = c.Int(nullable: false, identity: true),
                        No = c.Int(nullable: false),
                        Size = c.Double(nullable: false),
                        Floor = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.appartmentId);
            
            CreateTable(
                "dbo.ReadingSet",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        value = c.Double(nullable: false),
                        timestamp = c.DateTime(nullable: false),
                        SensorID = c.Int(nullable: false),
                        appartmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.SensorcharacteristicSet", t => t.SensorID)
                .ForeignKey("dbo.AppartmentcharacteristicSet", t => t.appartmentId)
                .Index(t => t.SensorID)
                .Index(t => t.appartmentId);
            
            CreateTable(
                "dbo.SensorcharacteristicSet",
                c => new
                    {
                        SensorID = c.Int(nullable: false, identity: true),
                        calibrationDate = c.DateTime(nullable: false),
                        description = c.String(nullable: false),
                        externalRef = c.String(),
                        calibrationEquation = c.String(),
                        calibrationCoeff = c.String(),
                        unit = c.String(),
                        Appartmentcharacteristic_appartmentId = c.Int(),
                    })
                .PrimaryKey(t => t.SensorID)
                .ForeignKey("dbo.AppartmentcharacteristicSet", t => t.Appartmentcharacteristic_appartmentId)
                .Index(t => t.Appartmentcharacteristic_appartmentId);*/
            
        }
        
        public override void Down()
        {
/*            DropForeignKey("dbo.SensorcharacteristicSet", "Appartmentcharacteristic_appartmentId", "dbo.AppartmentcharacteristicSet");
            DropForeignKey("dbo.ReadingSet", "appartmentId", "dbo.AppartmentcharacteristicSet");
            DropForeignKey("dbo.ReadingSet", "SensorID", "dbo.SensorcharacteristicSet");
            DropIndex("dbo.SensorcharacteristicSet", new[] { "Appartmentcharacteristic_appartmentId" });
            DropIndex("dbo.ReadingSet", new[] { "appartmentId" });
            DropIndex("dbo.ReadingSet", new[] { "SensorID" });
            DropTable("dbo.SensorcharacteristicSet");
            DropTable("dbo.ReadingSet");
            DropTable("dbo.AppartmentcharacteristicSet");*/
        }
    }
}
