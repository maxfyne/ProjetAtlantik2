using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjt
{
    internal class Liaison
    {
        private int NoLiaison;
        private string PortDepart;
        private string PortArrive;

        public Liaison(int NoLiaison, string PortDepart, string PortArrivee)
        {
            this.NoLiaison = NoLiaison;
            this.PortDepart = PortDepart;
            this.PortArrive = PortArrivee;
        }

        public int getNoLiaison()
            { return NoLiaison; }

        public string getPortDepart() 
            { return PortDepart; }

        public string getPortArrive() 
            { return PortArrive; }

        public override string ToString()
        {
            return PortDepart + " - " + PortArrive;
        }

    }
}
