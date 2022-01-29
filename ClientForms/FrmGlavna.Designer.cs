namespace ClientForms
{
    partial class FrmGlavna
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
            this.meniGlavni = new System.Windows.Forms.MenuStrip();
            this.proizvođačToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.slatkišToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pretragaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izmenaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brisanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prodajnoMestoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kreirajToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.dnevnaProdajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unosRezultataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlGlavni = new System.Windows.Forms.Panel();
            this.meniGlavni.SuspendLayout();
            this.SuspendLayout();
            // 
            // meniGlavni
            // 
            this.meniGlavni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.meniGlavni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.proizvođačToolStripMenuItem,
            this.slatkišToolStripMenuItem,
            this.prodajnoMestoToolStripMenuItem,
            this.dnevnaProdajaToolStripMenuItem});
            this.meniGlavni.Location = new System.Drawing.Point(0, 0);
            this.meniGlavni.Name = "meniGlavni";
            this.meniGlavni.Size = new System.Drawing.Size(800, 28);
            this.meniGlavni.TabIndex = 0;
            this.meniGlavni.Text = "menuStrip1";
            // 
            // proizvođačToolStripMenuItem
            // 
            this.proizvođačToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem});
            this.proizvođačToolStripMenuItem.Name = "proizvođačToolStripMenuItem";
            this.proizvođačToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.proizvođačToolStripMenuItem.Text = "Proizvođač";
            // 
            // kreirajToolStripMenuItem
            // 
            this.kreirajToolStripMenuItem.Name = "kreirajToolStripMenuItem";
            this.kreirajToolStripMenuItem.Size = new System.Drawing.Size(135, 26);
            this.kreirajToolStripMenuItem.Text = "Kreiraj";
            this.kreirajToolStripMenuItem.Click += new System.EventHandler(this.kreirajToolStripMenuItem_Click);
            // 
            // slatkišToolStripMenuItem
            // 
            this.slatkišToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem1,
            this.pretragaToolStripMenuItem,
            this.izmenaToolStripMenuItem,
            this.brisanjeToolStripMenuItem});
            this.slatkišToolStripMenuItem.Name = "slatkišToolStripMenuItem";
            this.slatkišToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.slatkišToolStripMenuItem.Text = "Slatkiš";
            // 
            // kreirajToolStripMenuItem1
            // 
            this.kreirajToolStripMenuItem1.Name = "kreirajToolStripMenuItem1";
            this.kreirajToolStripMenuItem1.Size = new System.Drawing.Size(167, 26);
            this.kreirajToolStripMenuItem1.Text = "Kreiraj novi";
            this.kreirajToolStripMenuItem1.Click += new System.EventHandler(this.kreirajToolStripMenuItem1_Click);
            // 
            // pretragaToolStripMenuItem
            // 
            this.pretragaToolStripMenuItem.Name = "pretragaToolStripMenuItem";
            this.pretragaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.pretragaToolStripMenuItem.Text = "Pretraga";
            this.pretragaToolStripMenuItem.Click += new System.EventHandler(this.pretragaToolStripMenuItem_Click);
            // 
            // izmenaToolStripMenuItem
            // 
            this.izmenaToolStripMenuItem.Name = "izmenaToolStripMenuItem";
            this.izmenaToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.izmenaToolStripMenuItem.Text = "Izmena";
            // 
            // brisanjeToolStripMenuItem
            // 
            this.brisanjeToolStripMenuItem.Name = "brisanjeToolStripMenuItem";
            this.brisanjeToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.brisanjeToolStripMenuItem.Text = "Brisanje";
            this.brisanjeToolStripMenuItem.Click += new System.EventHandler(this.brisanjeToolStripMenuItem_Click);
            // 
            // prodajnoMestoToolStripMenuItem
            // 
            this.prodajnoMestoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kreirajToolStripMenuItem2});
            this.prodajnoMestoToolStripMenuItem.Name = "prodajnoMestoToolStripMenuItem";
            this.prodajnoMestoToolStripMenuItem.Size = new System.Drawing.Size(128, 24);
            this.prodajnoMestoToolStripMenuItem.Text = "Prodajno mesto";
            // 
            // kreirajToolStripMenuItem2
            // 
            this.kreirajToolStripMenuItem2.Name = "kreirajToolStripMenuItem2";
            this.kreirajToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.kreirajToolStripMenuItem2.Text = "Kreiraj";
            this.kreirajToolStripMenuItem2.Click += new System.EventHandler(this.kreirajToolStripMenuItem2_Click);
            // 
            // dnevnaProdajaToolStripMenuItem
            // 
            this.dnevnaProdajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unosRezultataToolStripMenuItem});
            this.dnevnaProdajaToolStripMenuItem.Name = "dnevnaProdajaToolStripMenuItem";
            this.dnevnaProdajaToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.dnevnaProdajaToolStripMenuItem.Text = "Dnevna prodaja";
            // 
            // unosRezultataToolStripMenuItem
            // 
            this.unosRezultataToolStripMenuItem.Name = "unosRezultataToolStripMenuItem";
            this.unosRezultataToolStripMenuItem.Size = new System.Drawing.Size(187, 26);
            this.unosRezultataToolStripMenuItem.Text = "Unos rezultata";
            // 
            // pnlGlavni
            // 
            this.pnlGlavni.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlGlavni.Location = new System.Drawing.Point(0, 30);
            this.pnlGlavni.Name = "pnlGlavni";
            this.pnlGlavni.Size = new System.Drawing.Size(800, 420);
            this.pnlGlavni.TabIndex = 1;
            // 
            // FrmGlavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlGlavni);
            this.Controls.Add(this.meniGlavni);
            this.MainMenuStrip = this.meniGlavni;
            this.Name = "FrmGlavna";
            this.Text = "FrmGlavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmGlavna_FormClosed);
            this.meniGlavni.ResumeLayout(false);
            this.meniGlavni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip meniGlavni;
        private System.Windows.Forms.ToolStripMenuItem proizvođačToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem slatkišToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem pretragaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izmenaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brisanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prodajnoMestoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kreirajToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem dnevnaProdajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unosRezultataToolStripMenuItem;
        private System.Windows.Forms.Panel pnlGlavni;
    }
}