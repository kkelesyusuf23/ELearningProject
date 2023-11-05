namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_column_in_featuretable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Features", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Features", "ImageURL");
        }
    }
}
