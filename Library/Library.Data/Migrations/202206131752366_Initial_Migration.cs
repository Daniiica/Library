namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "DeleteDateReservation", c => c.DateTime());
            AddColumn("dbo.Reservations", "Realized", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "Realized");
            DropColumn("dbo.Reservations", "DeleteDateReservation");
        }
    }
}
