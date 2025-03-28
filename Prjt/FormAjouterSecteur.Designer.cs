namespace Prjt
{
    partial class FormAjouterSecteur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblNomSecteur = new System.Windows.Forms.Label();
            this.tbxNomSecteur = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(351, 221);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblNomSecteur
            // 
            this.lblNomSecteur.AutoSize = true;
            this.lblNomSecteur.Location = new System.Drawing.Point(261, 195);
            this.lblNomSecteur.Name = "lblNomSecteur";
            this.lblNomSecteur.Size = new System.Drawing.Size(73, 13);
            this.lblNomSecteur.TabIndex = 1;
            this.lblNomSecteur.Text = "Nom secteur :";
            this.lblNomSecteur.Click += new System.EventHandler(this.lblNomSecteur_Click);
            // 
            // tbxNomSecteur
            // 
            this.tbxNomSecteur.Location = new System.Drawing.Point(351, 195);
            this.tbxNomSecteur.Name = "tbxNomSecteur";
            this.tbxNomSecteur.Size = new System.Drawing.Size(100, 20);
            this.tbxNomSecteur.TabIndex = 2;
            this.tbxNomSecteur.TextChanged += new System.EventHandler(this.tbxNomSecteur_TextChanged);
            // 
            // FormAjouterSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxNomSecteur);
            this.Controls.Add(this.lblNomSecteur);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FormAjouterSecteur";
            this.Text = "FormAjouterSecteur";
            this.Load += new System.EventHandler(this.FormAjouterSecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNomSecteur;
        private System.Windows.Forms.TextBox tbxNomSecteur;
    }
}

