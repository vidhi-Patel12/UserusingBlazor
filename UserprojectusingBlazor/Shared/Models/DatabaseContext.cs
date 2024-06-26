using Microsoft.EntityFrameworkCore;
//using System.Web.Providers.Entities;
using UserprojectusingBlazor.Shared.Models;

namespace UserprojectusingBlazor.Server.Models
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
          : base(options)
        {
        }
        public virtual DbSet<UserClass> UserDetails { get; set; } 
        protected  void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserClass>(entity =>
            {
                entity.ToTable("UserDetails");
                entity.Property(e => e.UserId).HasColumnName("UserId");
                entity.Property(e => e.UserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Password)
                   .HasMaxLength(50)
                   .IsUnicode(false);
                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.Contact)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                
            });
            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

