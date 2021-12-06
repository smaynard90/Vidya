namespace Vidya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer1Birthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate='1/1/1980' WHERE Id=1");
        }
        
        public override void Down()
        {
        }
    }
}
