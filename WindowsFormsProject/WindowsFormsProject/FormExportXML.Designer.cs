namespace ProiectNeagoeRares
{
    partial class FormExportXML
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
            this.dataGridViewExport = new System.Windows.Forms.DataGridView();
            this.bExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewExport
            // 
            this.dataGridViewExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewExport.Location = new System.Drawing.Point(63, 117);
            this.dataGridViewExport.Name = "dataGridViewExport";
            this.dataGridViewExport.Size = new System.Drawing.Size(416, 220);
            this.dataGridViewExport.TabIndex = 0;
            // 
            // bExport
            // 
            this.bExport.Location = new System.Drawing.Point(603, 167);
            this.bExport.Name = "bExport";
            this.bExport.Size = new System.Drawing.Size(96, 65);
            this.bExport.TabIndex = 1;
            this.bExport.Text = "Export XML";
            this.bExport.UseVisualStyleBackColor = true;
            this.bExport.Click += new System.EventHandler(this.bExport_Click);
            // 
            // FormExportXML
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bExport);
            this.Controls.Add(this.dataGridViewExport);
            this.Name = "FormExportXML";
            this.Text = "FormExportXML";
            this.Load += new System.EventHandler(this.FormExportXML_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewExport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewExport;
        private System.Windows.Forms.Button bExport;
    }
}