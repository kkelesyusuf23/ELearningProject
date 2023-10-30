namespace ELearningProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_add_courseRegister : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CourseRegisters",
                c => new
                    {
                        CourseRegisterID = c.Int(nullable: false, identity: true),
                        StudentID = c.Int(nullable: false),
                        CourseID = c.Int(nullable: false),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.CourseRegisterID)
                .ForeignKey("dbo.Courses", t => t.CourseID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.CourseID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CourseRegisters", "StudentID", "dbo.Students");
            DropForeignKey("dbo.CourseRegisters", "CourseID", "dbo.Courses");
            DropIndex("dbo.CourseRegisters", new[] { "CourseID" });
            DropIndex("dbo.CourseRegisters", new[] { "StudentID" });
            DropTable("dbo.CourseRegisters");
        }
    }
}
