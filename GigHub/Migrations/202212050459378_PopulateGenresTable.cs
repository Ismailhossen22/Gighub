namespace GigHub.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres( Id ,Name ) VALUES(2,'ismail')");
            Sql("INSERT INTO Genres( Id ,Name ) VALUES(3,'Jamal')");
            Sql("INSERT INTO Genres( Id ,Name ) VALUES(4,'Hassan')");
            Sql("INSERT INTO Genres( Id ,Name ) VALUES(5,'Abir')");
            Sql("INSERT INTO Genres( Id ,Name ) VALUES(6,'Sawon')");

        }
        
        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE ID IN(2,3,4,5,6)");
        }
    }
}
