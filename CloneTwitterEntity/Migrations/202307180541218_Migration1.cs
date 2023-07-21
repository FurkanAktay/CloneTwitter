namespace CloneTwitterEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.USERs",
                c => new
                    {
                        ID_USER = c.Int(nullable: false, identity: true),
                        NAME = c.String(maxLength: 25),
                        PHONE = c.String(maxLength: 10),
                        EMAIL = c.String(maxLength: 50),
                        USERNAME = c.String(maxLength: 25),
                        PASSWORD = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.ID_USER);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.USERs");
        }
    }
}
