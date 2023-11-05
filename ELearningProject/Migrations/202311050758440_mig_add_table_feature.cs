namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_table_feature : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Features",
                c => new
                    {
                        FeatureID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        SubTitle = c.String(),
                        ShortDescription = c.String(),
                        LongDescription = c.String(),
                    })
                .PrimaryKey(t => t.FeatureID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Features");
        }
    }
}
