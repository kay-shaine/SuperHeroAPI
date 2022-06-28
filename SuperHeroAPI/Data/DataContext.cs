using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using SuperHeroAPI.Models;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
     
        public DbSet<SuperHero> Superheroes { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

    }
}
