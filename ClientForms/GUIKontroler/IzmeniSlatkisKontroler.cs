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

        BindingList<Proizvodjac> proizvodjaci;

        public IzmeniSlatkisKontroler(UCIzmeniSlatkis uc)
        {
            Zahtev zahtev = new Zahtev()
            {
                Operacija = Operacija.VratiProizvodjace
            };
            Communication.Instanca.SendRequest<Zahtev>(zahtev);
            while (GlavnaKontroler.proizvodjaci == null)  Thread.Sleep(100);
            proizvodjaci = new BindingList<Proizvodjac>(GlavnaKontroler.proizvodjaci);
            this.uc = uc;
        }
        public void InitData()
        {
            uc.GbNadjeniSlatkisi.Visible = false;
            uc.GbOdabraniSlatkis.Visible = false;
            uc.CmbProizvodjac.DataSource = proizvodjaci;
            uc.CmbProizvodjaci.DataSource = proizvodjaci;
        }
        public void PrikaziSlatkise()
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


            uc.GbNadjeniSlatkisi.Visible = true;
            this.uc.DgvSlatkisi.DataSource = slatkisi;
            this.uc.DgvSlatkisi.Columns["NazivTabele"].Visible = false;
            this.uc.DgvSlatkisi.Columns["UbaciVrednosti"].Visible = false;
            this.uc.DgvSlatkisi.Columns["SlatkisID"].Visible = false;
            this.uc.DgvSlatkisi.Columns["Proizvodjac"].Visible = false;
            this.uc.DgvSlatkisi.Columns["UslovIzbacivanja"].Visible = false;
        }
        public void IzaberiSlatkis()
        {
            if (uc.DgvSlatkisi.SelectedRows.Count == 0)
            {
                MessageBox.Show("Niste odabrali slatkiš.");
                return;
            }
            Slatkis s = (Slatkis)uc.DgvSlatkisi.SelectedRows[0].DataBoundItem;
            uc.GbOdabraniSlatkis.Visible = true;
            uc.TxtID.Text = s.SlatkisID.ToString();
            uc.TxtNaziv.Text = s.Naziv;
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
    }
}