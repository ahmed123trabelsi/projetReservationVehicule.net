using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen.ApplicationCore.Domain
{
    public class Agent
    {
        public int AgentId { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime DateEmbauche { get; set; }
        public ICollection<Locataire> locataires { get; set; }
    }
}
