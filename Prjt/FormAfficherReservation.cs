using MySql.Data.MySqlClient;
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
    public partial class FormAfficherReservation : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        public FormAfficherReservation()
        {
            InitializeComponent();
        }

        private void FormAfficherReservation_Load(object sender, EventArgs e)
        {
            try
            {
                maCnx.Open();
                string requête;

                requête = "Select * from client";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbNomPrenom.Items.Add(new Client(jeuEnr.GetInt32("noclient"), (jeuEnr.GetString("nom")), (jeuEnr.GetString("prenom")), (jeuEnr.GetString("adresse")), (jeuEnr.GetInt32("codepostal")),(jeuEnr.GetString("ville")),(jeuEnr.GetString("telfixe")),(jeuEnr.GetString("telmobil")),(jeuEnr.GetString("mel")),(jeuEnr.GetString("mdp"));));
                }
                jeuEnr.Close();

                ////////////////////////////////////////////////////////////////////
                



            }

            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
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
    }
}