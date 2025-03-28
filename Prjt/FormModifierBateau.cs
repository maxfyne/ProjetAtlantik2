using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.Ocsp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;

namespace Prjt
{
    public partial class FormModifierBateau : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        public FormModifierBateau()
        {
            InitializeComponent();
        }

        private void FormModifierBateau_Load(object sender, EventArgs e)
        {
            try
            {
                string requête;
                maCnx.Open();

                requête = "Select * from categorie";
                var maCde = new MySqlCommand(requête, maCnx);

                Label lbl;
                TextBox tbx;
                int i = 0;

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())

                {
                    i += 1;
                    lbl = new Label();
                    lbl.Text = jeuEnr.GetString("LettreCategorie") + " (" + jeuEnr.GetString("Libelle") + ") ";
                    lbl.Location = new Point(0, i * 25);
                    gbxCapacitésMaximales.Controls.Add(lbl);


                    tbx = new TextBox();
                    tbx.Location = new Point(107, i * 25);
                    tbx.Tag = jeuEnr.GetString("LettreCategorie") + "-" + jeuEnr.GetString("Libelle");
                    gbxCapacitésMaximales.Controls.Add(tbx);

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



            /////////////////////////////////////////////////////////////////////////////////////



            try
            {
                string requête;
                maCnx.Open();

                requête = "Select * from Bateau";
                var maCde = new MySqlCommand(requête, maCnx);

                jeuEnr = maCde.ExecuteReader();
                while (jeuEnr.Read())
                {
                    cmbNomBateau.Items.Add(new Bateau(jeuEnr.GetInt32("NOBATEAU"), jeuEnr.GetString("NOM")));
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







        private void btnModifier_Click(object sender, EventArgs e)
        {
            foreach (Control element in gbxCapacitésMaximales.Controls)
            {
                if (element is TextBox)
                {
                    string[] tags = ((TextBox)element).Tag.ToString().Split('-');

                    try
                    {
                        maCnx.Open();
                        string requête;
                        

                        requête = "UPDATE contenir SET CAPACITEMAX = @Capacitemax WHERE LETTRECATEGORIE = @lettrecategorie and NOBATEAU = @nobateau";
                        var maCde = new MySqlCommand(requête, maCnx);

                        maCde.Parameters.AddWithValue("@capacitemax", element.Text);
                        maCde.Parameters.AddWithValue("@lettrecategorie", tags[0]);
                        maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbNomBateau.SelectedItem).GetNobateau());

                        maCde.ExecuteScalar();
                        MessageBox.Show("Modification effectué");
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

        private void gbxCapacitésMaximales_Enter(object sender, EventArgs e)
        {

        }









        private void cmbNomBateau_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Control element in gbxCapacitésMaximales.Controls)
            {
                if (element is TextBox)
                {
                    string[] tags = ((TextBox)element).Tag.ToString().Split('-');

                    ///MessageBox.Show(tags[0] + tags[1]);           ///Apassager ; BVehicules<2m ; CVehicules>2m
                    ///MessageBox.Show(element.Text);          ///le contenue

                    try
                    {
                        string requete;
                        
                        maCnx.Open();

                        requete = "SELECT Capacitemax FROM contenir where LETTRECATEGORIE = @lettrecategorie and NOBATEAU = @nobateau;";
                        var maCde = new MySqlCommand(requete, maCnx);

                        maCde.Parameters.AddWithValue("@lettrecategorie", tags[0]);
                        maCde.Parameters.AddWithValue("@nobateau", ((Bateau)cmbNomBateau.SelectedItem).GetNobateau());

                        int nobateau;
                        nobateau = (int)(maCde.ExecuteScalar());
                        element.Text = (nobateau.ToString());
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

    }
}
