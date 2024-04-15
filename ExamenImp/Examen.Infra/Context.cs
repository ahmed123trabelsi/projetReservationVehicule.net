using Examen.ApplicationCore.Domain;
using Examen.Infra.Configuartion;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infra
{
    public class Context:DbContext
    {
        public DbSet<Locataire> Locataires { get; set; }
        public DbSet<Vehicule> Vehicules { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Entreprise> Entreprises { get; set; }
        public DbSet<Agent> Agents{ get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Initial Catalog=LocationTrabelsiAhmed;Integrated Security=true;Encrypt=True;TrustServerCertificate=True;");




        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new ReservationConfiguration());
            modelBuilder.ApplyConfiguration(new LocataireConfiguration());

        }
    }
}
