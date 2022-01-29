using System.Windows.Forms;

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
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.gbNadjeni = new System.Windows.Forms.GroupBox();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvNadjeniSlatkisi = new System.Windows.Forms.DataGridView();
            this.gbOdabraniSlatkis = new System.Windows.Forms.GroupBox();
            this.txtProizvodjac = new System.Windows.Forms.TextBox();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.SlatkisID = new System.Windows.Forms.Label();
            this.gbPretraga.SuspendLayout();
            this.gbNadjeni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNadjeniSlatkisi)).BeginInit();
            this.gbOdabraniSlatkis.SuspendLayout();
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
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(156, 248);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(91, 43);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
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
            this.dgvNadjeniSlatkisi.Size = new System.Drawing.Size(204, 209);
            this.dgvNadjeniSlatkisi.TabIndex = 0;
            // 
            // gbOdabraniSlatkis
            // 
            this.gbOdabraniSlatkis.Controls.Add(this.txtProizvodjac);
            this.gbOdabraniSlatkis.Controls.Add(this.lblProizvodjac);
            this.gbOdabraniSlatkis.Controls.Add(this.txtNaziv);
            this.gbOdabraniSlatkis.Controls.Add(this.lblNaziv);
            this.gbOdabraniSlatkis.Controls.Add(this.txtID);
            this.gbOdabraniSlatkis.Controls.Add(this.SlatkisID);
            this.gbOdabraniSlatkis.Location = new System.Drawing.Point(379, 110);
            this.gbOdabraniSlatkis.Name = "gbOdabraniSlatkis";
            this.gbOdabraniSlatkis.Size = new System.Drawing.Size(274, 298);
            this.gbOdabraniSlatkis.TabIndex = 2;
            this.gbOdabraniSlatkis.TabStop = false;
            this.gbOdabraniSlatkis.Text = "Odabrani slatkiš";
            // 
            // txtProizvodjac
            // 
            this.txtProizvodjac.Location = new System.Drawing.Point(102, 216);
            this.txtProizvodjac.Name = "txtProizvodjac";
            this.txtProizvodjac.ReadOnly = true;
            this.txtProizvodjac.Size = new System.Drawing.Size(166, 22);
            this.txtProizvodjac.TabIndex = 5;
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(9, 223);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(81, 16);
            this.lblProizvodjac.TabIndex = 4;
            this.lblProizvodjac.Text = "Proizvođač: ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(102, 146);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.Size = new System.Drawing.Size(166, 22);
            this.txtNaziv.TabIndex = 3;
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(6, 146);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(47, 16);
            this.lblNaziv.TabIndex = 2;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(102, 73);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(166, 22);
            this.txtID.TabIndex = 1;
            // 
            // SlatkisID
            // 
            this.SlatkisID.AutoSize = true;
            this.SlatkisID.Location = new System.Drawing.Point(17, 79);
            this.SlatkisID.Name = "SlatkisID";
            this.SlatkisID.Size = new System.Drawing.Size(26, 16);
            this.SlatkisID.TabIndex = 0;
            this.SlatkisID.Text = "ID: ";
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
            this.gbOdabraniSlatkis.ResumeLayout(false);
            this.gbOdabraniSlatkis.PerformLayout();
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
        private TextBox txtProizvodjac;
        private Label lblProizvodjac;
        private TextBox txtNaziv;
        private Label lblNaziv;
        private TextBox txtID;
        private Label SlatkisID;

        public GroupBox GbPretraga { get => gbPretraga; set => gbPretraga = value; }
        public GroupBox GbNadjeni { get => gbNadjeni; set => gbNadjeni = value; }
        public GroupBox GbOdabraniSlatkis { get => gbOdabraniSlatkis; set => gbOdabraniSlatkis = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public ComboBox CmbProizvodjaci { get => cmbProizvodjaci; set => cmbProizvodjaci = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
        public DataGridView DgvNadjeniSlatkisi { get => dgvNadjeniSlatkisi; set => dgvNadjeniSlatkisi = value; }
        public TextBox TxtProizvodjac { get => txtProizvodjac; set => txtProizvodjac = value; }
        public Label LblProizvodjac { get => lblProizvodjac; set => lblProizvodjac = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public TextBox TxtID { get => txtID; set => txtID = value; }
        public Label SlatkisID1 { get => SlatkisID; set => SlatkisID = value; }
    }
}
