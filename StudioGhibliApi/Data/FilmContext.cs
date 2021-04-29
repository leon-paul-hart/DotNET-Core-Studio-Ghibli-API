using Microsoft.EntityFrameworkCore;

namespace StudioGhibliApi.Data
{
    public class FilmContext : DbContext
    {
        public DbSet<Models.Film> Film { get; set; }

        public FilmContext(DbContextOptions<FilmContext> options)
            : base(options)
        {

        }
    }
}
