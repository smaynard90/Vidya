namespace Vidya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer2Birthday : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate=null WHERE Id=2");
        }
        
        public override void Down()
        {
        }
    }
}
