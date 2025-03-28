using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prjt
{
    public class Secteur
    {
        private int Nosecteur;
        private string Nom;
        public Secteur(int Nosecteur, string Nom)
        {
            this.Nosecteur = Nosecteur;
            this.Nom = Nom;
        }
        public int GetNosecteur()
        {
            return Nosecteur;
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
