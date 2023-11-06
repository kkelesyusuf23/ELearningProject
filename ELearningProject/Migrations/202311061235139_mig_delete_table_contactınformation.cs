namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_delete_table_contactınformation : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.ContactInformations");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        ContactInformationID = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                        Phone = c.String(),
                        Mail = c.String(),
                        MapAddress = c.String(),
                    })
                .PrimaryKey(t => t.ContactInformationID);
            
        }
    }
}
