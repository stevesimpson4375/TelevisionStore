namespace TelevisionStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Sales", "ItemListId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Sales", "ItemListId", c => c.Int(nullable: false));
        }
    }
}
