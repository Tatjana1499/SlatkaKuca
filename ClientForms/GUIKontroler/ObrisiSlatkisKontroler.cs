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
        BindingList<Slatkis> slatkisi;
        Proizvodjac proizvodjac;
        public ObrisiSlatkisKontroler(UCObrisiSlatkis uc)
        {
            if(GlavnaKontroler.proizvodjaci == null)
            {
                Zahtev zahtev = new Zahtev()
                {
                    Operacija = Operacija.VratiProizvodjace
                };
                Communication.Instanca.SendRequest<Zahtev>(zahtev);
                while(GlavnaKontroler.proizvodjaci == null) Thread.Sleep(10);
            }
            this.uc = uc;
        }
        public void InitData()
        {
            GlavnaKontroler.ObrisanSlatkis += OsveziTabelu;
            proizvodjaci = new BindingList<Proizvodjac>(GlavnaKontroler.proizvodjaci);
            this.uc.GbNadjeni.Visible = false;
            uc.CmbProizvodjaci.DataSource = GlavnaKontroler.proizvodjaci;
        }
        public void PretraziSlatkise()
        {
            proizvodjac = (Proizvodjac)uc.CmbProizvodjaci.SelectedItem;
            if (proizvodjac == null)
            {
                uc.DgvNadjeniSlatkisi.DataSource = null;
                MessageBox.Show("Niste odabrali proizvođača.");
                return;
            }
            if(GlavnaKontroler.slatkisi == null)
            {
                Zahtev zahtevSl = new Zahtev()
                {
                    Operacija = Operacija.VratiSlatkise
                };
                Communication.Instanca.SendRequest<Zahtev>(zahtevSl);
                while(GlavnaKontroler.slatkisi == null) Thread.Sleep(10);
            }
            slatkisi = new BindingList<Slatkis>();
            foreach (Slatkis s in GlavnaKontroler.slatkisi)
                if (s.Proizvodjac.ProizvodjacID == proizvodjac.ProizvodjacID) slatkisi.Add(s);
            foreach(Slatkis s in slatkisi)
            {
                foreach(Proizvodjac p in proizvodjaci)
                {
                    if(s.Proizvodjac.ProizvodjacID == p.ProizvodjacID)
                    {
                        s.Proizvodjac = p;
                        break;
                    }
                }
            }
            uc.GbNadjeni.Visible = true;
            this.uc.DgvNadjeniSlatkisi.DataSource = slatkisi;
            this.uc.DgvNadjeniSlatkisi.Columns["NazivTabele"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UslovIzbacivanja"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["PostaviVrednosti"].Visible = false;
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
        public void OsveziTabelu(Object sender, EventArgs args)
        {
            slatkisi = new BindingList<Slatkis>();
            foreach (Slatkis s in GlavnaKontroler.slatkisi)
                if (s.Proizvodjac.ProizvodjacID == proizvodjac.ProizvodjacID) slatkisi.Add(s);
            uc.Invoke(new Action(() => { uc.DgvNadjeniSlatkisi.DataSource = slatkisi; }));
        }
    }
}