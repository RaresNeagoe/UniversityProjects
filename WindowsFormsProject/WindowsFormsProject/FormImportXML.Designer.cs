namespace ProiectNeagoeRares
{
    partial class FormImportXML
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
            this.bImport = new System.Windows.Forms.Button();
            this.dataGridViewImport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).BeginInit();
            this.SuspendLayout();
            // 
            // bImport
            // 
            this.bImport.Location = new System.Drawing.Point(588, 164);
            this.bImport.Name = "bImport";
            this.bImport.Size = new System.Drawing.Size(104, 51);
            this.bImport.TabIndex = 0;
            this.bImport.Text = "Import XML";
            this.bImport.UseVisualStyleBackColor = true;
            this.bImport.Click += new System.EventHandler(this.bImport_Click);
            // 
            // dataGridViewImport
            // 
            this.dataGridViewImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImport.Location = new System.Drawing.Point(69, 139);
            this.dataGridViewImport.Name = "dataGridViewImport";
            this.dataGridViewImport.Size = new System.Drawing.Size(379, 195);
            this.dataGridViewImport.TabIndex = 1;
            // 
            // FormImportXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridViewImport);
            this.Controls.Add(this.bImport);
            this.Name = "FormImportXML";
            this.Text = "ImportXML";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bImport;
        private System.Windows.Forms.DataGridView dataGridViewImport;
    }
}