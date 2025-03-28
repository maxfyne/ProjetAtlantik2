using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjt
{
    public class Port
    {
        private int Noport;
        private string Nom;
        public Port(int Noport, string Nom)
        {
            this.Noport = Noport;
            this.Nom = Nom;
        }
        public int GetNoport()
        {
            return Noport;
        }
        public string GetNom()
        {
            return Nom;
        }
        public override string ToString()
        {
            return Nom;
        }
    }
}
