namespace ProiectNeagoeRares
{
    partial class FormVizualizareDocumenteXML
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
            this.dataGridViewVizualizare = new System.Windows.Forms.DataGridView();
            this.cbXML = new System.Windows.Forms.ComboBox();
            this.bImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVizualizare)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVizualizare
            // 
            this.dataGridViewVizualizare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVizualizare.Location = new System.Drawing.Point(42, 125);
            this.dataGridViewVizualizare.Name = "dataGridViewVizualizare";
            this.dataGridViewVizualizare.Size = new System.Drawing.Size(409, 234);
            this.dataGridViewVizualizare.TabIndex = 0;
            // 
            // cbXML
            // 
            this.cbXML.FormattingEnabled = true;
            this.cbXML.Location = new System.Drawing.Point(108, 48);
            this.cbXML.Name = "cbXML";
            this.cbXML.Size = new System.Drawing.Size(121, 21);
            this.cbXML.TabIndex = 1;
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(574, 48);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(98, 39);
            this.bImport.TabIndex = 2;
            this.bImport.Text = "Import XML";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // FormVizualizareDocumenteXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bImport);
            this.Controls.Add(this.cbXML);
            this.Controls.Add(this.dataGridViewVizualizare);
            this.Name = "FormVizualizareDocumenteXML";
            this.Text = "FormVizualizareDocumenteXML";
            this.Load += new System.EventHandler(this.FormVizualizareDocumenteXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVizualizare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVizualizare;
        private System.Windows.Forms.ComboBox cbXML;
        private System.Windows.Forms.Button bImport;
    }
}