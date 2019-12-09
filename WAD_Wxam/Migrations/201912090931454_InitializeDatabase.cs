namespace WAD_Wxam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Subjects",
                c => new
                    {
                        ExamId = c.Int(nullable: false, identity: true),
                        StartTime = c.DateTime(nullable: false, precision: 0),
                        ExamData = c.DateTime(nullable: false, precision: 0),
                        ExamDuration = c.DateTime(nullable: false, precision: 0),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ExamId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Subjects");
        }
    }
}
