namespace Vidya.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateConsoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Consoles (Id, Name) VALUES (0, 'Atari 2600')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (1, 'ColecoVision')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (2, 'NES')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (3, 'Sega Genesis')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (4, 'Super NES')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (5, 'Sega Saturn')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (6, 'Sony PlayStation')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (7, 'Nintendo 64')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (8, 'Dreamcast')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (9, 'PlayStation 2')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (10, 'Nintendo GameCube')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (11, 'Xbox')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (12, 'Xbox 360')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (13, 'PlayStation 3')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (14, 'Wii')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (15, 'Wii U')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (16, 'PlayStation 4')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (17, 'Xbox One')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (18, 'Nintendo Switch')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (19, 'Xbox Series X/S')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (20, 'PlayStation 5')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (21, 'PC')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (22, 'Game Boy')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (23, 'Game Boy Advance')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (24, 'Nintendo DS')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (25, 'PlayStation Portable')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (26, 'Nintendo 3DS')");
            Sql("INSERT INTO Consoles (Id, Name) VALUES (27, 'PlayStation Vita')");
        }
        
        public override void Down()
        {
        }
    }
}
