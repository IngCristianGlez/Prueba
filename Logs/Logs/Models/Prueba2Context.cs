using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Logs.Models
{
    public partial class Prueba2Context : DbContext
    {
        public Prueba2Context()
        {
        }

        public Prueba2Context(DbContextOptions<Prueba2Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Log> Log { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(e => e.IdLog)
                    .HasName("PRIMARY");

                entity.Property(e => e.IdLog)
                    .HasColumnName("idLog")
                    .HasColumnType("int(11)");

                entity.Property(e => e.DateRegister)
                    .IsRequired()
                    .HasColumnName("Date_Register")
                    .HasColumnType("varchar(50)")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasCharSet("latin1")
                    .HasCollation("latin1_swedish_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
