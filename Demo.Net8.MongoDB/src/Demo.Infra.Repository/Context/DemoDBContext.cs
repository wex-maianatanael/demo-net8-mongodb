using Demo.Domain;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.EntityFrameworkCore.Extensions;

namespace Demo.Infra.Repository.Context
{
    public class DemoDBContext : DbContext
    {
        public DbSet<User> Users { get; init; }

        public static DemoDBContext Create(IMongoDatabase database) =>
            new(new DbContextOptionsBuilder<DemoDBContext>()
                .UseMongoDB(database.Client, database.DatabaseNamespace.DatabaseName).Options);

        public DemoDBContext(DbContextOptions options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToCollection("users");
        }
    }
}
