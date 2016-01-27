namespace Stats.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCreatedDateDatabaseGenerated : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.GameEvents", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Games", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Teams", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Players", "CreatedDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Teams", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Games", "CreatedDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.GameEvents", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
