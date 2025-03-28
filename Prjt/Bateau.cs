using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjt
{
    internal class Bateau
    {
        private int nobateau;
        private string nom;

        public Bateau(int nobateau, string nom)
        {
            this.nobateau = nobateau;
            this.nom = nom;
        }

        public int GetNobateau()
        {
            return nobateau;
        }

        public string GetNom()
        {
            return nom;
        }

        public override string ToString()
        {
            return nom;
        }
    }
}
