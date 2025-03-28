namespace Prjt
{
    partial class FormAjouterTraversee
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
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.cmbNomBateau = new System.Windows.Forms.ComboBox();
            this.lblLiaison = new System.Windows.Forms.Label();
            this.cmbLiaison = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblDateEtHeureDépart = new System.Windows.Forms.Label();
            this.lblDateEtHeureArrivée = new System.Windows.Forms.Label();
            this.dateTimePickerDépart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerArrivée = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(37, 55);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(98, 55);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteurs.TabIndex = 1;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(285, 55);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(71, 13);
            this.lblNomBateau.TabIndex = 2;
            this.lblNomBateau.Text = "Nom bateau :";
            // 
            // cmbNomBateau
            // 
            this.cmbNomBateau.FormattingEnabled = true;
            this.cmbNomBateau.Location = new System.Drawing.Point(362, 55);
            this.cmbNomBateau.Name = "cmbNomBateau";
            this.cmbNomBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbNomBateau.TabIndex = 3;
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(37, 197);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 4;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(98, 197);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(40, 276);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblDateEtHeureDépart
            // 
            this.lblDateEtHeureDépart.AutoSize = true;
            this.lblDateEtHeureDépart.Location = new System.Drawing.Point(285, 197);
            this.lblDateEtHeureDépart.Name = "lblDateEtHeureDépart";
            this.lblDateEtHeureDépart.Size = new System.Drawing.Size(111, 13);
            this.lblDateEtHeureDépart.TabIndex = 7;
            this.lblDateEtHeureDépart.Text = "Date et heure départ :";
            // 
            // lblDateEtHeureArrivée
            // 
            this.lblDateEtHeureArrivée.AutoSize = true;
            this.lblDateEtHeureArrivée.Location = new System.Drawing.Point(285, 232);
            this.lblDateEtHeureArrivée.Name = "lblDateEtHeureArrivée";
            this.lblDateEtHeureArrivée.Size = new System.Drawing.Size(113, 13);
            this.lblDateEtHeureArrivée.TabIndex = 8;
            this.lblDateEtHeureArrivée.Text = "Date et heure arrivée :";
            // 
            // dateTimePickerDépart
            // 
            this.dateTimePickerDépart.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePickerDépart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDépart.Location = new System.Drawing.Point(423, 191);
            this.dateTimePickerDépart.Name = "dateTimePickerDépart";
            this.dateTimePickerDépart.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDépart.TabIndex = 9;
            // 
            // dateTimePickerArrivée
            // 
            this.dateTimePickerArrivée.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePickerArrivée.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerArrivée.Location = new System.Drawing.Point(423, 226);
            this.dateTimePickerArrivée.Name = "dateTimePickerArrivée";
            this.dateTimePickerArrivée.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerArrivée.TabIndex = 10;
            // 
            // FormAjouterTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerArrivée);
            this.Controls.Add(this.dateTimePickerDépart);
            this.Controls.Add(this.lblDateEtHeureArrivée);
            this.Controls.Add(this.lblDateEtHeureDépart);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.cmbNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormAjouterTraversee";
            this.Text = "FormAjouterTraversee";
            this.Load += new System.EventHandler(this.FormAjouterTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cmbNomBateau;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblDateEtHeureDépart;
        private System.Windows.Forms.Label lblDateEtHeureArrivée;
        private System.Windows.Forms.DateTimePicker dateTimePickerDépart;
        private System.Windows.Forms.DateTimePicker dateTimePickerArrivée;
    }
}