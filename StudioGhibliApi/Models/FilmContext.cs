using Microsoft.EntityFrameworkCore;

namespace StudioGhibliApi.Models
{
    public class FilmContext : DbContext
    {
        public FilmContext(DbContextOptions<FilmContext> options)
            : base(options)
        {
            
        }

        public DbSet<Film> Films { get; set; }
    }
}
