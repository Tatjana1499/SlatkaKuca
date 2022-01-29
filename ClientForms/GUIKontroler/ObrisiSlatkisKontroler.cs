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


        public ObrisiSlatkisKontroler(UCObrisiSlatkis uc)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.VratiProizvodjace
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtev);
            while (GlavnaKontroler.proizvodjaci == null)
            {
                Thread.Sleep(100);
            }
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
                Operacija = Operacija.VratiOdabraneSlatkise,
                Poruka = (Proizvodjac)uc.CmbProizvodjaci.SelectedItem
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtevSl);
            while (GlavnaKontroler.odabraniSlatkisi == null)
            {
                Thread.Sleep(100);
            }
            slatkisi = new BindingList<Slatkis>(GlavnaKontroler.odabraniSlatkisi);

            uc.GbNadjeni.Visible = true;
            this.uc.DgvNadjeniSlatkisi.DataSource = slatkisi;
            this.uc.DgvNadjeniSlatkisi.Columns["NazivTabele"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvNadjeniSlatkisi.Columns["UslovIzbacivanja"].Visible = false;

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
            slatkisi.Remove(slatkis);
        }
    }
}