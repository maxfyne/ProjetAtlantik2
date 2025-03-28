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
    public partial class FormAjouterUnPort : Form
    {
        public FormAjouterUnPort()
        {
            InitializeComponent();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            {
                MySqlConnection maCnx;
                maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");

                try
                {
                    string requête;
                    maCnx.Open(); // on se connecte
                                  // NOTA BENE : title est un nom de champ, titles le nom de la table !
                                  // DEBUT requête paramétrée

                    requête = "INSERT INTO Port (nom) values (@NomPort)";
                    var maCde = new MySqlCommand(requête, maCnx);

                    maCde.Parameters.AddWithValue("@NomPort", tbxNomPort.Text);
                    maCde.ExecuteScalar();

                    MessageBox.Show("Ajout du Port " + tbxNomPort.Text);
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
        }

        private void tbxNomPort_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNomPort_Click(object sender, EventArgs e)
        {

        }

        private void FormAjouterUnPort_Load(object sender, EventArgs e)
        {

        }
    }
}
