using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prjt
{
    public partial class FormAjouterUneLiaison : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        

        public FormAjouterUneLiaison()
        {
            InitializeComponent();
        }


        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Id du client sélectionné :" + ((Secteur)(lbxSecteurs.SelectedItem)).GetNosecteur().ToString());

            try
            {
                string requête;
                maCnx.Open(); // on se connecte
                              // NOTA BENE : title est un nom de champ, titles le nom de la table !
                              // DEBUT requête paramétrée

                requête = "INSERT INTO Liaison (NoPort_Depart, NoSecteur, NoPort_Arrivee, Distance) values (@NoPortDepart, @NoSecteur, @NoPortArrivée, @Distance)";
                var maCde = new MySqlCommand(requête, maCnx);

                maCde.Parameters.AddWithValue("@NoPortDepart", ((Port) cmbDepart.SelectedItem).GetNoport());
                maCde.Parameters.AddWithValue("@NoSecteur", ((Secteur) lbxSecteurs.SelectedItem).GetNosecteur());
                maCde.Parameters.AddWithValue("@NoPortArrivée", ((Port)cmbDepart.SelectedItem).GetNoport());
                maCde.Parameters.AddWithValue("@Distance",(tbxDistance.Text));

                int nbLigneAffectées = maCde.ExecuteNonQuery();
                MessageBox.Show("Nombre de ligne affectée(s) :" + nbLigneAffectées.ToString());

            }

            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
            }

            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }

        private void FormAjouterUneLiaison_Load(object sender, EventArgs e)
        {
            try
            {
                string requête;
                maCnx.Open();

                requête = "Select * from Secteur";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur(jeuEnr.GetInt32("Nosecteur"), jeuEnr.GetString("Nom")));
                }
                jeuEnr.Close();

                requête = "Select * from Port";
                maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbDepart.Items.Add(new Port(jeuEnr.GetInt32("NoPort"), jeuEnr.GetString("Nom")));
                    cmbArrivée.Items.Add(new Port(jeuEnr.GetInt32("NoPort"), jeuEnr.GetString("Nom")));
                }


            }

            catch (MySqlException erreur)
            {
                Console.WriteLine("Erreur " + erreur.ToString());
            }

            finally
            {
                if (jeuEnr is object & !jeuEnr.IsClosed)
                {
                    jeuEnr.Close(); // s'il existe et n'est pas déjà fermé
                }

                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }

        }

        private void cmbDepart_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
