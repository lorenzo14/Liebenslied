namespace pryecto.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        idCancion = c.Int(nullable: false, identity: true),
                        Author = c.String(nullable: false, maxLength: 50),
                        Name = c.String(nullable: false),
                        Genre = c.String(),
                        Duration = c.Int(nullable: false),
                        PublisherId = c.Int(nullable: false),
                        User_Nif = c.Int(),
                    })
                .PrimaryKey(t => t.idCancion)
                .ForeignKey("dbo.Users", t => t.User_Nif)
                .Index(t => t.User_Nif);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Nif = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 20),
                        DischargeDate = c.DateTime(nullable: false),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Nif);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Songs", "User_Nif", "dbo.Users");
            DropIndex("dbo.Songs", new[] { "User_Nif" });
            DropTable("dbo.Users");
            DropTable("dbo.Songs");
        }
    }
}
