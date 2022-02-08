using System.Windows.Forms;

namespace ClientForms.UserControls
{
    partial class UCDnevnaProdaja
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
            this.gbNadjeniSlatkisi = new System.Windows.Forms.GroupBox();
            this.btnIzaberi = new System.Windows.Forms.Button();
            this.dgvSlatkisi = new System.Windows.Forms.DataGridView();
            this.gbDnevnaProdaja = new System.Windows.Forms.GroupBox();
            this.gbProizvodjaci = new System.Windows.Forms.GroupBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.cmbProizvodjaci = new System.Windows.Forms.ComboBox();
            this.lblSlatkis = new System.Windows.Forms.Label();
            this.lblKomentar = new System.Windows.Forms.Label();
            this.lblKolicinaProdatih = new System.Windows.Forms.Label();
            this.lblDatumProdaje = new System.Windows.Forms.Label();
            this.lblPakovanje = new System.Windows.Forms.Label();
            this.lblProdajnoMesto = new System.Windows.Forms.Label();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.txtSlatkis = new System.Windows.Forms.TextBox();
            this.txtDatumProdaje = new System.Windows.Forms.TextBox();
            this.txtBrojProdatih = new System.Windows.Forms.TextBox();
            this.txtKomentar = new System.Windows.Forms.TextBox();
            this.cmbProdajnoMesto = new System.Windows.Forms.ComboBox();
            this.cmbPakovanje = new System.Windows.Forms.ComboBox();
            this.gbNadjeniSlatkisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlatkisi)).BeginInit();
            this.gbDnevnaProdaja.SuspendLayout();
            this.gbProizvodjaci.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNadjeniSlatkisi
            // 
            this.gbNadjeniSlatkisi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbNadjeniSlatkisi.Controls.Add(this.btnIzaberi);
            this.gbNadjeniSlatkisi.Controls.Add(this.dgvSlatkisi);
            this.gbNadjeniSlatkisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNadjeniSlatkisi.Location = new System.Drawing.Point(66, 88);
            this.gbNadjeniSlatkisi.Name = "gbNadjeniSlatkisi";
            this.gbNadjeniSlatkisi.Size = new System.Drawing.Size(302, 331);
            this.gbNadjeniSlatkisi.TabIndex = 4;
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
            // gbDnevnaProdaja
            // 
            this.gbDnevnaProdaja.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbDnevnaProdaja.Controls.Add(this.cmbPakovanje);
            this.gbDnevnaProdaja.Controls.Add(this.cmbProdajnoMesto);
            this.gbDnevnaProdaja.Controls.Add(this.txtKomentar);
            this.gbDnevnaProdaja.Controls.Add(this.txtBrojProdatih);
            this.gbDnevnaProdaja.Controls.Add(this.txtDatumProdaje);
            this.gbDnevnaProdaja.Controls.Add(this.txtSlatkis);
            this.gbDnevnaProdaja.Controls.Add(this.btnUnesi);
            this.gbDnevnaProdaja.Controls.Add(this.lblProdajnoMesto);
            this.gbDnevnaProdaja.Controls.Add(this.lblPakovanje);
            this.gbDnevnaProdaja.Controls.Add(this.lblDatumProdaje);
            this.gbDnevnaProdaja.Controls.Add(this.lblKolicinaProdatih);
            this.gbDnevnaProdaja.Controls.Add(this.lblKomentar);
            this.gbDnevnaProdaja.Controls.Add(this.lblSlatkis);
            this.gbDnevnaProdaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDnevnaProdaja.Location = new System.Drawing.Point(374, 88);
            this.gbDnevnaProdaja.Name = "gbDnevnaProdaja";
            this.gbDnevnaProdaja.Size = new System.Drawing.Size(402, 331);
            this.gbDnevnaProdaja.TabIndex = 5;
            this.gbDnevnaProdaja.TabStop = false;
            this.gbDnevnaProdaja.Text = "Unesi dnevnu prodaju";
            // 
            // gbProizvodjaci
            // 
            this.gbProizvodjaci.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbProizvodjaci.Controls.Add(this.btnPretrazi);
            this.gbProizvodjaci.Controls.Add(this.cmbProizvodjaci);
            this.gbProizvodjaci.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbProizvodjaci.Location = new System.Drawing.Point(66, 27);
            this.gbProizvodjaci.Name = "gbProizvodjaci";
            this.gbProizvodjaci.Size = new System.Drawing.Size(710, 55);
            this.gbProizvodjaci.TabIndex = 3;
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
            // 
            // cmbProizvodjaci
            // 
            this.cmbProizvodjaci.FormattingEnabled = true;
            this.cmbProizvodjaci.Location = new System.Drawing.Point(297, 19);
            this.cmbProizvodjaci.Name = "cmbProizvodjaci";
            this.cmbProizvodjaci.Size = new System.Drawing.Size(234, 28);
            this.cmbProizvodjaci.TabIndex = 0;
            // 
            // lblSlatkis
            // 
            this.lblSlatkis.AutoSize = true;
            this.lblSlatkis.Location = new System.Drawing.Point(19, 37);
            this.lblSlatkis.Name = "lblSlatkis";
            this.lblSlatkis.Size = new System.Drawing.Size(64, 20);
            this.lblSlatkis.TabIndex = 0;
            this.lblSlatkis.Text = "Slatkis:";
            // 
            // lblKomentar
            // 
            this.lblKomentar.AutoSize = true;
            this.lblKomentar.Location = new System.Drawing.Point(19, 226);
            this.lblKomentar.Name = "lblKomentar";
            this.lblKomentar.Size = new System.Drawing.Size(86, 20);
            this.lblKomentar.TabIndex = 1;
            this.lblKomentar.Text = "Komentar:";
            // 
            // lblKolicinaProdatih
            // 
            this.lblKolicinaProdatih.AutoSize = true;
            this.lblKolicinaProdatih.Location = new System.Drawing.Point(19, 186);
            this.lblKolicinaProdatih.Name = "lblKolicinaProdatih";
            this.lblKolicinaProdatih.Size = new System.Drawing.Size(110, 20);
            this.lblKolicinaProdatih.TabIndex = 2;
            this.lblKolicinaProdatih.Text = "Broj prodatih:";
            // 
            // lblDatumProdaje
            // 
            this.lblDatumProdaje.AutoSize = true;
            this.lblDatumProdaje.Location = new System.Drawing.Point(19, 147);
            this.lblDatumProdaje.Name = "lblDatumProdaje";
            this.lblDatumProdaje.Size = new System.Drawing.Size(124, 20);
            this.lblDatumProdaje.TabIndex = 3;
            this.lblDatumProdaje.Text = "Datum prodaje:";
            // 
            // lblPakovanje
            // 
            this.lblPakovanje.AutoSize = true;
            this.lblPakovanje.Location = new System.Drawing.Point(19, 109);
            this.lblPakovanje.Name = "lblPakovanje";
            this.lblPakovanje.Size = new System.Drawing.Size(90, 20);
            this.lblPakovanje.TabIndex = 4;
            this.lblPakovanje.Text = "Pakovanje:";
            // 
            // lblProdajnoMesto
            // 
            this.lblProdajnoMesto.AutoSize = true;
            this.lblProdajnoMesto.Location = new System.Drawing.Point(19, 71);
            this.lblProdajnoMesto.Name = "lblProdajnoMesto";
            this.lblProdajnoMesto.Size = new System.Drawing.Size(131, 20);
            this.lblProdajnoMesto.TabIndex = 5;
            this.lblProdajnoMesto.Text = "Prodajno mesto:";
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(303, 269);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(82, 40);
            this.btnUnesi.TabIndex = 6;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            // 
            // txtSlatkis
            // 
            this.txtSlatkis.Location = new System.Drawing.Point(206, 34);
            this.txtSlatkis.Name = "txtSlatkis";
            this.txtSlatkis.ReadOnly = true;
            this.txtSlatkis.Size = new System.Drawing.Size(179, 27);
            this.txtSlatkis.TabIndex = 7;
            // 
            // txtDatumProdaje
            // 
            this.txtDatumProdaje.Location = new System.Drawing.Point(206, 144);
            this.txtDatumProdaje.Name = "txtDatumProdaje";
            this.txtDatumProdaje.Size = new System.Drawing.Size(179, 27);
            this.txtDatumProdaje.TabIndex = 8;
            // 
            // txtBrojProdatih
            // 
            this.txtBrojProdatih.Location = new System.Drawing.Point(206, 183);
            this.txtBrojProdatih.Name = "txtBrojProdatih";
            this.txtBrojProdatih.Size = new System.Drawing.Size(179, 27);
            this.txtBrojProdatih.TabIndex = 9;
            // 
            // txtKomentar
            // 
            this.txtKomentar.Location = new System.Drawing.Point(206, 219);
            this.txtKomentar.Name = "txtKomentar";
            this.txtKomentar.Size = new System.Drawing.Size(179, 27);
            this.txtKomentar.TabIndex = 10;
            // 
            // cmbProdajnoMesto
            // 
            this.cmbProdajnoMesto.FormattingEnabled = true;
            this.cmbProdajnoMesto.Location = new System.Drawing.Point(206, 68);
            this.cmbProdajnoMesto.Name = "cmbProdajnoMesto";
            this.cmbProdajnoMesto.Size = new System.Drawing.Size(179, 28);
            this.cmbProdajnoMesto.TabIndex = 11;
            // 
            // cmbPakovanje
            // 
            this.cmbPakovanje.FormattingEnabled = true;
            this.cmbPakovanje.Location = new System.Drawing.Point(206, 110);
            this.cmbPakovanje.Name = "cmbPakovanje";
            this.cmbPakovanje.Size = new System.Drawing.Size(179, 28);
            this.cmbPakovanje.TabIndex = 12;
            // 
            // UCDnevnaProdaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbNadjeniSlatkisi);
            this.Controls.Add(this.gbDnevnaProdaja);
            this.Controls.Add(this.gbProizvodjaci);
            this.Name = "UCDnevnaProdaja";
            this.Size = new System.Drawing.Size(842, 447);
            this.gbNadjeniSlatkisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlatkisi)).EndInit();
            this.gbDnevnaProdaja.ResumeLayout(false);
            this.gbDnevnaProdaja.PerformLayout();
            this.gbProizvodjaci.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNadjeniSlatkisi;
        private System.Windows.Forms.Button btnIzaberi;
        private System.Windows.Forms.DataGridView dgvSlatkisi;
        private System.Windows.Forms.GroupBox gbDnevnaProdaja;
        private System.Windows.Forms.ComboBox cmbPakovanje;
        private System.Windows.Forms.ComboBox cmbProdajnoMesto;
        private System.Windows.Forms.TextBox txtKomentar;
        private System.Windows.Forms.TextBox txtBrojProdatih;
        private System.Windows.Forms.TextBox txtDatumProdaje;
        private System.Windows.Forms.TextBox txtSlatkis;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label lblProdajnoMesto;
        private System.Windows.Forms.Label lblPakovanje;
        private System.Windows.Forms.Label lblDatumProdaje;
        private System.Windows.Forms.Label lblKolicinaProdatih;
        private System.Windows.Forms.Label lblKomentar;
        private System.Windows.Forms.Label lblSlatkis;
        private System.Windows.Forms.GroupBox gbProizvodjaci;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.ComboBox cmbProizvodjaci;

        public GroupBox GbNadjeniSlatkisi { get => gbNadjeniSlatkisi; set => gbNadjeniSlatkisi = value; }
        public Button BtnIzaberi { get => btnIzaberi; set => btnIzaberi = value; }
        public DataGridView DgvSlatkisi { get => dgvSlatkisi; set => dgvSlatkisi = value; }
        public GroupBox GbDnevnaProdaja { get => gbDnevnaProdaja; set => gbDnevnaProdaja = value; }
        public ComboBox CmbPakovanje { get => cmbPakovanje; set => cmbPakovanje = value; }
        public ComboBox CmbProdajnoMesto { get => cmbProdajnoMesto; set => cmbProdajnoMesto = value; }
        public TextBox TxtKomentar { get => txtKomentar; set => txtKomentar = value; }
        public TextBox TxtBrojProdatih { get => txtBrojProdatih; set => txtBrojProdatih = value; }
        public TextBox TxtDatumProdaje { get => txtDatumProdaje; set => txtDatumProdaje = value; }
        public TextBox TxtSlatkis { get => txtSlatkis; set => txtSlatkis = value; }
        public Button BtnUnesi { get => btnUnesi; set => btnUnesi = value; }
        public Label LblProdajnoMesto { get => lblProdajnoMesto; set => lblProdajnoMesto = value; }
        public Label LblPakovanje { get => lblPakovanje; set => lblPakovanje = value; }
        public Label LblDatumProdaje { get => lblDatumProdaje; set => lblDatumProdaje = value; }
        public Label LblKolicinaProdatih { get => lblKolicinaProdatih; set => lblKolicinaProdatih = value; }
        public Label LblKomentar { get => lblKomentar; set => lblKomentar = value; }
        public Label LblSlatkis { get => lblSlatkis; set => lblSlatkis = value; }
        public GroupBox GbProizvodjaci { get => gbProizvodjaci; set => gbProizvodjaci = value; }
        public Button BtnPretrazi { get => btnPretrazi; set => btnPretrazi = value; }
        public ComboBox CmbProizvodjaci { get => cmbProizvodjaci; set => cmbProizvodjaci = value; }
    }
}
