namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_tables_contact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        ContactInformationID = c.Int(nullable: false, identity: true),
                        InformationTitle = c.String(),
                        InformationIcon = c.String(),
                        Information = c.String(),
                    })
                .PrimaryKey(t => t.ContactInformationID);
            
            CreateTable(
                "dbo.ContactMaps",
                c => new
                    {
                        ContactMapID = c.Int(nullable: false, identity: true),
                        EmbedLink = c.String(),
                    })
                .PrimaryKey(t => t.ContactMapID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactMaps");
            DropTable("dbo.ContactInformations");
        }
    }
}
