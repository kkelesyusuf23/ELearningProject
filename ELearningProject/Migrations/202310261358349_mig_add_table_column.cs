namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_table_column : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Instructors", "ImageURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Instructors", "ImageURL");
        }
    }
}
