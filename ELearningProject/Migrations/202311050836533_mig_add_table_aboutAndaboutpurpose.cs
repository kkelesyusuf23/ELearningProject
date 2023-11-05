namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_table_aboutAndaboutpurpose : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AboutPurposes",
                c => new
                    {
                        AboutPurposeID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                    })
                .PrimaryKey(t => t.AboutPurposeID);
            
            CreateTable(
                "dbo.Abouts",
                c => new
                    {
                        AboutID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description1 = c.String(),
                        Description2 = c.String(),
                    })
                .PrimaryKey(t => t.AboutID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Abouts");
            DropTable("dbo.AboutPurposes");
        }
    }
}
