namespace DeptStudentApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class studentdeptmodel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Departments", "DeptCode", c => c.String(nullable:true));
            AlterColumn("dbo.Departments", "DeptName", c => c.String(nullable: true));
            AlterColumn("dbo.Students", "Email", c => c.String(nullable: true));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Students", "Email", c => c.String());
            AlterColumn("dbo.Departments", "DeptName", c => c.String());
            AlterColumn("dbo.Departments", "DeptCode", c => c.String());
        }
    }
}
