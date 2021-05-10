using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    /// <summary>
    /// Classe qui gère le constructeur des personnels
    /// </summary>
    public class Personnel
    {
        private int idpersonnel;
        private int idservice;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private string service;

        /// <summary>
        /// getter l'idpersonnel d'un personnel
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }
        /// <summary>
        /// getter sur l'idservice d'un personnel
        /// </summary>
        public int Idservice { get => idservice; }
        /// <summary>
        /// getter sur le nom d'un personnel
        /// </summary>
        public string Nom { get => nom; }
        /// <summary>
        /// getter sur le prenom d'un personnel
        /// </summary>
        public string Prenom { get => prenom; }
        /// <summary>
        /// getter sur le tel d'un personnel
        /// </summary>
        public string Tel { get => tel; }
        /// <summary>
        /// getter sur le mail d'un personnel
        /// </summary>
        public string Mail { get => mail; }
        /// <summary>
        /// getter sur le service d'un personnel
        /// </summary>
        public string Service { get => service; }

        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="idservice"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="service"></param>
        public Personnel(int idpersonnel, int idservice, string nom, string prenom, string tel, string mail, string service)
        {
            this.idpersonnel = idpersonnel;
            this.idservice = idservice;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.service = service;
        }


    }
}
