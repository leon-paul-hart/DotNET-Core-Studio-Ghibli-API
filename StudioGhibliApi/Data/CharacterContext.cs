using Microsoft.EntityFrameworkCore;

using StudioGhibliApi.Models.Character;

namespace StudioGhibliApi.Data.CharacterDbContext
{
    public class CharacterContext : DbContext
    {
        public DbSet<Character> Character { get; set; }

        public CharacterContext(DbContextOptions<CharacterContext> options) : base(options)
        {

        }
    }
}
