namespace Prjt
{
    partial class FormAjouterTarifer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSecteurs = new System.Windows.Forms.Label();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.lblPeriode = new System.Windows.Forms.Label();
            this.cmbPeriode = new System.Windows.Forms.ComboBox();
            this.gbxTarifCategorieType = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(12, 44);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(73, 44);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteurs.TabIndex = 1;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(12, 169);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(72, 169);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 3;
            this.cmbLiaison.SelectedIndexChanged += new System.EventHandler(this.cmbLiaison_SelectedIndexChanged);
            // 
            // lblPeriode
            // 
            this.lblPeriode.AutoSize = true;
            this.lblPeriode.Location = new System.Drawing.Point(12, 237);
            this.lblPeriode.Name = "lblPeriode";
            this.lblPeriode.Size = new System.Drawing.Size(49, 13);
            this.lblPeriode.TabIndex = 4;
            this.lblPeriode.Text = "Periode :";
            // 
            // cmbPeriode
            // 
            this.cmbPeriode.FormattingEnabled = true;
            this.cmbPeriode.Location = new System.Drawing.Point(72, 229);
            this.cmbPeriode.Name = "cmbPeriode";
            this.cmbPeriode.Size = new System.Drawing.Size(121, 21);
            this.cmbPeriode.TabIndex = 5;
            this.cmbPeriode.SelectedIndexChanged += new System.EventHandler(this.cmbPeriode_SelectedIndexChanged);
            // 
            // gbxTarifCategorieType
            // 
            this.gbxTarifCategorieType.Location = new System.Drawing.Point(268, 44);
            this.gbxTarifCategorieType.Name = "gbxTarifCategorieType";
            this.gbxTarifCategorieType.Size = new System.Drawing.Size(200, 300);
            this.gbxTarifCategorieType.TabIndex = 6;
            this.gbxTarifCategorieType.TabStop = false;
            this.gbxTarifCategorieType.Text = "Tarifs par Categorie-Type";
            this.gbxTarifCategorieType.Enter += new System.EventHandler(this.gbxTarifCategorieType_Enter);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(118, 280);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 7;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterTarifer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbxTarifCategorieType);
            this.Controls.Add(this.cmbPeriode);
            this.Controls.Add(this.lblPeriode);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormAjouterTarifer";
            this.Text = "FormAjouterTarifer";
            this.Load += new System.EventHandler(this.FormAjouterTarifer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblPeriode;
        private System.Windows.Forms.ComboBox cmbPeriode;
        private System.Windows.Forms.GroupBox gbxTarifCategorieType;
        private System.Windows.Forms.Button btnAjouter;
    }
}