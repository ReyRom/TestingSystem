using System.Collections.Generic;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace TestingSystemData.Model
{
    public partial class TestSystemContext : DbContext
    {
        public TestSystemContext()
        {
        }

        public TestSystemContext(DbContextOptions<TestSystemContext> options)
        : base(options)
        {
        }

        public virtual DbSet<Lection> Lections { get; set; }
        public virtual DbSet<LectionContent> LectionContents { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Test> Tests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseLazyLoadingProxies().UseSqlServer("Data Source=PATRASSERVER\\SCHOOLSERVER;Initial Catalog = TestSystem; User ID = testingsystem; Password=testingsystem;Trust Server Certificate=True");
        //Data Source=ROMA1NV1CTUS\\ROMA1NV1CTUS;Initial Catalog=TestSystem;User ID=sa;Password=1;Trust Server Certificate=True
        //Data Source=PATRASSERVER\\SCHOOLSERVER;Initial Catalog = TestSystem; User ID = testingsystem; Password=testingsystem;Trust Server Certificate=True

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Lection>(entity =>
            {
                entity.Property(e => e.Group).HasMaxLength(100);
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.HasOne(e => e.LectionContent)
                    .WithOne(e => e.Lection)
                    .HasConstraintName("FK_LectionContents_Lections");
            });

            modelBuilder.Entity<LectionContent>(entity =>
            {
                entity.HasKey(e => e.LectionId);
                entity.Property(e => e.Content)
                    .IsRequired();
            });

            modelBuilder.Entity<Result>(entity =>
            {
                entity.Property(e => e.DateTime)
                    .HasDefaultValueSql("(getdate())")
                    .HasColumnType("datetime");
                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(300);

                entity.HasOne(d => d.Test).WithMany(p => p.Results)
                    .HasForeignKey(d => d.TestId)
                    .HasConstraintName("FK_Result_Test");
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasKey(e => e.TestId).HasName("PK_Test");

                entity.Property(e => e.Description).HasMaxLength(300);
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
                entity.Property(e => e.XmlContent);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }

}