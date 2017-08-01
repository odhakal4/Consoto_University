namespace ContosoUniversity.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class Reqired : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "LastName", c => c.String(nullable: false, maxLength: 15));
            AlterColumn("dbo.Student", "First_Name", c => c.String(nullable: false, maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "First_Name", c => c.String(maxLength: 15));
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 15));
        }
    }
}
