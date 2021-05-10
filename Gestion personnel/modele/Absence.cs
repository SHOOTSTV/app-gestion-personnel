using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    /// <summary>
    /// Classe qui gère le constructeur des Absences
    /// </summary>
    public class Absence
    {
        private int idpersonnel;
        private DateTime datedebut;
        private int idmotif;
        private DateTime datefin;
        private string motif;

        /// <summary>
        /// getter sur l'idpersonnel lié à l'absence
        /// </summary>
        public int Idpersonnel { get => idpersonnel; }
        /// <summary>
        /// getter sur la date de début de l'absence
        /// </summary>
        public DateTime Datedebut { get => datedebut; }
        /// <summary>
        /// getter sur l'id du motif de l'absence
        /// </summary>
        public int Idmotif { get => idmotif; }
        /// <summary>
        /// getter sur la date de fin d'une absence
        /// </summary>
        public DateTime Datefin{ get => datefin; }
        /// <summary>
        /// getter sur le motif de l'absence
        /// </summary>
        public string Motif { get => motif; }


        /// <summary>
        /// Constructeur
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="idmotif"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public Absence(int idpersonnel, DateTime datedebut, int idmotif, DateTime datefin, string motif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut;
            this.idmotif = idmotif;
            this.datefin = datefin;
            this.motif = motif;
        }


    }
}
