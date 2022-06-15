namespace Library.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial_Migration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Authors", "DateOfDeath", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Authors", "DateOfDeath", c => c.DateTime(nullable: false));
        }
    }
}
