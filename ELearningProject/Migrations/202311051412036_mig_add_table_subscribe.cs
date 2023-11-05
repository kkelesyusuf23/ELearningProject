namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_table_subscribe : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subscribes",
                c => new
                    {
                        SubscribeID = c.Int(nullable: false, identity: true),
                        Mail = c.String(),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.SubscribeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subscribes");
        }
    }
}
