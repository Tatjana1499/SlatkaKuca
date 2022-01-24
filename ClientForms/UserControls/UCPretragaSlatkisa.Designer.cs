namespace ClientForms.UserControls
{
    partial class UCPretragaSlatkisa
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
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.gbNadjeni = new System.Windows.Forms.GroupBox();
            this.gbOdabraniSlatkis = new System.Windows.Forms.GroupBox();
            this.cmbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvNadjeniSlatkisi = new System.Windows.Forms.DataGridView();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.gbPretraga.SuspendLayout();
            this.gbNadjeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadjeniSlatkisi)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPretraga
            // 
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.cmbProizvodjaci);
            this.gbPretraga.Location = new System.Drawing.Point(107, 30);
            this.gbPretraga.Name = "gbPretraga";
            this.gbPretraga.Size = new System.Drawing.Size(546, 64);
            this.gbPretraga.TabIndex = 0;
            this.gbPretraga.TabStop = false;
            this.gbPretraga.Text = "Pretraži po proizvođaču";
            // 
            // gbNadjeni
            // 
            this.gbNadjeni.Controls.Add(this.btnIzaberi);
            this.gbNadjeni.Controls.Add(this.dgvNadjeniSlatkisi);
            this.gbNadjeni.Location = new System.Drawing.Point(107, 110);
            this.gbNadjeni.Name = "gbNadjeni";
            this.gbNadjeni.Size = new System.Drawing.Size(261, 298);
            this.gbNadjeni.TabIndex = 1;
            this.gbNadjeni.TabStop = false;
            this.gbNadjeni.Text = "Lista nađenih slatkiša";
            // 
            // gbOdabraniSlatkis
            // 
            this.gbOdabraniSlatkis.Location = new System.Drawing.Point(379, 110);
            this.gbOdabraniSlatkis.Name = "gbOdabraniSlatkis";
            this.gbOdabraniSlatkis.Size = new System.Drawing.Size(274, 298);
            this.gbOdabraniSlatkis.TabIndex = 2;
            this.gbOdabraniSlatkis.TabStop = false;
            this.gbOdabraniSlatkis.Text = "Odabrani slatkiš";
            // 
            // cmbProizvodjaci
            // 
            this.cmbProizvodjaci.FormattingEnabled = true;
            this.cmbProizvodjaci.Location = new System.Drawing.Point(171, 17);
            this.cmbProizvodjaci.Name = "cmbProizvodjaci";
            this.cmbProizvodjaci.Size = new System.Drawing.Size(226, 24);
            this.cmbProizvodjaci.TabIndex = 0;
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
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(156, 248);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(91, 43);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            // 
            // UCPretragaSlatkisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbOdabraniSlatkis);
            this.Controls.Add(this.gbNadjeni);
            this.Controls.Add(this.gbPretraga);
            this.Name = "UCPretragaSlatkisa";
            this.Size = new System.Drawing.Size(833, 425);
            this.gbPretraga.ResumeLayout(false);
            this.gbNadjeni.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadjeniSlatkisi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.GroupBox gbNadjeni;
        private System.Windows.Forms.GroupBox gbOdabraniSlatkis;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ComboBox cmbProizvodjaci;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgvNadjeniSlatkisi;
    }
}
