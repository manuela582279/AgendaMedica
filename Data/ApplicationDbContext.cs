using AgendaMedica.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AgendaMedica.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }
        public DbSet<Especialidade> especialidades { get; set; }
        public DbSet<Medico> medicos { get; set; }
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Agenda> agendas { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<Especialidade>().ToTable("Especialidades");
            builder.Entity<Medico>().ToTable("Medicos");
            builder.Entity<Paciente>().ToTable("Pacientes");
            builder.Entity<Agenda>().ToTable("Agendas");
        }
    }
}
