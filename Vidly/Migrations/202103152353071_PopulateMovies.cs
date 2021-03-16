namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies ( Name, Genre, ReleaseDate, CreatedAt) VALUES ( 'Shrek', 'Comedy', '2001-06-22 00:00:00.000', GETDATE())");
            Sql("INSERT INTO Movies ( Name, Genre, ReleaseDate, CreatedAt) VALUES ( 'Toy Story', 'Comedy', '1995-12-22 00:00:00.000', GETDATE())");
            Sql("INSERT INTO Movies ( Name, Genre, ReleaseDate, CreatedAt) VALUES ( 'The Terminator', 'Fantasy', '1985-03-25 00:00:00.000', GETDATE())");
            Sql("INSERT INTO Movies ( Name, Genre, ReleaseDate, CreatedAt) VALUES ( 'Titanic', 'Drama', '1998-01-16 00:00:00.000', GETDATE())");
            Sql("INSERT INTO Movies ( Name, Genre, ReleaseDate, CreatedAt) VALUES ( 'Avatar', 'Fantasy', '2009-12-18 00:00:00.000', GETDATE())");

        }

        public override void Down()
        {
            Sql("DELETE FROM Movies");
        }
    }
}
