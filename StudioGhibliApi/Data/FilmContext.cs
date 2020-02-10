using Microsoft.EntityFrameworkCore;

namespace StudioGhibliApi.Data
{
    public class FilmContext : DbContext
    {
        public FilmContext (DbContextOptions<FilmContext> options)
            : base(options)
        {
        }

        public DbSet<StudioGhibliApi.Models.Film> Film { get; set; }
    }
}
