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
    public partial class FormAjouterTraversee : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        public FormAjouterTraversee()
        {
            InitializeComponent();
        }

        private void FormAjouterTraversee_Load(object sender, EventArgs e)
        {
            try
            {
                maCnx.Open();
                string requête;

                requête = "Select * from Secteur";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur(jeuEnr.GetInt32("NoSecteur"), (jeuEnr.GetString("Nom"))));
                }
                jeuEnr.Close();

                ////////////////////////////////////////////////////////////////////

                requête = "Select * from Bateau";
                maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbNomBateau.Items.Add(new Bateau(jeuEnr.GetInt32("NOBATEAU"), jeuEnr.GetString("NOM")));
                }


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

        private void lbxSecteurs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmbLiaison.Items.Clear();
                string requête;
                maCnx.Open();

                requête = "Select noLiaison, PortDepart.nom as 'Nom Port Depart', PortArrive.nom as 'Nom Port arrivée' from liaison inner join port as PortDepart on PortDepart.noport = noport_depart inner join port as PortArrive on (PortArrive.noport = noport_arrivee) where Nosecteur = @Nosecteur";
                var maCde = new MySqlCommand(requête, maCnx);

                maCde.Parameters.AddWithValue("@Nosecteur", ((Secteur)lbxSecteurs.SelectedItem).GetNosecteur());    ///Obligatoire autrement ca selectionne l'item et non le Secteur 
                jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    cmbLiaison.Items.Add(new Liaison(jeuEnr.GetInt32("NoLiaison"), jeuEnr.GetString("Nom Port Depart"), jeuEnr.GetString("Nom Port arrivée")));
                }
                jeuEnr.Close();
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

        
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            try
            {
                string requête;
                maCnx.Open();

                Dates dates;
                dates = new Dates(dateTimePickerDépart.Value, dateTimePickerArrivée.Value);


                requête = "INSERT INTO Traversee (NOLIAISON, NOBATEAU, DATEHEUREDEPART, DATEHEUREARRIVEE, CLOTUREEMBARQUEMENT) values (@noliaison, @nobateau, @dateheuredepart, @dateheurearrivee, 0)";
                var maCde = new MySqlCommand(requête, maCnx);

                maCde.Parameters.AddWithValue("@noliaison", ((Liaison)cmbLiaison.SelectedItem).getNoLiaison());
                maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbNomBateau.SelectedItem).GetNobateau());
                maCde.Parameters.AddWithValue("@dateheuredepart", dates.GetDepart());
                maCde.Parameters.AddWithValue("@dateheurearrivee", dates.GetArrivee());
                maCde.ExecuteScalar();

                MessageBox.Show("Ajout de la traversee");
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
}
