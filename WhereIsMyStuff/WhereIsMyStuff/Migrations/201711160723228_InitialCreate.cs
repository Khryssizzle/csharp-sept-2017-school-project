namespace WhereIsMyStuff.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Entries",
                c => new
                    {
                        Entry_Id = c.Int(nullable: false, identity: true),
                        DateBorrowed = c.DateTime(nullable: false),
                        Item = c.String(nullable: false, maxLength: 100),
                        ItemType = c.String(),
                        ItemCondition = c.String(),
                        Notes = c.String(),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Entry_Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Entries");
        }
    }
}
