namespace I_Fill_You
{
    partial class MCQ_Filler
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
            this.Remplir = new System.Windows.Forms.Button();
            this.fichier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Remplir
            // 
            this.Remplir.Location = new System.Drawing.Point(53, 399);
            this.Remplir.Name = "Remplir";
            this.Remplir.Size = new System.Drawing.Size(75, 23);
            this.Remplir.TabIndex = 0;
            this.Remplir.Text = "Remplir";
            this.Remplir.UseVisualStyleBackColor = true;
            this.Remplir.Click += new System.EventHandler(this.button1_Click);
            // 
            // fichier
            // 
            this.fichier.Location = new System.Drawing.Point(100, 46);
            this.fichier.Name = "fichier";
            this.fichier.Size = new System.Drawing.Size(114, 23);
            this.fichier.TabIndex = 1;
            this.fichier.Text = "Choisir le fichier";
            this.fichier.UseVisualStyleBackColor = true;
            this.fichier.Click += new System.EventHandler(this.fichier_Click);
            // 
            // MCQ_Filler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 450);
            this.Controls.Add(this.fichier);
            this.Controls.Add(this.Remplir);
            this.Name = "MCQ_Filler";
            this.Text = "Remplisseur de QCM";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Remplir;
        private System.Windows.Forms.Button fichier;
    }
}

