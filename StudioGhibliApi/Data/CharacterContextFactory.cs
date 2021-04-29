using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

using StudioGhibliApi.Data.CharacterDbContext;

namespace StudioGhibliApi.Data.CharacterContextFactory
{
    public class CharacterContextFactory : IDesignTimeDbContextFactory<CharacterContext>
    {
        public CharacterContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<CharacterContext> optionsBuilder = new DbContextOptionsBuilder<CharacterContext>();

            optionsBuilder.UseSqlite("Data Source=.\\CharacterContext.db");

            return new CharacterContext(optionsBuilder.Options);
        }
    }
}