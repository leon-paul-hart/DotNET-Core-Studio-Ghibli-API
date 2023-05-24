using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using StudioGhibliApi.Data.FilmDbContext;

namespace StudioGhibliApi.Data.FilmContextFactory
{
    ///
    public class FilmContextFactory : IDesignTimeDbContextFactory<FilmContext>
    {
        ///
        public FilmContext CreateDbContext(string[] args)
        {
            new DbContextOptionsBuilder<FilmContext>().UseSqlite("Data Source=FilmContext.db");

            return new FilmContext(new DbContextOptionsBuilder<FilmContext>().Options);
        }
    }
}