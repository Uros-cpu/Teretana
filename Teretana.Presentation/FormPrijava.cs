using Microsoft.VisualBasic;
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
    public partial class FormPrijava : Form
    {
        private ClanService clanService = new ClanService();
        public FormPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            string korisnickoIme = txtKorisnickoIme.Text;
            string lozinka = txtLozinka.Text;

            Clan clan = clanService.Prijava(korisnickoIme, lozinka);

            if (clan != null)
            {
                lblPoruka.Text = "";
                FormPregledTreninga formPregled = new FormPregledTreninga(clan);
                formPregled.Show();
                this.Hide();
            }
            else
            {
                lblPoruka.Text = "Pogrešno korisničko ime ili lozinka.";
            }
        }

        private void btnRegistracija_Click(object sender, EventArgs e)
        {
            FormRegistracija formRegistracija = new FormRegistracija();
            formRegistracija.ShowDialog();
        }

        private const string ADMIN_LOZINKA = "admin123"; // promeni po želji

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            string unetaLozinka = Interaction.InputBox("Unesite admin lozinku:", "Admin pristup", "");

            if (unetaLozinka == ADMIN_LOZINKA)
            {
                FormAdminTreninzi formAdmin = new FormAdminTreninzi();
                formAdmin.ShowDialog();
            }
            else if (unetaLozinka != "") // prazan string = korisnik kliknuo Cancel, ne prikazuj grešku
            {
                MessageBox.Show("Pogrešna admin lozinka.");
            }
        }
    }
}
