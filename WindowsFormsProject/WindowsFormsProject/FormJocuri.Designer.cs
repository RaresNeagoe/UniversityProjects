namespace ProiectNeagoeRares
{
    partial class FormJocuri
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
            this.dataGridViewJocuri = new System.Windows.Forms.DataGridView();
            this.bSalvare = new System.Windows.Forms.Button();
            this.bAnulare = new System.Windows.Forms.Button();
            this.bFiltrare = new System.Windows.Forms.Button();
            this.cbCategorie = new System.Windows.Forms.ComboBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.tbValoare = new System.Windows.Forms.TextBox();
            this.bMedie = new System.Windows.Forms.Button();
            this.tbMedie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJocuri)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJocuri
            // 
            this.dataGridViewJocuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJocuri.Location = new System.Drawing.Point(12, 113);
            this.dataGridViewJocuri.Name = "dataGridViewJocuri";
            this.dataGridViewJocuri.Size = new System.Drawing.Size(776, 304);
            this.dataGridViewJocuri.TabIndex = 0;
            // 
            // bSalvare
            // 
            this.bSalvare.Location = new System.Drawing.Point(580, 36);
            this.bSalvare.Name = "bSalvare";
            this.bSalvare.Size = new System.Drawing.Size(101, 39);
            this.bSalvare.TabIndex = 1;
            this.bSalvare.Text = "Salvare";
            this.bSalvare.UseVisualStyleBackColor = true;
            this.bSalvare.Click += new System.EventHandler(this.bSalvare_Click);
            // 
            // bAnulare
            // 
            this.bAnulare.Location = new System.Drawing.Point(687, 33);
            this.bAnulare.Name = "bAnulare";
            this.bAnulare.Size = new System.Drawing.Size(101, 42);
            this.bAnulare.TabIndex = 2;
            this.bAnulare.Text = "Anulare";
            this.bAnulare.UseVisualStyleBackColor = true;
            this.bAnulare.Click += new System.EventHandler(this.bAnulare_Click);
            // 
            // bFiltrare
            // 
            this.bFiltrare.Location = new System.Drawing.Point(487, 36);
            this.bFiltrare.Name = "bFiltrare";
            this.bFiltrare.Size = new System.Drawing.Size(87, 39);
            this.bFiltrare.TabIndex = 3;
            this.bFiltrare.Text = "Filtrare";
            this.bFiltrare.UseVisualStyleBackColor = true;
            this.bFiltrare.Click += new System.EventHandler(this.bFiltrare_Click);
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.Items.AddRange(new object[] {
            "IDJoc",
            "DenumireJoc",
            "Pret",
            "DenumireDezvoltator",
            "DenumireDistribuitor",
            "AnLansare"});
            this.cbCategorie.Location = new System.Drawing.Point(12, 41);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(121, 21);
            this.cbCategorie.TabIndex = 4;
            // 
            // cbOperator
            // 
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "=",
            ">",
            "<"});
            this.cbOperator.Location = new System.Drawing.Point(139, 41);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(121, 21);
            this.cbOperator.TabIndex = 5;
            // 
            // tbValoare
            // 
            this.tbValoare.Location = new System.Drawing.Point(267, 41);
            this.tbValoare.Name = "tbValoare";
            this.tbValoare.Size = new System.Drawing.Size(100, 20);
            this.tbValoare.TabIndex = 6;
            // 
            // bMedie
            // 
            this.bMedie.Location = new System.Drawing.Point(139, 68);
            this.bMedie.Name = "bMedie";
            this.bMedie.Size = new System.Drawing.Size(121, 39);
            this.bMedie.TabIndex = 7;
            this.bMedie.Text = "Media preturilor";
            this.bMedie.UseVisualStyleBackColor = true;
            this.bMedie.Click += new System.EventHandler(this.bMedie_Click);
            // 
            // tbMedie
            // 
            this.tbMedie.Location = new System.Drawing.Point(267, 79);
            this.tbMedie.Name = "tbMedie";
            this.tbMedie.Size = new System.Drawing.Size(100, 20);
            this.tbMedie.TabIndex = 8;
            // 
            // FormJocuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMedie);
            this.Controls.Add(this.bMedie);
            this.Controls.Add(this.tbValoare);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.bFiltrare);
            this.Controls.Add(this.bAnulare);
            this.Controls.Add(this.bSalvare);
            this.Controls.Add(this.dataGridViewJocuri);
            this.Name = "FormJocuri";
            this.Text = "FormJocuri";
            this.Load += new System.EventHandler(this.FormJocuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJocuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJocuri;
        private System.Windows.Forms.Button bSalvare;
        private System.Windows.Forms.Button bAnulare;
        private System.Windows.Forms.Button bFiltrare;
        private System.Windows.Forms.ComboBox cbCategorie;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox tbValoare;
        private System.Windows.Forms.Button bMedie;
        private System.Windows.Forms.TextBox tbMedie;
    }
}