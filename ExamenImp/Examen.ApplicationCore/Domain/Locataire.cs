using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Locataire
    {
        [Required(ErrorMessage = "L'adresse est obligatoire.")]
        public string Adresse { get; set; }
        public DateTime DateAdhesion { get; set; }
        public int id { get; set; }
        public int PointsBouns { get; set; }
        public string Telephone { get; set; }
        public ICollection<Reservation> reservations { get; set; }
    }
}
