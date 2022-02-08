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
    public class ObrisiSlatkisKontroler
    {
        UCObrisiSlatkis uc;
        BindingList<Proizvodjac> proizvodjaci;
        public static BindingList<Slatkis> slatkisi;
        Proizvodjac proizvodjac;
        public ObrisiSlatkisKontroler(UCObrisiSlatkis uc)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.VratiProizvodjace
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtev);
            Thread.Sleep(100);
            proizvodjaci = new BindingList<Proizvodjac>(GlavnaKontroler.proizvodjaci);
            this.uc = uc;
            this.uc.GbNadjeni.Visible = false;
        }
        public void InitData()
        {
            uc.CmbProizvodjaci.DataSource = proizvodjaci;
        }
        public void PretraziSlatkise()
        {
            Zahtev zahtevSl = new Zahtev()
            {
                Operacija = Operacija.VratiSlatkise
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtevSl);
            proizvodjac = (Proizvodjac)uc.CmbProizvodjaci.SelectedItem;
            Thread.Sleep(100);
            slatkisi = new BindingList<Slatkis>();
            foreach (Slatkis s in GlavnaKontroler.slatkisi)
                if (s.Proizvodjac.ProizvodjacID == proizvodjac.ProizvodjacID) slatkisi.Add(s);

            uc.GbNadjeni.Visible = true;
            this.uc.DgvNadjeniSlatkisi.DataSource = slatkisi;
            this.uc.DgvNadjeniSlatkisi.Columns["NazivTabele"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UslovIzbacivanja"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["PostaviVrednosti"].Visible = false;
            //this.uc.DgvNadjeniSlatkisi.Columns["Proizvodjac"] = slatkisi[0].Proizvodjac.ToString();
        }
        public void ObrisiOdabrani()
        {
            if (uc.DgvNadjeniSlatkisi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali slatkis.");
                return;
            }
            if (uc.DgvNadjeniSlatkisi.SelectedRows.Count > 1)
            {
                MessageBox.Show("Odaberite samo jedan slatkis.");
                return;
            }
            Slatkis slatkis = (Slatkis)uc.DgvNadjeniSlatkisi.SelectedRows[0].DataBoundItem;
            Zahtev zahtev = new Zahtev() 
            { 
                Operacija = Operacija.ObrisiSlatkis,
                Poruka = slatkis
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtev);
        }
    }
}