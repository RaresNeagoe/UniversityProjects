namespace ProiectNeagoeRares
{
    partial class FormPlatforme
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
            this.dataGridViewPlatforme = new System.Windows.Forms.DataGridView();
            this.bSalvare = new System.Windows.Forms.Button();
            this.bAnulare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatforme)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlatforme
            // 
            this.dataGridViewPlatforme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatforme.Location = new System.Drawing.Point(96, 141);
            this.dataGridViewPlatforme.Name = "dataGridViewPlatforme";
            this.dataGridViewPlatforme.Size = new System.Drawing.Size(354, 196);
            this.dataGridViewPlatforme.TabIndex = 0;
            // 
            // bSalvare
            // 
            this.bSalvare.Location = new System.Drawing.Point(620, 162);
            this.bSalvare.Name = "bSalvare";
            this.bSalvare.Size = new System.Drawing.Size(90, 37);
            this.bSalvare.TabIndex = 1;
            this.bSalvare.Text = "Salvare";
            this.bSalvare.UseVisualStyleBackColor = true;
            this.bSalvare.Click += new System.EventHandler(this.bSalvare_Click);
            // 
            // bAnulare
            // 
            this.bAnulare.Location = new System.Drawing.Point(620, 217);
            this.bAnulare.Name = "bAnulare";
            this.bAnulare.Size = new System.Drawing.Size(90, 38);
            this.bAnulare.TabIndex = 2;
            this.bAnulare.Text = "Anulare";
            this.bAnulare.UseVisualStyleBackColor = true;
            this.bAnulare.Click += new System.EventHandler(this.bAnulare_Click);
            // 
            // FormPlatforme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAnulare);
            this.Controls.Add(this.bSalvare);
            this.Controls.Add(this.dataGridViewPlatforme);
            this.Name = "FormPlatforme";
            this.Text = "FormPlatforme";
            this.Load += new System.EventHandler(this.FormPlatforme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatforme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlatforme;
        private System.Windows.Forms.Button bSalvare;
        private System.Windows.Forms.Button bAnulare;
    }
}