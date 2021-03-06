namespace ContosoUniversity.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class MaxLengthOnNames1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 15));
            AlterColumn("dbo.Student", "FirstMidName", c => c.String(maxLength: 15));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Student", "FirstMidName", c => c.String(maxLength: 50));
            AlterColumn("dbo.Student", "LastName", c => c.String(maxLength: 50));
        }
    }
}
