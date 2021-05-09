using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_personnel.modele
{
    public class Absence
    {
        private int idpersonnel;
        private DateTime datedebut;
        private int idmotif;
        private DateTime datefin;
        private string motif;

        public int Idpersonnel { get => idpersonnel; }
        public DateTime Datedebut { get => datedebut; }
        public int Idmotif { get => idmotif; }
        public DateTime Datefin{ get => datefin; }
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
