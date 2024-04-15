using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Reservation
    {
        public DateTime DateReservation { get; set; }
        [Range(1, 30, ErrorMessage = "La durée doit être entre 1 et 30 jours.")]
        public int DureeJours { get; set;}
        public Vehicule vehicule { get; set; }
        public Locataire locataire { get; set; }
        public int LocataireKey
        {
            get; set;
        }

    
 


        public int VehiculeKey
        {
            get; set;
        }

    }
}
