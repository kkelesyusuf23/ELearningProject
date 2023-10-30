namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_relation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "CategoryID", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "CategoryID");
            AddForeignKey("dbo.Courses", "CategoryID", "dbo.Categories", "CategoryID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Courses", new[] { "CategoryID" });
            DropColumn("dbo.Courses", "CategoryID");
        }
    }
}
