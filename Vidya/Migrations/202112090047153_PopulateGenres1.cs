namespace Vidya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenres1 : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Id, Name) VALUES (0, 'Action')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action-Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Adventure')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Role-Playing')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Simulation')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Strategy')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Sports')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (7, 'MMO')");
            Sql("INSERT INTO Genres (Id, Name) VALUES (8, 'Other')");
        }
        
        public override void Down()
        {
        }
    }
}
