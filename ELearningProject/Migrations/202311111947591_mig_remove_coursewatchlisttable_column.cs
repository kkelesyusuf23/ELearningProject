namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_remove_coursewatchlisttable_column : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.CourseWatchLists", "LessonNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.CourseWatchLists", "LessonNumber", c => c.Int(nullable: false));
        }
    }
}
