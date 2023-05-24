using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using StudioGhibliApi.Data.CharacterDbContext;

namespace StudioGhibliApi.Data.CharacterContextFactory
{
    ///
    public class CharacterContextFactory : IDesignTimeDbContextFactory<CharacterContext>
    {
        ///
        public CharacterContext CreateDbContext(string[] args)
        {
            new DbContextOptionsBuilder<CharacterContext>().UseSqlite("Data Source=CharacterContext.db");

            return new CharacterContext(new DbContextOptionsBuilder<CharacterContext>().Options);
        }
    }
}