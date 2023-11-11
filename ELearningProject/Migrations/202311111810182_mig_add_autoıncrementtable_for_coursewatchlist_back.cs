namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_autoıncrementtable_for_coursewatchlist_back : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.CourseWatchLists");
            AlterColumn("dbo.CourseWatchLists", "CourseWatchListID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CourseWatchLists", "LessonNumber", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.CourseWatchLists", "CourseWatchListID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.CourseWatchLists");
            AlterColumn("dbo.CourseWatchLists", "LessonNumber", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.CourseWatchLists", "CourseWatchListID", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.CourseWatchLists", "CourseWatchListID");
        }
    }
}
