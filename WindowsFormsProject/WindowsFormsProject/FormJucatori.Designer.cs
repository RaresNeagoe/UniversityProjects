namespace ProiectNeagoeRares
{
    partial class FormJucatori
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
            this.dataGridViewJucatori = new System.Windows.Forms.DataGridView();
            this.bSalvare = new System.Windows.Forms.Button();
            this.bAnulare = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJucatori)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewJucatori
            // 
            this.dataGridViewJucatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewJucatori.Location = new System.Drawing.Point(114, 93);
            this.dataGridViewJucatori.Name = "dataGridViewJucatori";
            this.dataGridViewJucatori.Size = new System.Drawing.Size(354, 204);
            this.dataGridViewJucatori.TabIndex = 0;
            // 
            // bSalvare
            // 
            this.bSalvare.Location = new System.Drawing.Point(640, 150);
            this.bSalvare.Name = "bSalvare";
            this.bSalvare.Size = new System.Drawing.Size(86, 40);
            this.bSalvare.TabIndex = 1;
            this.bSalvare.Text = "Salvare";
            this.bSalvare.UseVisualStyleBackColor = true;
            this.bSalvare.Click += new System.EventHandler(this.bSalvare_Click);
            // 
            // bAnulare
            // 
            this.bAnulare.Location = new System.Drawing.Point(640, 206);
            this.bAnulare.Name = "bAnulare";
            this.bAnulare.Size = new System.Drawing.Size(86, 35);
            this.bAnulare.TabIndex = 2;
            this.bAnulare.Text = "Anulare";
            this.bAnulare.UseVisualStyleBackColor = true;
            this.bAnulare.Click += new System.EventHandler(this.bAnulare_Click);
            // 
            // FormJucatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bAnulare);
            this.Controls.Add(this.bSalvare);
            this.Controls.Add(this.dataGridViewJucatori);
            this.Name = "FormJucatori";
            this.Text = "FormJucatori";
            this.Load += new System.EventHandler(this.FormJucatori_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewJucatori)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewJucatori;
        private System.Windows.Forms.Button bSalvare;
        private System.Windows.Forms.Button bAnulare;
    }
}