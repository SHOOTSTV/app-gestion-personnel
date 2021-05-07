using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    public class Service
    {
        private int idservice;
        private string nom;

        // Constructeur
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        public int Idservice { get => idservice; }
        public string Nom { get => nom; }

        // Définit l'information à afficher 
        public override string ToString()
        {
            return this.nom;
        }
    }
}
