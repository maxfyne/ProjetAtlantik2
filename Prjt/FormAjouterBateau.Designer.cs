namespace Prjt
{
    partial class FormAjouterBateau
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
            this.lblNomBateau = new System.Windows.Forms.Label();
            this.tbxNomBateau = new System.Windows.Forms.TextBox();
            this.gbxCapacitésMaximales = new System.Windows.Forms.GroupBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(201, 68);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(74, 13);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom bateau : ";
            // 
            // tbxNomBateau
            // 
            this.tbxNomBateau.Location = new System.Drawing.Point(281, 68);
            this.tbxNomBateau.Name = "tbxNomBateau";
            this.tbxNomBateau.Size = new System.Drawing.Size(100, 20);
            this.tbxNomBateau.TabIndex = 1;
            // 
            // gbxCapacitésMaximales
            // 
            this.gbxCapacitésMaximales.Location = new System.Drawing.Point(410, 68);
            this.gbxCapacitésMaximales.Name = "gbxCapacitésMaximales";
            this.gbxCapacitésMaximales.Size = new System.Drawing.Size(200, 100);
            this.gbxCapacitésMaximales.TabIndex = 2;
            this.gbxCapacitésMaximales.TabStop = false;
            this.gbxCapacitésMaximales.Text = "Capacités Maximales";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(204, 145);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // FormAjouterBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.gbxCapacitésMaximales);
            this.Controls.Add(this.tbxNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "FormAjouterBateau";
            this.Text = "AjouterBateau";
            this.Load += new System.EventHandler(this.AjouterBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.TextBox tbxNomBateau;
        private System.Windows.Forms.GroupBox gbxCapacitésMaximales;
        private System.Windows.Forms.Button btnAjouter;
    }
}