namespace ProiectNeagoeRares
{
    partial class FormJocuriJucatori
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
            this.dataGridViewJocuriJucatori = new System.Windows.Forms.DataGridView();
            this.bSalvare = new System.Windows.Forms.Button();
            this.bAnulare = new System.Windows.Forms.Button();
            this.cbJocuri = new System.Windows.Forms.ComboBox();
            this.tbNrJucatori = new System.Windows.Forms.TextBox();
            this.bNrJucatori = new System.Windows.Forms.Button();
            this.bCost = new System.Windows.Forms.Button();
            this.tbCost = new System.Windows.Forms.TextBox();
            this.cbJucator = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJocuriJucatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJocuriJucatori
            // 
            this.dataGridViewJocuriJucatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJocuriJucatori.Location = new System.Drawing.Point(75, 99);
            this.dataGridViewJocuriJucatori.Name = "dataGridViewJocuriJucatori";
            this.dataGridViewJocuriJucatori.Size = new System.Drawing.Size(457, 305);
            this.dataGridViewJocuriJucatori.TabIndex = 0;
            // 
            // bSalvare
            // 
            this.bSalvare.Location = new System.Drawing.Point(642, 133);
            this.bSalvare.Name = "bSalvare";
            this.bSalvare.Size = new System.Drawing.Size(87, 38);
            this.bSalvare.TabIndex = 1;
            this.bSalvare.Text = "Salvare";
            this.bSalvare.UseVisualStyleBackColor = true;
            this.bSalvare.Click += new System.EventHandler(this.bSalvare_Click);
            // 
            // bAnulare
            // 
            this.bAnulare.Location = new System.Drawing.Point(642, 200);
            this.bAnulare.Name = "bAnulare";
            this.bAnulare.Size = new System.Drawing.Size(87, 44);
            this.bAnulare.TabIndex = 2;
            this.bAnulare.Text = "Anulare";
            this.bAnulare.UseVisualStyleBackColor = true;
            this.bAnulare.Click += new System.EventHandler(this.bAnulare_Click);
            // 
            // cbJocuri
            // 
            this.cbJocuri.FormattingEnabled = true;
            this.cbJocuri.Items.AddRange(new object[] {
            "Grand Theft Auto V",
            "The Witcher 3: Wild Hunt",
            "The Legend of Zelda: Breath of the Wild",
            "Red Dead Redemption 2",
            "God of War",
            "Horizon Zero Dawn",
            "Assassins Creed Odyssey",
            "Death Stranding",
            "Cyberpunk 2077",
            "The Last of Us Part II"});
            this.cbJocuri.Location = new System.Drawing.Point(372, 25);
            this.cbJocuri.Name = "cbJocuri";
            this.cbJocuri.Size = new System.Drawing.Size(121, 21);
            this.cbJocuri.TabIndex = 3;
            // 
            // tbNrJucatori
            // 
            this.tbNrJucatori.Location = new System.Drawing.Point(512, 25);
            this.tbNrJucatori.Name = "tbNrJucatori";
            this.tbNrJucatori.Size = new System.Drawing.Size(100, 20);
            this.tbNrJucatori.TabIndex = 4;
            // 
            // bNrJucatori
            // 
            this.bNrJucatori.Location = new System.Drawing.Point(631, 11);
            this.bNrJucatori.Name = "bNrJucatori";
            this.bNrJucatori.Size = new System.Drawing.Size(98, 46);
            this.bNrJucatori.TabIndex = 5;
            this.bNrJucatori.Text = "Nr de jucatori";
            this.bNrJucatori.UseVisualStyleBackColor = true;
            this.bNrJucatori.Click += new System.EventHandler(this.bNrJucatori_Click);
            // 
            // bCost
            // 
            this.bCost.Location = new System.Drawing.Point(256, 17);
            this.bCost.Name = "bCost";
            this.bCost.Size = new System.Drawing.Size(97, 35);
            this.bCost.TabIndex = 6;
            this.bCost.Text = "Cost total";
            this.bCost.UseVisualStyleBackColor = true;
            this.bCost.Click += new System.EventHandler(this.bCost_Click);
            // 
            // tbCost
            // 
            this.tbCost.Location = new System.Drawing.Point(139, 25);
            this.tbCost.Name = "tbCost";
            this.tbCost.Size = new System.Drawing.Size(100, 20);
            this.tbCost.TabIndex = 7;
            // 
            // cbJucator
            // 
            this.cbJucator.FormattingEnabled = true;
            this.cbJucator.Items.AddRange(new object[] {
            "Mihaescu Marius",
            "Neagoe Radu",
            "Popescu Mihai",
            "Negoita Andrei",
            "Raducanu Maria",
            "Nicolescu Cristina"});
            this.cbJucator.Location = new System.Drawing.Point(12, 25);
            this.cbJucator.Name = "cbJucator";
            this.cbJucator.Size = new System.Drawing.Size(121, 21);
            this.cbJucator.TabIndex = 8;
            // 
            // FormJocuriJucatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbJucator);
            this.Controls.Add(this.tbCost);
            this.Controls.Add(this.bCost);
            this.Controls.Add(this.bNrJucatori);
            this.Controls.Add(this.tbNrJucatori);
            this.Controls.Add(this.cbJocuri);
            this.Controls.Add(this.bAnulare);
            this.Controls.Add(this.bSalvare);
            this.Controls.Add(this.dataGridViewJocuriJucatori);
            this.Name = "FormJocuriJucatori";
            this.Text = "FormJocuriJucatori";
            this.Load += new System.EventHandler(this.FormJocuriJucatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJocuriJucatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJocuriJucatori;
        private System.Windows.Forms.Button bSalvare;
        private System.Windows.Forms.Button bAnulare;
        private System.Windows.Forms.ComboBox cbJocuri;
        private System.Windows.Forms.TextBox tbNrJucatori;
        private System.Windows.Forms.Button bNrJucatori;
        private System.Windows.Forms.Button bCost;
        private System.Windows.Forms.TextBox tbCost;
        private System.Windows.Forms.ComboBox cbJucator;
    }
}