using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        #region DbSet
        public DbSet<TaskEntity> Task { get; set; }
        public DbSet<VersionEntity> Version { get; set; }
        public DbSet<EnvironmentEntity> Environment { get; set; }
        public DbSet<ApplicationEntity> Application { get; set; }
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}