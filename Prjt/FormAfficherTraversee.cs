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
    public partial class FormAfficherTraversee : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        public FormAfficherTraversee()
        {
            InitializeComponent();
        }

        private void FormAfficherTraversee_Load(object sender, EventArgs e)
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

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            try
            {
                cmbLiaison.Items.Clear();
                string requête;
                maCnx.Open();
                requête = "SELECT t.NOTRAVERSEE, t.DATEHEUREDEPART, b.NOM from traversee t inner join bateau b on (t.NOBATEAU = b.NOBATEAU) where t.NOLIAISON = @liaison";
                var maCde = new MySqlCommand(requête, maCnx);

                MessageBox.Show(cmbLiaison.Items.ToString());
                /////////////////////EEEEEEEEEEEEEEEEEEEERRRRRRRRRRRRRRRRRRRRRRRREEEEEEEEEEEEEEEEEEEEEEEUUUUUUUUUUUUUUUUUUUUUUUUUUUUUURRRRRRRRRRRRRRRRRRRRRR
                maCde.Parameters.AddWithValue("@liaison", ((Liaison)cmbLiaison.SelectedItem).getNoLiaison());    ///Obligatoire autrement ca selectionne l'item et non le Secteur 
                MySqlDataReader jeuEnr = maCde.ExecuteReader();

                while (jeuEnr.Read())
                {
                    // Ajout des entêtes de colonne
                    lvTraversee.Columns.Add("Numero");
                    lvTraversee.Columns.Add("Heure");
                    lvTraversee.Columns.Add("Bateau");
                    lvTraversee.Columns.Add("A Passager");
                    lvTraversee.Columns.Add("B Véhicule < 2m");
                    lvTraversee.Columns.Add("C Véhicule > 2m");


                    // Ajout de lignes dans le Listview
                    var tabItem = new string[5];
                    ListViewItem unItem;

                    // Ajout d'un premier item
                    tabItem[0] = jeuEnr.GetInt32("NoTraversee").ToString();
                    tabItem[1] = dateTimePickerDate.Value.ToString("HH:mm:ss");
                    tabItem[2] = jeuEnr.GetInt32("NoTraversee").ToString();


                    tabItem[3] = (GetCapaciteMaximale(int.Parse(jeuEnr.GetValue(0).ToString()), "A".ToString()) - GetQuantiteEnregister(int.Parse(jeuEnr.GetValue(0).ToString()), "A")).ToString();
                    tabItem[4] = (GetCapaciteMaximale(int.Parse(jeuEnr.GetValue(0).ToString()), "B".ToString()) - GetQuantiteEnregister(int.Parse(jeuEnr.GetValue(0).ToString()), "B")).ToString();
                    tabItem[5] = (GetCapaciteMaximale(int.Parse(jeuEnr.GetValue(0).ToString()), "C".ToString()) - GetQuantiteEnregister(int.Parse(jeuEnr.GetValue(0).ToString()), "C")).ToString();

                    unItem = new ListViewItem(tabItem); // Création ligne
                    lvTraversee.Items.Add(unItem); // Ajout ligne
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

        private int GetCapaciteMaximale(int notraversee, string lettrecategorie)
        {
            MySqlConnection maCnx; // ! déclaration avant le bloc Try
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");

            try
            {
                int capacitemax;
                string requete;
                maCnx.Open();
                requete = "SELECT c.CAPACITEMAX from contenir c INNER JOIN traversee t on (c.NOBATEAU = t.NOBATEAU)where c.LETTRECATEGORIE = @lettrecategorie and t.NOTRAVERSEE = @notraversee";
                var maCde = new MySqlCommand(requete, maCnx);

                maCde.Parameters.AddWithValue("@Notraversee", notraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);

                capacitemax = Convert.ToInt32(maCde.ExecuteScalar());
                return capacitemax;
            }

            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
                return 0;
            }

            finally
            {
                if (maCnx is object & maCnx.State == ConnectionState.Open)
                {
                    maCnx.Close(); // on se déconnecte
                }
            }
        }

        private int GetQuantiteEnregister(int notraversee, string lettrecategorie)
        {
            MySqlConnection maCnx; // ! déclaration avant le bloc Try
            MySqlDataReader jeuEnr = null;
            maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
            try
                  
            {
                int somme = 0;
                string requete;
                maCnx.Open();

                requete = "SELECT e.QUANTITERESERVEE from enregistrer e INNER JOIN reservation r on (e.NORESERVATION = r.NORESERVATION) where e.LETTRECATEGORIE = @lettrecategorie and r.NOTRAVERSEE = @notraversee";
                var maCde = new MySqlCommand(requete, maCnx);

                maCde.Parameters.AddWithValue("@Notraversee", notraversee);
                maCde.Parameters.AddWithValue("@lettrecategorie", lettrecategorie);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    somme += int.Parse(jeuEnr.GetValue(0).ToString());
                }
                return somme;

            }

            catch (MySqlException erreur)
            {
                MessageBox.Show("Erreur " + erreur.ToString());
                return 0;
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