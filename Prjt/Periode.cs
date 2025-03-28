using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjt
{
    internal class Periode
    {
        private int noPeriode;
        private DateTime dateDebut;
        private DateTime dateFin;

        public Periode(int noPeriode, DateTime dateDebut, DateTime dateFin)
        {
            this.noPeriode = noPeriode;
            this.dateDebut = dateDebut;
            this.dateFin = dateFin;
        }

        public int GetNoPeriode()
            { return noPeriode; }
        public DateTime GetDateDebut()
            { return dateDebut; }

        public DateTime GetDateFin()
            { return dateFin; }

        public override string ToString()
        {
            return dateDebut.ToString("dd/MM/yyyy") + " au " + dateFin.ToString("dd/MM/yyyy");

        }
    }

}
