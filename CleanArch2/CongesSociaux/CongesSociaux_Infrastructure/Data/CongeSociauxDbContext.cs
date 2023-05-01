using CongesSociaux_Application.Interfaces;
using CongesSociaux_Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CongesSociaux_Infrastructure.Data
{
    public class CongeSociauxDbContext : IdentityDbContext, IApplicationDbContext
    {
        public CongeSociauxDbContext(DbContextOptions<CongeSociauxDbContext> options): base(options){}

        public DbSet<BanqueMaladie> BanqueMaladies { get; set; }
        public DbSet<Conge> Conges { get; set; }
        public DbSet<Departement> Departements { get; set; }
        public DbSet<Enseignant> Enseignants { get; set; }
        public DbSet<Periode> Periodes { get; set; }
        public DbSet<Soutien> Soutiens { get; set; }
        public DbSet<TypeConge> TypeConges { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.GenerateData();
        }
    }
}