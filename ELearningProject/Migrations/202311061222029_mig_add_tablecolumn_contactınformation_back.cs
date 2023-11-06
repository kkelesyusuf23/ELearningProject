namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_tablecolumn_contactınformation_back : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.ContactInformations", "AddressTitle");
            DropColumn("dbo.ContactInformations", "AddressIcon");
            DropColumn("dbo.ContactInformations", "PhoneIcon");
            DropColumn("dbo.ContactInformations", "PhoneTitle");
            DropColumn("dbo.ContactInformations", "MailIcon");
            DropColumn("dbo.ContactInformations", "MailTitle");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ContactInformations", "MailTitle", c => c.String());
            AddColumn("dbo.ContactInformations", "MailIcon", c => c.String());
            AddColumn("dbo.ContactInformations", "PhoneTitle", c => c.String());
            AddColumn("dbo.ContactInformations", "PhoneIcon", c => c.String());
            AddColumn("dbo.ContactInformations", "AddressIcon", c => c.String());
            AddColumn("dbo.ContactInformations", "AddressTitle", c => c.String());
        }
    }
}
