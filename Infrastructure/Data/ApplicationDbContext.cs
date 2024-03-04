using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.Data
{
    public class ApplicationContext : DbContext
    {
       
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:liciads.database.windows.net,1433;Initial Catalog=liciadb;Persist Security Info=False;User ID=licia;Password=p3a6d8U#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            //optionsBuilder.UseSqlServer("Data Source=DESKTOP-7TD6DU4\\SQLEXPRESS;Initial Catalog=asgard;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}