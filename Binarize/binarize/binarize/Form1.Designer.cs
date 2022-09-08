namespace binarize
{
    partial class Form1
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
            this.fileSelect = new System.Windows.Forms.Button();
            this.binarize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fileSelect
            // 
            this.fileSelect.Location = new System.Drawing.Point(115, 60);
            this.fileSelect.Name = "fileSelect";
            this.fileSelect.Size = new System.Drawing.Size(75, 23);
            this.fileSelect.TabIndex = 0;
            this.fileSelect.Text = "Select file";
            this.fileSelect.UseVisualStyleBackColor = true;
            this.fileSelect.Click += new System.EventHandler(this.fileSelect_Click);
            // 
            // binarize
            // 
            this.binarize.Location = new System.Drawing.Point(115, 89);
            this.binarize.Name = "binarize";
            this.binarize.Size = new System.Drawing.Size(75, 23);
            this.binarize.TabIndex = 1;
            this.binarize.Text = "Binarize!";
            this.binarize.UseVisualStyleBackColor = true;
            this.binarize.Click += new System.EventHandler(this.binarize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.binarize);
            this.Controls.Add(this.fileSelect);
            this.Name = "Form1";
            this.Text = "Binarizer - Convert files to binary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button fileSelect;
        private System.Windows.Forms.Button binarize;
    }
}

