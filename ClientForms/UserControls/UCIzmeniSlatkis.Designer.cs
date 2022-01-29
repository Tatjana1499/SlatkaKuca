using System.Windows.Forms;

namespace ClientForms.UserControls
{
    partial class UCIzmeniSlatkis
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
            this.gbProizvodjaci = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.gbNadjeniSlatkisi = new System.Windows.Forms.GroupBox();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvSlatkisi = new System.Windows.Forms.DataGridView();
            this.gbOdabraniSlatkis = new System.Windows.Forms.GroupBox();
            this.btnIzmeni = new System.Windows.Forms.Button();
            this.cmbProizvodjac = new System.Windows.Forms.ComboBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblProizvodjac = new System.Windows.Forms.Label();
            this.lblNaziv = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.gbProizvodjaci.SuspendLayout();
            this.gbNadjeniSlatkisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlatkisi)).BeginInit();
            this.gbOdabraniSlatkis.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProizvodjaci
            // 
            this.gbProizvodjaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProizvodjaci.Controls.Add(this.btnPretrazi);
            this.gbProizvodjaci.Controls.Add(this.cmbProizvodjaci);
            this.gbProizvodjaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProizvodjaci.Location = new System.Drawing.Point(40, 21);
            this.gbProizvodjaci.Name = "gbProizvodjaci";
            this.gbProizvodjaci.Size = new System.Drawing.Size(710, 55);
            this.gbProizvodjaci.TabIndex = 0;
            this.gbProizvodjaci.TabStop = false;
            this.gbProizvodjaci.Text = "Pretrazi po proizvođaču";
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.Location = new System.Drawing.Point(576, 15);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(92, 34);
            this.btnPretrazi.TabIndex = 1;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = true;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // cmbProizvodjaci
            // 
            this.cmbProizvodjaci.FormattingEnabled = true;
            this.cmbProizvodjaci.Location = new System.Drawing.Point(297, 19);
            this.cmbProizvodjaci.Name = "cmbProizvodjaci";
            this.cmbProizvodjaci.Size = new System.Drawing.Size(234, 28);
            this.cmbProizvodjaci.TabIndex = 0;
            // 
            // gbNadjeniSlatkisi
            // 
            this.gbNadjeniSlatkisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNadjeniSlatkisi.Controls.Add(this.btnIzaberi);
            this.gbNadjeniSlatkisi.Controls.Add(this.dgvSlatkisi);
            this.gbNadjeniSlatkisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNadjeniSlatkisi.Location = new System.Drawing.Point(40, 82);
            this.gbNadjeniSlatkisi.Name = "gbNadjeniSlatkisi";
            this.gbNadjeniSlatkisi.Size = new System.Drawing.Size(302, 331);
            this.gbNadjeniSlatkisi.TabIndex = 1;
            this.gbNadjeniSlatkisi.TabStop = false;
            this.gbNadjeniSlatkisi.Text = "Slatkiši odabranog proizvođača";
            // 
            // btnIzaberi
            // 
            this.btnIzaberi.Location = new System.Drawing.Point(6, 285);
            this.btnIzaberi.Name = "btnIzaberi";
            this.btnIzaberi.Size = new System.Drawing.Size(82, 40);
            this.btnIzaberi.TabIndex = 1;
            this.btnIzaberi.Text = "Izaberi";
            this.btnIzaberi.UseVisualStyleBackColor = true;
            this.btnIzaberi.Click += new System.EventHandler(this.btnIzaberi_Click);
            // 
            // dgvSlatkisi
            // 
            this.dgvSlatkisi.AllowUserToAddRows = false;
            this.dgvSlatkisi.AllowUserToDeleteRows = false;
            this.dgvSlatkisi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlatkisi.Location = new System.Drawing.Point(7, 37);
            this.dgvSlatkisi.Name = "dgvSlatkisi";
            this.dgvSlatkisi.ReadOnly = true;
            this.dgvSlatkisi.RowHeadersWidth = 51;
            this.dgvSlatkisi.RowTemplate.Height = 24;
            this.dgvSlatkisi.Size = new System.Drawing.Size(289, 228);
            this.dgvSlatkisi.TabIndex = 0;
            // 
            // gbOdabraniSlatkis
            // 
            this.gbOdabraniSlatkis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbOdabraniSlatkis.Controls.Add(this.btnIzmeni);
            this.gbOdabraniSlatkis.Controls.Add(this.cmbProizvodjac);
            this.gbOdabraniSlatkis.Controls.Add(this.txtNaziv);
            this.gbOdabraniSlatkis.Controls.Add(this.txtID);
            this.gbOdabraniSlatkis.Controls.Add(this.lblProizvodjac);
            this.gbOdabraniSlatkis.Controls.Add(this.lblNaziv);
            this.gbOdabraniSlatkis.Controls.Add(this.lblID);
            this.gbOdabraniSlatkis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOdabraniSlatkis.Location = new System.Drawing.Point(348, 82);
            this.gbOdabraniSlatkis.Name = "gbOdabraniSlatkis";
            this.gbOdabraniSlatkis.Size = new System.Drawing.Size(402, 331);
            this.gbOdabraniSlatkis.TabIndex = 2;
            this.gbOdabraniSlatkis.TabStop = false;
            this.gbOdabraniSlatkis.Text = "Odabrani slatkiš";
            // 
            // btnIzmeni
            // 
            this.btnIzmeni.Location = new System.Drawing.Point(252, 268);
            this.btnIzmeni.Name = "btnIzmeni";
            this.btnIzmeni.Size = new System.Drawing.Size(89, 41);
            this.btnIzmeni.TabIndex = 6;
            this.btnIzmeni.Text = "Izmeni";
            this.btnIzmeni.UseVisualStyleBackColor = true;
            this.btnIzmeni.Click += new System.EventHandler(this.btnIzmeni_Click);
            // 
            // cmbProizvodjac
            // 
            this.cmbProizvodjac.FormattingEnabled = true;
            this.cmbProizvodjac.Location = new System.Drawing.Point(171, 193);
            this.cmbProizvodjac.Name = "cmbProizvodjac";
            this.cmbProizvodjac.Size = new System.Drawing.Size(155, 28);
            this.cmbProizvodjac.TabIndex = 5;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(171, 126);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(155, 27);
            this.txtNaziv.TabIndex = 4;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(171, 60);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(155, 27);
            this.txtID.TabIndex = 3;
            // 
            // lblProizvodjac
            // 
            this.lblProizvodjac.AutoSize = true;
            this.lblProizvodjac.Location = new System.Drawing.Point(61, 193);
            this.lblProizvodjac.Name = "lblProizvodjac";
            this.lblProizvodjac.Size = new System.Drawing.Size(97, 20);
            this.lblProizvodjac.TabIndex = 2;
            this.lblProizvodjac.Text = "Proizvođač:";
            // 
            // lblNaziv
            // 
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Location = new System.Drawing.Point(61, 126);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(56, 20);
            this.lblNaziv.TabIndex = 1;
            this.lblNaziv.Text = "Naziv:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(61, 63);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(31, 20);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // UCIzmeniSlatkis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNadjeniSlatkisi);
            this.Controls.Add(this.gbOdabraniSlatkis);
            this.Controls.Add(this.gbProizvodjaci);
            this.Name = "UCIzmeniSlatkis";
            this.Size = new System.Drawing.Size(780, 449);
            this.gbProizvodjaci.ResumeLayout(false);
            this.gbNadjeniSlatkisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlatkisi)).EndInit();
            this.gbOdabraniSlatkis.ResumeLayout(false);
            this.gbOdabraniSlatkis.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProizvodjaci;
        private System.Windows.Forms.ComboBox cmbProizvodjaci;
        private System.Windows.Forms.GroupBox gbNadjeniSlatkisi;
        private System.Windows.Forms.GroupBox gbOdabraniSlatkis;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgvSlatkisi;
        private System.Windows.Forms.Button btnIzmeni;
        private System.Windows.Forms.ComboBox cmbProizvodjac;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblProizvodjac;
        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnPretrazi;

        public GroupBox GbProizvodjaci { get => gbProizvodjaci; set => gbProizvodjaci = value; }
        public ComboBox CmbProizvodjaci { get => cmbProizvodjaci; set => cmbProizvodjaci = value; }
        public GroupBox GbNadjeniSlatkisi { get => gbNadjeniSlatkisi; set => gbNadjeniSlatkisi = value; }
        public GroupBox GbOdabraniSlatkis { get => gbOdabraniSlatkis; set => gbOdabraniSlatkis = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
        public DataGridView DgvSlatkisi { get => dgvSlatkisi; set => dgvSlatkisi = value; }
        public Button BtnIzmeni { get => btnIzmeni; set => btnIzmeni = value; }
        public ComboBox CmbProizvodjac { get => cmbProizvodjac; set => cmbProizvodjac = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtID { get => txtID; set => txtID = value; }
        public Label LblProizvodjac { get => lblProizvodjac; set => lblProizvodjac = value; }
        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public Label LblID { get => lblID; set => lblID = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
    }
}
