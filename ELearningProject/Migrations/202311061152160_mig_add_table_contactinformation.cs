namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_table_contactinformation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContactInformations",
                c => new
                    {
                        ContactInformationID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        Description = c.String(),
                        Address = c.String(),
                        Phone = c.String(),
                        Mail = c.String(),
                        MapAddress = c.String(),
                    })
                .PrimaryKey(t => t.ContactInformationID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ContactInformations");
        }
    }
}
