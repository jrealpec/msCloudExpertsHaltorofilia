using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Data.SqlClient;

namespace com.jrealpec.mscloudexperts.halterofilia.Models
{
    public partial class msCloudbd_Context : DbContext
    {
        private readonly DbContextOptions _options;
        public IConfiguration Configuration { get; }
        public IServiceCollection services { get; }

        public msCloudbd_Context()
        {
        }

        public msCloudbd_Context(DbContextOptions<msCloudbd_Context> options)
            : base(options)
        {
            _options = options;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                                    .AddJsonFile("appsettings.json")
                                    .Build();

                optionsBuilder.UseSqlServer(configuration.GetConnectionString("mscloudDatabase"));
            }
        }

        public virtual DbSet<Competencia> Competencia { get; set; }
        public virtual DbSet<Deportista> Deportista { get; set; }
        public virtual DbSet<Modalidad> Modalidad { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Competencia>(entity =>
            {
                entity.HasOne(d => d.CodDeportistaNavigation)
                    .WithMany(p => p.Competencia)
                    .HasForeignKey(d => d.CodDeportista)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competencia_Deportista");

                entity.HasOne(d => d.CodModalidadNavigation)
                    .WithMany(p => p.Competencia)
                    .HasForeignKey(d => d.CodModalidad)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Competencia_Modalidad");
            });

            modelBuilder.Entity<Deportista>(entity =>
            {
                entity.HasOne(d => d.CodPaisNavigation)
                    .WithMany(p => p.Deportista)
                    .HasForeignKey(d => d.CodPais)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Deportista_Pais");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
