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
    public class PretragaSlatkisaKontroler
    {
        UCPretragaSlatkisa uc;
        BindingList<Proizvodjac> proizvodjaci;
        BindingList<Slatkis> slatkisi;
        Proizvodjac proizvodjac;
        public PretragaSlatkisaKontroler(UCPretragaSlatkisa uc)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.VratiProizvodjace
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtev);
            while (GlavnaKontroler.proizvodjaci == null) Thread.Sleep(10);
            proizvodjaci = new BindingList<Proizvodjac>(GlavnaKontroler.proizvodjaci);
            this.uc = uc;
        }
        public void InitData()
        {
            this.uc.GbOdabraniSlatkis.Visible = false;
            this.uc.GbNadjeni.Visible = false;
            this.uc.CmbProizvodjaci.DataSource = proizvodjaci;
        }
        public void PretraziSlatkise()
        {
            Zahtev zahtevSl = new Zahtev()
            {
                Operacija = Operacija.VratiSlatkise,
            };
            proizvodjac = (Proizvodjac)uc.CmbProizvodjaci.SelectedItem;
            Communication.Instanca.SendRequest<Zahtev>(zahtevSl);
            Thread.Sleep(100);
            slatkisi = new BindingList<Slatkis>();
            foreach (Slatkis s in GlavnaKontroler.slatkisi)
                if (s.Proizvodjac.ProizvodjacID == proizvodjac.ProizvodjacID) slatkisi.Add(s);

            this.uc.DgvNadjeniSlatkisi.DataSource = slatkisi;
            this.uc.DgvNadjeniSlatkisi.Columns["NazivTabele"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["SlatkisID"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["Proizvodjac"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UslovIzbacivanja"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["PostaviVrednosti"].Visible = false;
            uc.GbNadjeni.Visible = true;
        }
        public void DetaljiOdabranog()
        {
            uc.TxtID.Text = "";
            uc.TxtNaziv.Text = "";
            uc.TxtProizvodjac.Text = "";
            if (uc.DgvNadjeniSlatkisi.SelectedRows.Count == 0)
            {
               
                MessageBox.Show("Niste odabrali slatkiš.");
                return;
            }
            if (uc.DgvNadjeniSlatkisi.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite jedan slatkiš.");
                return;
            }
            Slatkis s = (Slatkis)uc.DgvNadjeniSlatkisi.SelectedRows[0].DataBoundItem;
            uc.GbOdabraniSlatkis.Visible = true;
            uc.TxtID.Text = s.SlatkisID.ToString();
            uc.TxtNaziv.Text = s.Naziv;
            uc.TxtProizvodjac.Text = GlavnaKontroler.vratiProizvodjaca(s).ToString();
        }
       
    }
}