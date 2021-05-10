using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    /// <summary>
    /// Classe qui gère le constructeur des motifs
    /// </summary>
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

        /// <summary>
        /// getter sur un id motif de la table motif
        /// </summary>
        public int Idmotif { get => idmotif; }
        /// <summary>
        /// getter sur un libelle de la table motif
        /// </summary>
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
