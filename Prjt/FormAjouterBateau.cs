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
using static Org.BouncyCastle.Crypto.Engines.SM2Engine;
using System.Xml.Linq;

namespace Prjt
{
    public partial class FormAjouterBateau : Form
    {
        MySqlConnection maCnx = new MySqlConnection("server=localhost;user=root;database=atlantik;port=3306;password=");
        MySqlDataReader jeuEnr = null;
        public FormAjouterBateau()
        {
            InitializeComponent();
        }

        private void AjouterBateau_Load(object sender, EventArgs e)
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
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            long noBateauGenere = 0;
            try
            {
                string requete;
                maCnx.Open();

                requete = "Insert into BATEAU(nom) values (@NOMBATEAU)";
                var maCde = new MySqlCommand(requete, maCnx);
                maCde.Parameters.AddWithValue("@NOMBATEAU", tbxNomBateau.Text);


                //noBateauGenere = Convert.ToInt32((maCde.ExecuteScalar()));
                maCde.ExecuteNonQuery();
                noBateauGenere = maCde.LastInsertedId;
            }
            catch (MySqlException ex)

            {
                Console.WriteLine("Erreur " + ex.ToString());
            }
            finally

            {


                if (maCnx is object & maCnx.State == ConnectionState.Open)

                {

                    maCnx.Close(); // on se déconnecte

                }

            }



            foreach (Control element in gbxCapacitésMaximales.Controls)
            {
                if (element is TextBox)
                {
                    string[] tags = ((TextBox)element).Tag.ToString().Split('-');

                    ///MessageBox.Show(tags[0] + tags[1]);           ///Apassager ; BVehicules<2m ; CVehicules>2m
                    ///MessageBox.Show(element.Text);          ///le contenue

                    try
                    {
                        string requête;
                        maCnx.Open();


                        requête = "INSERT INTO contenir (LETTRECATEGORIE, NOBATEAU, CAPACITEMAX) values (@lettrecategorie, @nobateau, @capacitemax)";
                        var maCde = new MySqlCommand(requête, maCnx);

                        maCde.Parameters.AddWithValue("@lettrecategorie", tags[0]);
                        maCde.Parameters.AddWithValue("@nobateau", noBateauGenere);
                        maCde.Parameters.AddWithValue("@capacitemax", int.Parse(element.Text));

                        int nbLigneAffectees;
                        nbLigneAffectees = maCde.ExecuteNonQuery();
                        MessageBox.Show("Nombre de ligne affectée(s) :" + nbLigneAffectees.ToString());
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
    }
}