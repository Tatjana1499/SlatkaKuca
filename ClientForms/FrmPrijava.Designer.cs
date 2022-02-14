using System.Windows.Forms;

namespace ClientForms
{
    partial class FrmPrijava
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
            this.lblKorIme = new System.Windows.Forms.Label();
            this.lblSifra = new System.Windows.Forms.Label();
            this.txtKorIme = new System.Windows.Forms.TextBox();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.btnPrijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKorIme
            // 
            this.lblKorIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblKorIme.AutoSize = true;
            this.lblKorIme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorIme.Location = new System.Drawing.Point(191, 107);
            this.lblKorIme.Name = "lblKorIme";
            this.lblKorIme.Size = new System.Drawing.Size(129, 20);
            this.lblKorIme.TabIndex = 0;
            this.lblKorIme.Text = "Korisničko ime: ";
            // 
            // lblSifra
            // 
            this.lblSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSifra.AutoSize = true;
            this.lblSifra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSifra.Location = new System.Drawing.Point(191, 164);
            this.lblSifra.Name = "lblSifra";
            this.lblSifra.Size = new System.Drawing.Size(54, 20);
            this.lblSifra.TabIndex = 1;
            this.lblSifra.Text = "Šifra: ";
            // 
            // txtKorIme
            // 
            this.txtKorIme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKorIme.Location = new System.Drawing.Point(326, 107);
            this.txtKorIme.Name = "txtKorIme";
            this.txtKorIme.Size = new System.Drawing.Size(199, 22);
            this.txtKorIme.TabIndex = 2;
            this.txtKorIme.Click += new System.EventHandler(this.txtKorIme_Click);
            // 
            // txtSifra
            // 
            this.txtSifra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSifra.Location = new System.Drawing.Point(326, 164);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.PasswordChar = '*';
            this.txtSifra.Size = new System.Drawing.Size(199, 22);
            this.txtSifra.TabIndex = 3;
            this.txtSifra.Click += new System.EventHandler(this.txtSifra_Click);
            // 
            // btnPrijava
            // 
            this.btnPrijava.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPrijava.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrijava.Location = new System.Drawing.Point(373, 215);
            this.btnPrijava.Name = "btnPrijava";
            this.btnPrijava.Size = new System.Drawing.Size(103, 51);
            this.btnPrijava.TabIndex = 4;
            this.btnPrijava.Text = "Prijavi se";
            this.btnPrijava.UseVisualStyleBackColor = true;
            this.btnPrijava.Click += new System.EventHandler(this.btnPrijava_Click);
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPrijava);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.txtKorIme);
            this.Controls.Add(this.lblSifra);
            this.Controls.Add(this.lblKorIme);
            this.Name = "FrmPrijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKorIme;
        private System.Windows.Forms.Label lblSifra;
        private System.Windows.Forms.TextBox txtKorIme;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.Button btnPrijava;

        public Label LblKorIme { get => lblKorIme; set => lblKorIme = value; }
        public Label LblSifra { get => lblSifra; set => lblSifra = value; }
        public TextBox TxtKorIme { get => txtKorIme; set => txtKorIme = value; }
        public TextBox TxtSifra { get => txtSifra; set => txtSifra = value; }
        public Button BtnPrijava { get => btnPrijava; set => btnPrijava = value; }
    }
}

