using ClientForms.UserControls;
using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientForms.GUIKontroler
{
    public class DodajSlatkisKontroler
    {
        UCDodajSlatkis uc;
        BindingList<Slatkis> slatkisi = new BindingList<Slatkis>();
        BindingList<Proizvodjac> proizvodjaci;
        public DodajSlatkisKontroler(UCDodajSlatkis uc)
        {
            this.uc = uc;
        }
        public void InitData()
        {
            if (GlavnaKontroler.proizvodjaci == null)
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiProizvodjace };
                Communication.Instanca.SendRequest<Zahtev>(zahtev);
                while (GlavnaKontroler.proizvodjaci == null) Thread.Sleep(10);
            }
            proizvodjaci = new BindingList<Proizvodjac>(GlavnaKontroler.proizvodjaci);
            this.uc.DgvDodajSlatkis.DataSource = slatkisi;

            this.uc.DgvDodajSlatkis.Columns["SlatkisID"].Visible = false;
            this.uc.DgvDodajSlatkis.Columns["Proizvodjac"].Visible = false;
            this.uc.DgvDodajSlatkis.Columns["NazivTabele"].Visible = false;
            this.uc.DgvDodajSlatkis.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvDodajSlatkis.Columns["UslovIzbacivanja"].Visible = false;
            this.uc.DgvDodajSlatkis.Columns["PostaviVrednosti"].Visible = false;

            DataGridViewComboBoxColumn proizvodjacCmb = new DataGridViewComboBoxColumn()
            {
                HeaderText = "Proizvođač",
                DataSource = proizvodjaci,
                DataPropertyName = "Proizvodjac",
                ValueMember = "Self",
                DisplayMember = "Naziv"
            };
            this.uc.DgvDodajSlatkis.Columns.Add(proizvodjacCmb);
        }
        public void DodajSlatkise()
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.DodajSlatkise,
                Poruka = slatkisi.ToList()
            };
            Communication.Instanca.SendRequest(zahtev);
        }
        public void IzbrisiRed()
        {
            if (uc.DgvDodajSlatkis.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali slatkiš.");
                return;
            }
            if (uc.DgvDodajSlatkis.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite samo jedan red.");
                return;
            }
            Slatkis slatkis = (Slatkis)uc.DgvDodajSlatkis.SelectedRows[0].DataBoundItem;
            slatkisi.Remove(slatkis);
        }
    }
}