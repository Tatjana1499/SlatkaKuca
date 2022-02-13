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
    public class UnesiDnevnuProdajuKontroler
    {
        UCDnevnaProdaja uc;
        BindingList<Slatkis> slatkisi;
        Proizvodjac proizvodjac;
        List<Pakovanje> mogucaPakovanja;
        public UnesiDnevnuProdajuKontroler(UCDnevnaProdaja uc)
        {
            this.uc = uc;
        }
        public void InitData()
        {
            uc.GbNadjeniSlatkisi.Visible = false;
            uc.GbDnevnaProdaja.Visible = false;
            if(GlavnaKontroler.proizvodjaci == null)
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiProizvodjace };
                Communication.Instanca.SendRequest<Zahtev>(zahtev);
                while (GlavnaKontroler.proizvodjaci == null) Thread.Sleep(10);
            }
            uc.CmbProizvodjaci.DataSource = GlavnaKontroler.proizvodjaci;
        }
        public void PretraziSlatkise()
        {
            proizvodjac = (Proizvodjac)uc.CmbProizvodjaci.SelectedItem;
            if(proizvodjac == null)
            {
                Osvezi();
                uc.DgvSlatkisi.DataSource = null;
                MessageBox.Show("Niste odabrali proizvođača.");
                return;
            }
            if (GlavnaKontroler.slatkisi == null)
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiSlatkise };
                Communication.Instanca.SendRequest<Zahtev>(zahtev);
                while (GlavnaKontroler.slatkisi == null) Thread.Sleep(10);
            }
            slatkisi = new BindingList<Slatkis>();
            foreach(Slatkis s in GlavnaKontroler.slatkisi)
                if(proizvodjac.ProizvodjacID == s.Proizvodjac.ProizvodjacID) slatkisi.Add(s);
            uc.GbNadjeniSlatkisi.Visible = true;
            uc.DgvSlatkisi.DataSource = slatkisi;
            this.uc.DgvSlatkisi.Columns["NazivTabele"].Visible = false;
            this.uc.DgvSlatkisi.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvSlatkisi.Columns["SlatkisID"].Visible = false;
            this.uc.DgvSlatkisi.Columns["Proizvodjac"].Visible = false;
            this.uc.DgvSlatkisi.Columns["UslovIzbacivanja"].Visible = false;
            this.uc.DgvSlatkisi.Columns["PostaviVrednosti"].Visible = false;
        }
        public void UnosDnevnePr()
        {
            Osvezi();
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
            if(GlavnaKontroler.prMesta == null)
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiPrMesta };
                Communication.Instanca.SendRequest<Zahtev>(zahtev);
                while (GlavnaKontroler.prMesta == null) Thread.Sleep(10);
            }
            if (GlavnaKontroler.pakovanja == null)
            {
                Zahtev zahtev = new Zahtev() { Operacija = Operacija.VratiPakovanja };
                Communication.Instanca.SendRequest<Zahtev>(zahtev);
                while (GlavnaKontroler.pakovanja == null) Thread.Sleep(10);
            }
            Slatkis slatkis = (Slatkis)uc.DgvSlatkisi.SelectedRows[0].DataBoundItem;
            mogucaPakovanja = new List<Pakovanje>();
            foreach (Pakovanje p in GlavnaKontroler.pakovanja)
                if(p.Slatkis.SlatkisID == slatkis.SlatkisID) mogucaPakovanja.Add(p);
            uc.CmbProdajnoMesto.DataSource = GlavnaKontroler.prMesta;
            uc.CmbPakovanje.DataSource = mogucaPakovanja;
            uc.GbDnevnaProdaja.Visible = true;
            uc.TxtSlatkis.Text = slatkis.Naziv;
        }
        public void Unesi()
        {
            if(string.IsNullOrEmpty(uc.TxtBrojProdatih.Text) || string.IsNullOrWhiteSpace(uc.TxtBrojProdatih.Text) || uc.CmbProdajnoMesto.SelectedItem == null || uc.CmbPakovanje.SelectedItem == null || string.IsNullOrEmpty(uc.TxtDatumProdaje.Text) || string.IsNullOrWhiteSpace(uc.TxtDatumProdaje.Text))
            {
                MessageBox.Show("Popuni sva polja, polje za komentar nije obavezno.");
                return;
            }
            if (!int.TryParse(uc.TxtBrojProdatih.Text, out int brojProdatkih))
            {
                MessageBox.Show("Broj prodatih proizvoda mora biti broj!");
                return;
            }
            if (!DateTime.TryParse(uc.TxtDatumProdaje.Text, out DateTime date))
            {
                MessageBox.Show("Datum nije u ispravnom formatu!");
                return;
            }
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.UnesiDnevnuProdaju,
                Poruka = new DnevnaProdaja()
                {
                    DatumProdaje = date,
                    KolicinaProdatih = brojProdatkih,
                    KomentarPrMesta = uc.TxtKomentar.Text,
                    Pakovanje = (Pakovanje)uc.CmbPakovanje.SelectedItem,
                    ProdajnoMesto = (ProdajnoMesto)uc.CmbProdajnoMesto.SelectedItem
                }
            };
            Communication.Instanca.SendRequest(zahtev);
            Osvezi();
        }
        public void Osvezi()
        {
            uc.TxtSlatkis.Text = "";
            uc.TxtBrojProdatih.Text = "";
            uc.TxtDatumProdaje.Text = "";
            uc.TxtKomentar.Text = "";
            uc.CmbPakovanje.DataSource = null;
            uc.CmbProdajnoMesto.DataSource = null;
        }
    }
}