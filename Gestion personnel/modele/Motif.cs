using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    public class Motif
    {
        private int idmotif;
        private string libelle;

        // Constructeur
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        public int Idmotif { get => idmotif; }
        public string Libelle { get => libelle; }

        // Définit l'information à afficher 
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
