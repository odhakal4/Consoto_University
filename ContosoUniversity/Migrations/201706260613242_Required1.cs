namespace ContosoUniversity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Required1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "Title", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Course", "Title", c => c.String(nullable: false, maxLength: 15));
        }
    }
}
