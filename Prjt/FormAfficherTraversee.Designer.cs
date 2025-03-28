namespace Prjt
{
    partial class FormAfficherTraversee
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lvTraversee = new System.Windows.Forms.ListView();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSecteurs
            // 
            this.lblSecteurs.AutoSize = true;
            this.lblSecteurs.Location = new System.Drawing.Point(34, 43);
            this.lblSecteurs.Name = "lblSecteurs";
            this.lblSecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblSecteurs.TabIndex = 0;
            this.lblSecteurs.Text = "Secteurs :";
            // 
            // lbxSecteurs
            // 
            this.lbxSecteurs.FormattingEnabled = true;
            this.lbxSecteurs.Location = new System.Drawing.Point(95, 43);
            this.lbxSecteurs.Name = "lbxSecteurs";
            this.lbxSecteurs.Size = new System.Drawing.Size(120, 95);
            this.lbxSecteurs.TabIndex = 1;
            this.lbxSecteurs.SelectedIndexChanged += new System.EventHandler(this.lbxSecteurs_SelectedIndexChanged);
            // 
            // lblLiaison
            // 
            this.lblLiaison.AutoSize = true;
            this.lblLiaison.Location = new System.Drawing.Point(237, 43);
            this.lblLiaison.Name = "lblLiaison";
            this.lblLiaison.Size = new System.Drawing.Size(46, 13);
            this.lblLiaison.TabIndex = 2;
            this.lblLiaison.Text = "Liaison :";
            // 
            // cmbLiaison
            // 
            this.cmbLiaison.FormattingEnabled = true;
            this.cmbLiaison.Location = new System.Drawing.Point(289, 43);
            this.cmbLiaison.Name = "cmbLiaison";
            this.cmbLiaison.Size = new System.Drawing.Size(121, 21);
            this.cmbLiaison.TabIndex = 3;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(439, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(152, 13);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date (par défaut date du jour) :";
            // 
            // lvTraversee
            // 
            this.lvTraversee.HideSelection = false;
            this.lvTraversee.Location = new System.Drawing.Point(289, 238);
            this.lvTraversee.Name = "lvTraversee";
            this.lvTraversee.Size = new System.Drawing.Size(121, 97);
            this.lvTraversee.TabIndex = 5;
            this.lvTraversee.UseCompatibleStateImageBehavior = false;
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "yyyy/MM/dd HH:mm";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(598, 43);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerDate.TabIndex = 6;
            // 
            // btnAfficher
            // 
            this.btnAfficher.Location = new System.Drawing.Point(289, 193);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(121, 23);
            this.btnAfficher.TabIndex = 7;
            this.btnAfficher.Text = "Afficher les traversées";
            this.btnAfficher.UseVisualStyleBackColor = true;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // FormAfficherTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.dateTimePickerDate);
            this.Controls.Add(this.lvTraversee);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbLiaison);
            this.Controls.Add(this.lblLiaison);
            this.Controls.Add(this.lbxSecteurs);
            this.Controls.Add(this.lblSecteurs);
            this.Name = "FormAfficherTraversee";
            this.Text = "FormAfficherTraversee";
            this.Load += new System.EventHandler(this.FormAfficherTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSecteurs;
        private System.Windows.Forms.ListBox lbxSecteurs;
        private System.Windows.Forms.Label lblLiaison;
        private System.Windows.Forms.ComboBox cmbLiaison;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListView lvTraversee;
        private System.Windows.Forms.DateTimePicker dateTimePickerDate;
        private System.Windows.Forms.Button btnAfficher;
    }
}