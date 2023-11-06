namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_tablecolumn_contactınformation_backk : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ContactInformations", "Title");
            DropColumn("dbo.ContactInformations", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactInformations", "Description", c => c.String());
            AddColumn("dbo.ContactInformations", "Title", c => c.String());
        }
    }
}
