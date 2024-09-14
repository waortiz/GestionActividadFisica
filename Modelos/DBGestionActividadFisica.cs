using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Modelos
{
    public class DBGestionActividadFisica : DbContext
    {
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<CondicionEmocional> CondicionesEmocionales { get; set; }
        public DbSet<Evaluacion> Evaluaciones { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Sexo> Sexos { get; set; }
        public DbSet<TipoDocumento> TiposDocumentos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(ConfigurationManager.ConnectionStrings["GestionActividadFisica"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<TipoDocumento>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.TipoDocumento)
                .HasForeignKey(e => e.IdTipoDocumento);

            builder.Entity<Sexo>()
                .HasMany(e => e.Personas)
                .WithOne(e => e.Sexo)
                .HasForeignKey(e => e.IdSexo);

            builder.Entity<Ciudad>()
                .HasMany(e => e.Evaluaciones)
                .WithOne(e => e.Ciudad)
                .HasForeignKey(e => e.IdCiudad);

            builder.Entity<CondicionEmocional>()
                .HasMany(e => e.Evaluaciones)
                .WithOne(e => e.CondicionEmocional)
                .HasForeignKey(e => e.IdCondicionEmocional);

            builder.Entity<Persona>()
                .HasMany(e => e.Usuarios)
                .WithOne(e => e.Persona)
                .HasForeignKey(e => e.IdPersona);

            builder.Entity<Persona>()
                .HasMany(e => e.Evaluaciones)
                .WithOne(e => e.Persona)
                .HasForeignKey(e => e.IdPersona);
        }
    }
}
