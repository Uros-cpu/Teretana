using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Teretana.BusinessLayer;
using Teretana.DataLayer;

namespace Teretana.Presentation
{
    public partial class FormRegistracija : Form
    {
        private ClanService clanService = new ClanService();
        public FormRegistracija()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnRegistruj_Click(object sender, EventArgs e)
        {
            Clan noviClan = new Clan
            {
                Ime = txtIme.Text,
                Prezime = txtPrezime.Text,
                Email = txtEmail.Text,
                Telefon = txtTelefon.Text,
                KorisnickoIme = txtKorisnickoIme.Text,
                Lozinka = txtLozinka.Text,
                TipClanarine = cmbTipClanarine.SelectedItem?.ToString() ?? "Osnovna"
            };

            string greska = clanService.Registruj(noviClan);

            if (greska == null)
            {
                MessageBox.Show("Uspešno ste se registrovali! Sada se možete prijaviti.");
                this.Close(); // zatvara formu registracije, vraća se na login
            }
            else
            {
                lblPoruka.Text = greska;
            }
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
