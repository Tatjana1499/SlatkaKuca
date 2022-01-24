namespace ClientForms.UserControls
{
    partial class UCObrisiSlatkis
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
            this.gbOdabraniSlatkis = new System.Windows.Forms.GroupBox();
            this.gbNadjeni = new System.Windows.Forms.GroupBox();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvNadjeniSlatkisi = new System.Windows.Forms.DataGridView();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.gbNadjeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadjeniSlatkisi)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbOdabraniSlatkis
            // 
            this.gbOdabraniSlatkis.Location = new System.Drawing.Point(505, 104);
            this.gbOdabraniSlatkis.Name = "gbOdabraniSlatkis";
            this.gbOdabraniSlatkis.Size = new System.Drawing.Size(274, 298);
            this.gbOdabraniSlatkis.TabIndex = 5;
            this.gbOdabraniSlatkis.TabStop = false;
            this.gbOdabraniSlatkis.Text = "Odabrani slatkiš";
            // 
            // gbNadjeni
            // 
            this.gbNadjeni.Controls.Add(this.btnIzaberi);
            this.gbNadjeni.Controls.Add(this.dgvNadjeniSlatkisi);
            this.gbNadjeni.Location = new System.Drawing.Point(233, 104);
            this.gbNadjeni.Name = "gbNadjeni";
            this.gbNadjeni.Size = new System.Drawing.Size(261, 298);
            this.gbNadjeni.TabIndex = 4;
            this.gbNadjeni.TabStop = false;
            this.gbNadjeni.Text = "Lista nađenih slatkiša";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(156, 248);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(91, 43);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            // 
            // dgvNadjeniSlatkisi
            // 
            this.dgvNadjeniSlatkisi.AllowUserToAddRows = false;
            this.dgvNadjeniSlatkisi.AllowUserToDeleteRows = false;
            this.dgvNadjeniSlatkisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNadjeniSlatkisi.Location = new System.Drawing.Point(7, 33);
            this.dgvNadjeniSlatkisi.Name = "dgvNadjeniSlatkisi";
            this.dgvNadjeniSlatkisi.ReadOnly = true;
            this.dgvNadjeniSlatkisi.RowHeadersWidth = 51;
            this.dgvNadjeniSlatkisi.RowTemplate.Height = 24;
            this.dgvNadjeniSlatkisi.Size = new System.Drawing.Size(240, 209);
            this.dgvNadjeniSlatkisi.TabIndex = 0;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.cmbProizvodjaci);
            this.gbPretraga.Location = new System.Drawing.Point(233, 24);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(546, 64);
            this.gbPretraga.TabIndex = 3;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraži po proizvođaču";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(423, 17);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(95, 41);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            // 
            // cmbProizvodjaci
            // 
            this.cmbProizvodjaci.FormattingEnabled = true;
            this.cmbProizvodjaci.Location = new System.Drawing.Point(171, 17);
            this.cmbProizvodjaci.Name = "cmbProizvodjaci";
            this.cmbProizvodjaci.Size = new System.Drawing.Size(226, 24);
            this.cmbProizvodjaci.TabIndex = 0;
            // 
            // UCObrisiSlatkis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOdabraniSlatkis);
            this.Controls.Add(this.gbNadjeni);
            this.Controls.Add(this.gbPretraga);
            this.Name = "UCObrisiSlatkis";
            this.Size = new System.Drawing.Size(1012, 427);
            this.gbNadjeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadjeniSlatkisi)).EndInit();
            this.gbPretraga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbOdabraniSlatkis;
        private System.Windows.Forms.GroupBox gbNadjeni;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgvNadjeniSlatkisi;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ComboBox cmbProizvodjaci;
    }
}
