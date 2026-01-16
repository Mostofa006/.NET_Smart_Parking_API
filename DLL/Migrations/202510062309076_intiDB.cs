namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class intiDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ParkingSlots",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Location = c.String(nullable: false, maxLength: 100),
                        SlotNumber = c.String(nullable: false, maxLength: 10),
                        Status = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        SlotId = c.Int(nullable: false),
                        StartTime = c.DateTime(nullable: false),
                        EndTime = c.DateTime(nullable: false),
                        Status = c.String(nullable: false, maxLength: 20),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ParkingSlots", t => t.SlotId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.SlotId);
            
            CreateTable(
                "dbo.Payments",
                c => new
                    {
                        ReservationId = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PaymentStatus = c.String(nullable: false, maxLength: 20),
                        Method = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.ReservationId)
                .ForeignKey("dbo.Reservations", t => t.ReservationId)
                .Index(t => t.ReservationId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Reservations", "UserId", "dbo.Users");
            DropForeignKey("dbo.Payments", "ReservationId", "dbo.Reservations");
            DropForeignKey("dbo.Reservations", "SlotId", "dbo.ParkingSlots");
            DropIndex("dbo.Payments", new[] { "ReservationId" });
            DropIndex("dbo.Reservations", new[] { "SlotId" });
            DropIndex("dbo.Reservations", new[] { "UserId" });
            DropTable("dbo.Payments");
            DropTable("dbo.Reservations");
            DropTable("dbo.ParkingSlots");
        }
    }
}
