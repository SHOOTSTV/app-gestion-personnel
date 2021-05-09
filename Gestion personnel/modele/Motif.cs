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

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idmotif"></param>
        /// <param name="libelle"></param>
        public Motif(int idmotif, string libelle)
        {
            this.idmotif = idmotif;
            this.libelle = libelle;
        }

        public int Idmotif { get => idmotif; }
        public string Libelle { get => libelle; }

        /// <summary>
        /// Définit l'information à afficher 
        /// </summary>
        /// <returns>retourne le libelle</returns>
        public override string ToString()
        {
            return this.libelle;
        }
    }
}
