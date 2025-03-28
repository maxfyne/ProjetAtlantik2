namespace Prjt
{
    partial class FormAjouterUnPort
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lblNomPort = new System.Windows.Forms.Label();
            this.tbxNomPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(337, 251);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lblNomPort
            // 
            this.lblNomPort.AutoSize = true;
            this.lblNomPort.Location = new System.Drawing.Point(258, 216);
            this.lblNomPort.Name = "lblNomPort";
            this.lblNomPort.Size = new System.Drawing.Size(59, 13);
            this.lblNomPort.TabIndex = 1;
            this.lblNomPort.Text = "Nom port : ";
            this.lblNomPort.Click += new System.EventHandler(this.lblNomPort_Click);
            // 
            // tbxNomPort
            // 
            this.tbxNomPort.Location = new System.Drawing.Point(337, 216);
            this.tbxNomPort.Name = "tbxNomPort";
            this.tbxNomPort.Size = new System.Drawing.Size(100, 20);
            this.tbxNomPort.TabIndex = 2;
            this.tbxNomPort.TextChanged += new System.EventHandler(this.tbxNomPort_TextChanged);
            // 
            // FormAjouterUnPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbxNomPort);
            this.Controls.Add(this.lblNomPort);
            this.Controls.Add(this.btnAjouter);
            this.Name = "FormAjouterUnPort";
            this.Text = "FormAjouterUnPort";
            this.Load += new System.EventHandler(this.FormAjouterUnPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Label lblNomPort;
        private System.Windows.Forms.TextBox tbxNomPort;
    }
}