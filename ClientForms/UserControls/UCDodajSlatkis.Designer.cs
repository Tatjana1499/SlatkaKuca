using System.Windows.Forms;

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
            this.dgvDodajSlatkis = new System.Windows.Forms.DataGridView();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnIzbrisiRed = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodajSlatkis)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDodajSlatkis
            // 
            this.dgvDodajSlatkis.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDodajSlatkis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDodajSlatkis.Location = new System.Drawing.Point(54, 51);
            this.dgvDodajSlatkis.Name = "dgvDodajSlatkis";
            this.dgvDodajSlatkis.RowHeadersWidth = 51;
            this.dgvDodajSlatkis.RowTemplate.Height = 24;
            this.dgvDodajSlatkis.Size = new System.Drawing.Size(708, 292);
            this.dgvDodajSlatkis.TabIndex = 0;
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
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
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
            this.btnIzbrisiRed.Click += new System.EventHandler(this.btnIzbrisiRed_Click);
            // 
            // UCDodajSlatkis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnIzbrisiRed);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.dgvDodajSlatkis);
            this.Name = "UCDodajSlatkis";
            this.Size = new System.Drawing.Size(842, 466);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDodajSlatkis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDodajSlatkis;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.Button btnIzbrisiRed;

        public DataGridView DgvDodajSlatkis { get => dgvDodajSlatkis; set => dgvDodajSlatkis = value; }
        public Button BtnDodaj { get => btnDodaj; set => btnDodaj = value; }
        public Button BtnIzbrisiRed { get => btnIzbrisiRed; set => btnIzbrisiRed = value; }
    }
}
