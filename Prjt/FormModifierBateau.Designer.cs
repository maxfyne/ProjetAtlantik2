namespace Prjt
{
    partial class FormModifierBateau
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
            this.cmbNomBateau = new System.Windows.Forms.ComboBox();
            this.gbxCapacitésMaximales = new System.Windows.Forms.GroupBox();
            this.btnModifier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNomBateau
            // 
            this.lblNomBateau.AutoSize = true;
            this.lblNomBateau.Location = new System.Drawing.Point(163, 104);
            this.lblNomBateau.Name = "lblNomBateau";
            this.lblNomBateau.Size = new System.Drawing.Size(72, 13);
            this.lblNomBateau.TabIndex = 0;
            this.lblNomBateau.Text = "Nom Bateau :";
            // 
            // cmbNomBateau
            // 
            this.cmbNomBateau.FormattingEnabled = true;
            this.cmbNomBateau.Location = new System.Drawing.Point(241, 104);
            this.cmbNomBateau.Name = "cmbNomBateau";
            this.cmbNomBateau.Size = new System.Drawing.Size(121, 21);
            this.cmbNomBateau.TabIndex = 1;
            this.cmbNomBateau.SelectedIndexChanged += new System.EventHandler(this.cmbNomBateau_SelectedIndexChanged);
            // 
            // gbxCapacitésMaximales
            // 
            this.gbxCapacitésMaximales.Location = new System.Drawing.Point(400, 104);
            this.gbxCapacitésMaximales.Name = "gbxCapacitésMaximales";
            this.gbxCapacitésMaximales.Size = new System.Drawing.Size(200, 100);
            this.gbxCapacitésMaximales.TabIndex = 2;
            this.gbxCapacitésMaximales.TabStop = false;
            this.gbxCapacitésMaximales.Text = "Capcaités Maximales";
            this.gbxCapacitésMaximales.Enter += new System.EventHandler(this.gbxCapacitésMaximales_Enter);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(629, 104);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(75, 23);
            this.btnModifier.TabIndex = 3;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // FormModifierBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.gbxCapacitésMaximales);
            this.Controls.Add(this.cmbNomBateau);
            this.Controls.Add(this.lblNomBateau);
            this.Name = "FormModifierBateau";
            this.Text = "FormModifierBateau";
            this.Load += new System.EventHandler(this.FormModifierBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomBateau;
        private System.Windows.Forms.ComboBox cmbNomBateau;
        private System.Windows.Forms.GroupBox gbxCapacitésMaximales;
        private System.Windows.Forms.Button btnModifier;
    }
}