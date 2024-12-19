using Microsoft.EntityFrameworkCore;
using Taboooooooooooo.Entities;

namespace Taboooooooooooo.DAL
{
    public class TabooDbContext : DbContext
    {
        public TabooDbContext(DbContextOptions<TabooDbContext> opt) : base(opt) { }
        public DbSet<Language> Languages { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>(model =>
            {
                model.HasKey(x => x.Code);

                model.Property(x => x.Code)
                .IsRequired()
                .HasMaxLength(2);
                model.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(64);
                model.Property(x => x.Icon)
                .IsRequired()
                .HasMaxLength(128);
            });
            base.OnModelCreating(modelBuilder);
        }
    }
}
