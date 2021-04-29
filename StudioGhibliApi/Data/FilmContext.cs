using Microsoft.EntityFrameworkCore;

using StudioGhibliApi.Models.Film;

namespace StudioGhibliApi.Data.FilmDbContext
{
    public class FilmContext : DbContext
    {
        public DbSet<Film> Film { get; set; }

        public FilmContext(DbContextOptions<FilmContext> options) : base(options)
        {

        }
    }
}
