namespace ContosoUniversity.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Required : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Course", "Title", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Course", "Title", c => c.String());
        }
    }
}
