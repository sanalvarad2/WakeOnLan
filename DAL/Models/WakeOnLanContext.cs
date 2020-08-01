using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public partial class WakeOnLanContext : DbContext
    {
        public WakeOnLanContext()
        {
        }

        public WakeOnLanContext(DbContextOptions<WakeOnLanContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dispositivos> Dispositivos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=database-2.czrtvd3xk68s.sa-east-1.rds.amazonaws.com,1433;Initial Catalog=WakeOnLan;User Id=admin;Password=12345678;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dispositivos>(entity =>
            {
                entity.Property(e => e.FechaCreacion)
                    .HasColumnName("fechaCreacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Hostname)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Macaddress)
                    .IsRequired()
                    .HasColumnName("MACAddress")
                    .HasMaxLength(17)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
