namespace lab04.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FriendModels",
                c => new
                    {
                        FriendModelId = c.Int(nullable: false, identity: true),
                        FriendIdentification = c.Int(nullable: false),
                        Ime = c.String(nullable: false),
                        MestoZiveenje = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.FriendModelId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.FriendModels");
        }
    }
}
