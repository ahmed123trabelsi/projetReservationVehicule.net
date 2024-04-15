using Examen.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Examen.Infra.Configuartion
{
    public class ReservationConfiguration : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
          
       builder.HasOne(r => r.locataire)
       .WithMany(l => l.reservations)
       .HasForeignKey(r => r.LocataireKey);

        
                builder.HasOne(r => r.vehicule)
                .WithMany(v => v.reservations)
                .HasForeignKey(r => r.VehiculeKey);
            builder.HasKey(rt => new { rt.DateReservation, rt.LocataireKey, rt.VehiculeKey });

        }
    }
}
