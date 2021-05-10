using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    /// <summary>
    /// Classe qui gère le contructeur des services
    /// </summary>
    public class Service
    {
        private int idservice;
        private string nom;

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        public Service(int idservice, string nom)
        {
            this.idservice = idservice;
            this.nom = nom;
        }

        /// <summary>
        /// getter sur un id service de la table service
        /// </summary>
        public int Idservice { get => idservice; }
        /// <summary>
        /// getter sur un nom de la table service
        /// </summary>
        public string Nom { get => nom; }

        /// <summary>
        /// Définit l'information à afficher
        /// </summary>
        public override string ToString()
        {
            return this.nom;
        }
    }
}
