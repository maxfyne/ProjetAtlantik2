using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace Prjt
{
    internal class Dates
    {
        private DateTime depart;
        private DateTime arrivee;

        public Dates(DateTime depart, DateTime arrivee)
        {
            this.depart = depart;
            this.arrivee = arrivee;
        }

        public DateTime GetDepart()
        {
            return depart;
        }
        public DateTime GetArrivee()
        {
            return arrivee;
        }

        public override string ToString()
        {
            return depart.ToString() + " + " + arrivee.ToString();
        }
    }
}
