using System.Windows.Forms;

namespace ClientForms.UserControls
{
    partial class UCDodajProdajnoMesto
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
            this.lblNaziv = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtLokacija = new System.Windows.Forms.TextBox();
            this.txtRadnoVreme = new System.Windows.Forms.TextBox();
            this.txtSajt = new System.Windows.Forms.TextBox();
            this.lblLokacija = new System.Windows.Forms.Label();
            this.lblRadnoVreme = new System.Windows.Forms.Label();
            this.lblSajt = new System.Windows.Forms.Label();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNaziv
            // 
            this.lblNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNaziv.AutoSize = true;
            this.lblNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNaziv.Location = new System.Drawing.Point(341, 92);
            this.lblNaziv.Name = "lblNaziv";
            this.lblNaziv.Size = new System.Drawing.Size(61, 20);
            this.lblNaziv.TabIndex = 0;
            this.lblNaziv.Text = "Naziv: ";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNaziv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNaziv.Location = new System.Drawing.Point(490, 92);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(162, 27);
            this.txtNaziv.TabIndex = 1;
            // 
            // txtLokacija
            // 
            this.txtLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLokacija.Location = new System.Drawing.Point(490, 152);
            this.txtLokacija.Name = "txtLokacija";
            this.txtLokacija.Size = new System.Drawing.Size(162, 27);
            this.txtLokacija.TabIndex = 2;
            // 
            // txtRadnoVreme
            // 
            this.txtRadnoVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtRadnoVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRadnoVreme.Location = new System.Drawing.Point(490, 223);
            this.txtRadnoVreme.Name = "txtRadnoVreme";
            this.txtRadnoVreme.Size = new System.Drawing.Size(162, 27);
            this.txtRadnoVreme.TabIndex = 3;
            // 
            // txtSajt
            // 
            this.txtSajt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSajt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSajt.Location = new System.Drawing.Point(490, 300);
            this.txtSajt.Name = "txtSajt";
            this.txtSajt.Size = new System.Drawing.Size(162, 27);
            this.txtSajt.TabIndex = 4;
            // 
            // lblLokacija
            // 
            this.lblLokacija.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLokacija.AutoSize = true;
            this.lblLokacija.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLokacija.Location = new System.Drawing.Point(344, 155);
            this.lblLokacija.Name = "lblLokacija";
            this.lblLokacija.Size = new System.Drawing.Size(81, 20);
            this.lblLokacija.TabIndex = 5;
            this.lblLokacija.Text = "Lokacija: ";
            // 
            // lblRadnoVreme
            // 
            this.lblRadnoVreme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblRadnoVreme.AutoSize = true;
            this.lblRadnoVreme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRadnoVreme.Location = new System.Drawing.Point(344, 226);
            this.lblRadnoVreme.Name = "lblRadnoVreme";
            this.lblRadnoVreme.Size = new System.Drawing.Size(118, 20);
            this.lblRadnoVreme.TabIndex = 6;
            this.lblRadnoVreme.Text = "Radno vreme: ";
            // 
            // lblSajt
            // 
            this.lblSajt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSajt.AutoSize = true;
            this.lblSajt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSajt.Location = new System.Drawing.Point(344, 303);
            this.lblSajt.Name = "lblSajt";
            this.lblSajt.Size = new System.Drawing.Size(48, 20);
            this.lblSajt.TabIndex = 7;
            this.lblSajt.Text = "Sajt: ";
            // 
            // btnDodaj
            // 
            this.btnDodaj.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDodaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDodaj.Location = new System.Drawing.Point(547, 362);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(84, 36);
            this.btnDodaj.TabIndex = 8;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // UCDodajProdajnoMesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.lblSajt);
            this.Controls.Add(this.lblRadnoVreme);
            this.Controls.Add(this.lblLokacija);
            this.Controls.Add(this.txtSajt);
            this.Controls.Add(this.txtRadnoVreme);
            this.Controls.Add(this.txtLokacija);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.lblNaziv);
            this.Name = "UCDodajProdajnoMesto";
            this.Size = new System.Drawing.Size(926, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaziv;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtLokacija;
        private System.Windows.Forms.TextBox txtRadnoVreme;
        private System.Windows.Forms.TextBox txtSajt;
        private System.Windows.Forms.Label lblLokacija;
        private System.Windows.Forms.Label lblRadnoVreme;
        private System.Windows.Forms.Label lblSajt;
        private System.Windows.Forms.Button btnDodaj;

        public Label LblNaziv { get => lblNaziv; set => lblNaziv = value; }
        public TextBox TxtNaziv { get => txtNaziv; set => txtNaziv = value; }
        public TextBox TxtLokacija { get => txtLokacija; set => txtLokacija = value; }
        public TextBox TxtRadnoVreme { get => txtRadnoVreme; set => txtRadnoVreme = value; }
        public TextBox TxtSajt { get => txtSajt; set => txtSajt = value; }
        public Label LblLokacija { get => lblLokacija; set => lblLokacija = value; }
        public Label LblRadnoVreme { get => lblRadnoVreme; set => lblRadnoVreme = value; }
        public Label LblSajt { get => lblSajt; set => lblSajt = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
    }
}
