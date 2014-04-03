using reckrDotNet.Models;
using System.Data.Entity;

namespace reckrDotNet.DAL
{
    public class ReckrContext : DbContext
    {
        public ReckrContext() : base("ReckrContext")
        {
        }

        public DbSet<Court> Courts { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}