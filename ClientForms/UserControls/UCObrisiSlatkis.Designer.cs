using System.Windows.Forms;

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
            this.gbNadjeni = new System.Windows.Forms.GroupBox();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.dgvNadjeniSlatkisi = new System.Windows.Forms.DataGridView();
            this.gbPretraga = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.gbNadjeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadjeniSlatkisi)).BeginInit();
            this.gbPretraga.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNadjeni
            // 
            this.gbNadjeni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNadjeni.Controls.Add(this.btnObrisi);
            this.gbNadjeni.Controls.Add(this.dgvNadjeniSlatkisi);
            this.gbNadjeni.Location = new System.Drawing.Point(142, 104);
            this.gbNadjeni.Name = "gbNadjeni";
            this.gbNadjeni.Size = new System.Drawing.Size(546, 298);
            this.gbNadjeni.TabIndex = 4;
            this.gbNadjeni.TabStop = false;
            this.gbNadjeni.Text = "Lista nađenih slatkiša";
            // 
            // btnObrisi
            // 
            this.btnObrisi.Location = new System.Drawing.Point(427, 248);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(91, 43);
            this.btnObrisi.TabIndex = 1;
            this.btnObrisi.Text = "Obriši izabrani";
            this.btnObrisi.UseVisualStyleBackColor = true;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
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
            this.dgvNadjeniSlatkisi.Size = new System.Drawing.Size(473, 209);
            this.dgvNadjeniSlatkisi.TabIndex = 0;
            // 
            // gbPretraga
            // 
            this.gbPretraga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbPretraga.Controls.Add(this.btnPretrazi);
            this.gbPretraga.Controls.Add(this.cmbProizvodjaci);
            this.gbPretraga.Location = new System.Drawing.Point(142, 24);
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
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
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
        private System.Windows.Forms.GroupBox gbNadjeni;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.DataGridView dgvNadjeniSlatkisi;
        private System.Windows.Forms.GroupBox gbPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ComboBox cmbProizvodjaci;

        public GroupBox GbNadjeni { get => gbNadjeni; set => gbNadjeni = value; }
        public Button BtnObrisi { get => btnObrisi; set => btnObrisi = value; }
        public DataGridView DgvNadjeniSlatkisi { get => dgvNadjeniSlatkisi; set => dgvNadjeniSlatkisi = value; }
        public GroupBox GbPretraga { get => gbPretraga; set => gbPretraga = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public ComboBox CmbProizvodjaci { get => cmbProizvodjaci; set => cmbProizvodjaci = value; }
    }
}
