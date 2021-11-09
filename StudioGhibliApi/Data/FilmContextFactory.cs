using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using StudioGhibliApi.Data.FilmDbContext;

namespace StudioGhibliApi.Data.FilmContextFactory
{
    public class FilmContextFactory : IDesignTimeDbContextFactory<FilmContext>
    {
        public FilmContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<FilmContext> optionsBuilder = new();

            optionsBuilder.UseSqlite("Data Source=FilmContext.db");

            return new FilmContext(optionsBuilder.Options);
        }
    }
}