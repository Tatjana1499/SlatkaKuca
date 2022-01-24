namespace ClientForms.UserControls
{
    partial class UCDodajSlatkis
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisiRed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(54, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(708, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(96, 369);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(124, 46);
            this.btnDodaj.TabIndex = 1;
            this.btnDodaj.Text = "Dodaj sve";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // btnIzbrisiRed
            // 
            this.btnIzbrisiRed.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIzbrisiRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIzbrisiRed.Location = new System.Drawing.Point(592, 369);
            this.btnIzbrisiRed.Name = "btnIzbrisiRed";
            this.btnIzbrisiRed.Size = new System.Drawing.Size(124, 46);
            this.btnIzbrisiRed.TabIndex = 2;
            this.btnIzbrisiRed.Text = "Izbriši red";
            this.btnIzbrisiRed.UseVisualStyleBackColor = true;
            // 
            // UCDodajSlatkis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzbrisiRed);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UCDodajSlatkis";
            this.Size = new System.Drawing.Size(842, 466);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisiRed;
    }
}
