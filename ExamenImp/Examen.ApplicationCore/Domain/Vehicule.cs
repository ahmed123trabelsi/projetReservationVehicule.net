using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Vehicule
    {
        public int VehiculeId { get; set; }
        [MaxLength(25, ErrorMessage = "La couleur ne peut pas dépasser 25 caractères.")]
        public string Couleur { get; set; }
        public double PrixJour { get; set; }
        public int Kilometrage { get; set; }
        public ICollection<Reservation> reservations { get; set; }
        public Agent agent { get; set; }

    }
}
