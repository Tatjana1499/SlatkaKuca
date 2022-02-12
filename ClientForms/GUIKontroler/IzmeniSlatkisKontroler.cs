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
    public class IzmeniSlatkisKontroler
    {
        UCIzmeniSlatkis uc;
        BindingList<Slatkis> slatkisi;
        Proizvodjac proizvodjac;
        BindingList<Proizvodjac> proizvodjaci;


        public IzmeniSlatkisKontroler(UCIzmeniSlatkis uc)
        {
            if (GlavnaKontroler.proizvodjaci == null)
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiProizvodjace
                };
                Communication.Instanca.SendRequest<Zahtev>(zahtev);
                while(GlavnaKontroler.proizvodjaci == null) Thread.Sleep(10);
            }
            this.uc = uc;
            GlavnaKontroler.IzmenjenSlatkis += OsveziTabelu;
        }
        public void InitData()
        {
            proizvodjaci = new BindingList<Proizvodjac>(GlavnaKontroler.proizvodjaci);
            uc.GbNadjeniSlatkisi.Visible = false;
            uc.GbOdabraniSlatkis.Visible = false;
            uc.CmbProizvodjac.DataSource = GlavnaKontroler.proizvodjaci;
            uc.CmbProizvodjaci.DataSource = proizvodjaci;
        }
        public void PrikaziSlatkise()
        {
            proizvodjac = (Proizvodjac)uc.CmbProizvodjaci.SelectedItem;
            if (proizvodjac == null)
            {
                Osvezi();
                uc.DgvSlatkisi.DataSource = null;
                MessageBox.Show("Niste odabrali proizvođača.");
                return;
            }
            if (GlavnaKontroler.slatkisi == null)
            {
                Zahtev zahtevSl = new Zahtev() { Operacija = Operacija.VratiSlatkise };
                Communication.Instanca.SendRequest<Zahtev>(zahtevSl);
                while (GlavnaKontroler.slatkisi == null) Thread.Sleep(10);
            }
            slatkisi = new BindingList<Slatkis>();
            foreach (Slatkis s in GlavnaKontroler.slatkisi)
                if (s.Proizvodjac.ProizvodjacID == proizvodjac.ProizvodjacID) slatkisi.Add(s);
            uc.DgvSlatkisi.DataSource = slatkisi;
            this.uc.DgvSlatkisi.Columns["NazivTabele"].Visible = false;
            this.uc.DgvSlatkisi.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvSlatkisi.Columns["SlatkisID"].Visible = false;
            this.uc.DgvSlatkisi.Columns["Proizvodjac"].Visible = false;
            this.uc.DgvSlatkisi.Columns["UslovIzbacivanja"].Visible = false;
            this.uc.DgvSlatkisi.Columns["PostaviVrednosti"].Visible = false;
            uc.GbNadjeniSlatkisi.Visible = true;
        }
        public void IzaberiSlatkis()
        {
            if (uc.DgvSlatkisi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali slatkiš.");
                return;
            }
            if (uc.DgvSlatkisi.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite jedan slatkiš.");
                return;
            }
            Slatkis s = (Slatkis)uc.DgvSlatkisi.SelectedRows[0].DataBoundItem;
            uc.GbOdabraniSlatkis.Visible = true;
            uc.TxtID.Text = s.SlatkisID.ToString();
            uc.TxtNaziv.Text = s.Naziv;
            foreach(Proizvodjac p in proizvodjaci)
            {
                if(p.ProizvodjacID == s.Proizvodjac.ProizvodjacID)
                {
                    uc.CmbProizvodjac.SelectedItem = p;
                    break;
                }
            }
        }
        public void IzmeniSlatkis()
        {
            if(string.IsNullOrEmpty(uc.TxtNaziv.Text) || string.IsNullOrWhiteSpace(uc.TxtNaziv.Text) || uc.CmbProizvodjac.SelectedItem == null)
            {
                MessageBox.Show("Popunite sva polja.");
                return;
            }
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.IzmeniSlatkis,
                Poruka = new Slatkis()
                {
                    Naziv = uc.TxtNaziv.Text,
                    SlatkisID = int.Parse(uc.TxtID.Text),
                    Proizvodjac = (Proizvodjac)uc.CmbProizvodjac.SelectedItem
                }
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtev);
        }
        public void Osvezi()
        {
            uc.TxtID.Text = "";
            uc.TxtNaziv.Text = "";
            uc.CmbProizvodjac.SelectedItem = null;
        }
        public void OsveziTabelu(object sender, EventArgs args)
        {
            slatkisi = new BindingList<Slatkis>();
            foreach (Slatkis s in GlavnaKontroler.slatkisi)
                if (s.Proizvodjac.ProizvodjacID == proizvodjac.ProizvodjacID) slatkisi.Add(s);
            uc.Invoke(new Action(() => { uc.DgvSlatkisi.DataSource = slatkisi; }));
        }
    }
}