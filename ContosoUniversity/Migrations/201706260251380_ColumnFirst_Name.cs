namespace ContosoUniversity.Migrations
{
    using System.Data.Entity.Migrations;

    public partial class ColumnFirst_Name : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Student", name: "FirstMidName", newName: "First_Name");
        }
        
        public override void Down()
        {
            RenameColumn(table: "dbo.Student", name: "First_Name", newName: "FirstMidName");
        }
    }
}
