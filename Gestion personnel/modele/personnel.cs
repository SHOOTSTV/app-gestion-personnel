using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    public class Personnel
    {
        private int idpersonnel;
        private int idservice;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private string service;

        public int Idpersonnel { get => idpersonnel; }
        public int Idservice { get => idservice; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }
        public string Service { get => service; }

        // Constructeur
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
