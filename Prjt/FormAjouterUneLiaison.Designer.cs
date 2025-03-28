namespace Prjt
{
    partial class FormAjouterUneLiaison
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
            this.lblDepart = new System.Windows.Forms.Label();
            this.lblArrivée = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.tbxDistance = new System.Windows.Forms.TextBox();
            this.lbxSecteurs = new System.Windows.Forms.ListBox();
            this.cmbDepart = new System.Windows.Forms.ComboBox();
            this.cmbArrivée = new System.Windows.Forms.ComboBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(12, 72);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lblDepart
            // 
            this.lblDepart.AutoSize = true;
            this.lblDepart.Location = new System.Drawing.Point(199, 72);
            this.lblDepart.Name = "lblDepart";
            this.lblDepart.Size = new System.Drawing.Size(45, 13);
            this.lblDepart.TabIndex = 1;
            this.lblDepart.Text = "Depart :";
            // 
            // lblArrivée
            // 
            this.lblArrivée.AutoSize = true;
            this.lblArrivée.Location = new System.Drawing.Point(382, 72);
            this.lblArrivée.Name = "lblArrivée";
            this.lblArrivée.Size = new System.Drawing.Size(46, 13);
            this.lblArrivée.TabIndex = 2;
            this.lblArrivée.Text = "Arrivée :";
            // 
            // lblDistance
            // 
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(591, 72);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(55, 13);
            this.lblDistance.TabIndex = 3;
            this.lblDistance.Text = "Distance :";
            // 
            // tbxDistance
            // 
            this.tbxDistance.Location = new System.Drawing.Point(675, 73);
            this.tbxDistance.Name = "tbxDistance";
            this.tbxDistance.Size = new System.Drawing.Size(100, 20);
            this.tbxDistance.TabIndex = 4;
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(73, 72);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteurs.TabIndex = 5;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // cmbDepart
            // 
            this.cmbDepart.FormattingEnabled = true;
            this.cmbDepart.Location = new System.Drawing.Point(250, 72);
            this.cmbDepart.Name = "cmbDepart";
            this.cmbDepart.Size = new System.Drawing.Size(121, 21);
            this.cmbDepart.TabIndex = 6;
            this.cmbDepart.SelectedIndexChanged += new System.EventHandler(this.cmbDepart_SelectedIndexChanged);
            // 
            // cmbArrivée
            // 
            this.cmbArrivée.FormattingEnabled = true;
            this.cmbArrivée.Location = new System.Drawing.Point(434, 72);
            this.cmbArrivée.Name = "cmbArrivée";
            this.cmbArrivée.Size = new System.Drawing.Size(121, 21);
            this.cmbArrivée.TabIndex = 7;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(675, 125);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterUneLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cmbArrivée);
            this.Controls.Add(this.cmbDepart);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.tbxDistance);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblArrivée);
            this.Controls.Add(this.lblDepart);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormAjouterUneLiaison";
            this.Text = "FormAjouterUneLiaison";
            this.Load += new System.EventHandler(this.FormAjouterUneLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.Label lblDepart;
        private System.Windows.Forms.Label lblArrivée;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.TextBox tbxDistance;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.ComboBox cmbDepart;
        private System.Windows.Forms.ComboBox cmbArrivée;
        private System.Windows.Forms.Button btnAjouter;
    }
}