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
//using System.Xml.Linq;
//using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Prjt
{
    public partial class FormAjouterTarifer : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;

        public FormAjouterTarifer()
        {
            InitializeComponent();
        }

        private void gbxTarifCategorieType_Enter(object sender, EventArgs e)
        {

        }

        private void FormAjouterTarifer_Load(object sender, EventArgs e)
        {
            try
            {
                string requête;
                maCnx.Open();

                requête = "Select * from Type";
                var maCde = new MySqlCommand(requête, maCnx);

                Label lbl;
                TextBox tbx;
                int i = 0;

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())

                {
                    i += 1;
                    lbl = new Label();
                    lbl.Text = jeuEnr.GetString("Lettrecategorie") + "-" + jeuEnr.GetInt32("Notype") + " " + jeuEnr.GetString("Libelle");
                    lbl.Location = new Point(0, i * 25);
                    gbxTarifCategorieType.Controls.Add(lbl);


                    tbx = new TextBox();
                    tbx.Location = new Point(107, i * 25);
                    tbx.Tag = jeuEnr.GetString("Lettrecategorie") + "-" + jeuEnr.GetInt32("Notype");
                    gbxTarifCategorieType.Controls.Add(tbx);

                }
                jeuEnr.Close();

                ////////////////////////////////////////////////////////////////////

                requête = "Select * from Secteur";
                maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    lbxSecteurs.Items.Add(new Secteur (jeuEnr.GetInt32("NoSecteur"),(jeuEnr.GetString("Nom"))));
                }
                jeuEnr.Close();

                ////////////////////////////////////////////////////////////////////

                requête = "Select * from periode";
                maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbPeriode.Items.Add(new Periode(jeuEnr.GetInt32("NoPeriode"), (jeuEnr.GetDateTime("DateDebut")), (jeuEnr.GetDateTime("DateFin"))));
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
            foreach (Control element in gbxTarifCategorieType.Controls)
            {
                if (element is TextBox)
                {
                    string[] tags = ((TextBox)element).Tag.ToString().Split('-');
                    MessageBox.Show(tags[0] + tags[1]);           ///a1, a2, a3, b1, b2 ...
                    MessageBox.Show(element.Text);          ///le contenue

                    try
                    {
                        string requête;
                        maCnx.Open();

                        requête = "INSERT INTO Tarifer (NOPERIODE, LETTRECATEGORIE, NOTYPE, NOLIAISON, TARIF) values (@NoPeriode, @LettreCategorie, @NoType, @Noliaison, @Tarif)";
                        var maCde = new MySqlCommand(requête, maCnx);

                        maCde.Parameters.AddWithValue("@NoPeriode", ((Periode)cmbPeriode.SelectedItem).GetNoPeriode());
                        maCde.Parameters.AddWithValue("@LettreCategorie", tags[0] + tags[1]);
                        maCde.Parameters.AddWithValue("@NoType", tags[1]);
                        maCde.Parameters.AddWithValue("@Noliaison", ((Liaison)cmbLiaison.SelectedItem).getNoLiaison());
                        maCde.Parameters.AddWithValue("@Tarif", element.Text);
                        maCde.ExecuteScalar();
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

        private void cmbLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPeriode_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
