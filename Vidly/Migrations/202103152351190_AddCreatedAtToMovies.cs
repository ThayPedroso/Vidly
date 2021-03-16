namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCreatedAtToMovies : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "CreatedAt", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Movies", "CreatedAt");
        }
    }
}
