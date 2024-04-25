namespace ProiectNeagoeRares
{
    partial class FormPlatformaJocuri
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
            this.dataGridViewPlatformaJocuri = new System.Windows.Forms.DataGridView();
            this.bSalvare = new System.Windows.Forms.Button();
            this.bAnulare = new System.Windows.Forms.Button();
            this.cbPlatforme = new System.Windows.Forms.ComboBox();
            this.tbNrJocuri = new System.Windows.Forms.TextBox();
            this.bNrJocuri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatformaJocuri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlatformaJocuri
            // 
            this.dataGridViewPlatformaJocuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlatformaJocuri.Location = new System.Drawing.Point(31, 120);
            this.dataGridViewPlatformaJocuri.Name = "dataGridViewPlatformaJocuri";
            this.dataGridViewPlatformaJocuri.Size = new System.Drawing.Size(456, 262);
            this.dataGridViewPlatformaJocuri.TabIndex = 0;
            // 
            // bSalvare
            // 
            this.bSalvare.Location = new System.Drawing.Point(610, 148);
            this.bSalvare.Name = "bSalvare";
            this.bSalvare.Size = new System.Drawing.Size(86, 40);
            this.bSalvare.TabIndex = 1;
            this.bSalvare.Text = "Salvare";
            this.bSalvare.UseVisualStyleBackColor = true;
            this.bSalvare.Click += new System.EventHandler(this.bSalvare_Click);
            // 
            // bAnulare
            // 
            this.bAnulare.Location = new System.Drawing.Point(610, 203);
            this.bAnulare.Name = "bAnulare";
            this.bAnulare.Size = new System.Drawing.Size(86, 39);
            this.bAnulare.TabIndex = 2;
            this.bAnulare.Text = "Anulare";
            this.bAnulare.UseVisualStyleBackColor = true;
            this.bAnulare.Click += new System.EventHandler(this.bAnulare_Click);
            // 
            // cbPlatforme
            // 
            this.cbPlatforme.FormattingEnabled = true;
            this.cbPlatforme.Items.AddRange(new object[] {
            "PC",
            "PlayStation 4",
            "Nintendo Switch",
            "Xbox One"});
            this.cbPlatforme.Location = new System.Drawing.Point(203, 42);
            this.cbPlatforme.Name = "cbPlatforme";
            this.cbPlatforme.Size = new System.Drawing.Size(121, 21);
            this.cbPlatforme.TabIndex = 3;
            // 
            // tbNrJocuri
            // 
            this.tbNrJocuri.Location = new System.Drawing.Point(371, 43);
            this.tbNrJocuri.Name = "tbNrJocuri";
            this.tbNrJocuri.Size = new System.Drawing.Size(100, 20);
            this.tbNrJocuri.TabIndex = 4;
            // 
            // bNrJocuri
            // 
            this.bNrJocuri.Location = new System.Drawing.Point(517, 30);
            this.bNrJocuri.Name = "bNrJocuri";
            this.bNrJocuri.Size = new System.Drawing.Size(100, 45);
            this.bNrJocuri.TabIndex = 5;
            this.bNrJocuri.Text = "Nr de jocuri";
            this.bNrJocuri.UseVisualStyleBackColor = true;
            this.bNrJocuri.Click += new System.EventHandler(this.bNrJocuri_Click);
            // 
            // FormPlatformaJocuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bNrJocuri);
            this.Controls.Add(this.tbNrJocuri);
            this.Controls.Add(this.cbPlatforme);
            this.Controls.Add(this.bAnulare);
            this.Controls.Add(this.bSalvare);
            this.Controls.Add(this.dataGridViewPlatformaJocuri);
            this.Name = "FormPlatformaJocuri";
            this.Text = "FormPlatformaJocuri";
            this.Load += new System.EventHandler(this.FormPlatformaJocuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlatformaJocuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlatformaJocuri;
        private System.Windows.Forms.Button bSalvare;
        private System.Windows.Forms.Button bAnulare;
        private System.Windows.Forms.ComboBox cbPlatforme;
        private System.Windows.Forms.TextBox tbNrJocuri;
        private System.Windows.Forms.Button bNrJocuri;
    }
}