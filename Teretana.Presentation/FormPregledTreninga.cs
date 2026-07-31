using System;
using System.Windows.Forms;
using Teretana.BusinessLayer;
using Teretana.DataLayer;

namespace Teretana.Presentation
{
    public partial class FormPregledTreninga : Form
    {
        private TreningService treningService = new TreningService();
        private PrijavaService prijavaService = new PrijavaService();
        private Clan ulogovaniClan;

        public FormPregledTreninga(Clan clan)
        {
            InitializeComponent();
            ulogovaniClan = clan;
        }

        private void FormPregledTreninga_Load(object sender, EventArgs e)
        {
            lblDobrodosli.Text = $"Dobrodošli, {ulogovaniClan.Ime}!";
            UcitajTreninge();
        }

        private void UcitajTreninge()
        {
            dgvTreninzi.DataSource = null;
            dgvTreninzi.DataSource = treningService.VratiSveTreninge();

            if (dgvTreninzi.Columns.Count > 0)
            {
                dgvTreninzi.Columns["IdTreninga"].HeaderText = "ID";
                dgvTreninzi.Columns["IdTreninga"].Width = 40;
                dgvTreninzi.Columns["Naziv"].HeaderText = "Naziv treninga";
                dgvTreninzi.Columns["Trener"].HeaderText = "Trener";
                dgvTreninzi.Columns["TipTreninga"].HeaderText = "Tip";
                dgvTreninzi.Columns["Trajanje"].HeaderText = "Trajanje (min)";
                dgvTreninzi.Columns["MaxBrojUcesnika"].HeaderText = "Max učesnika";
                dgvTreninzi.Columns["DatumTermina"].HeaderText = "Datum i vreme";
                dgvTreninzi.Columns["DatumTermina"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
        }

        private void btnPrijaviSe_Click(object sender, EventArgs e)
        {
            if (dgvTreninzi.CurrentRow == null)
            {
                lblPoruka.Text = "Izaberite trening iz liste.";
                return;
            }

            Trening izabraniTrening = (Trening)dgvTreninzi.CurrentRow.DataBoundItem;

            string greska = prijavaService.PrijaviSeNaTrening(ulogovaniClan.IdClana, izabraniTrening.IdTreninga);

            if (greska == null)
            {
                lblPoruka.Text = "";
                MessageBox.Show("Uspešno ste se prijavili na trening!");
            }
            else
            {
                lblPoruka.Text = greska;
            }
        }

        private void btnMojiTreninzi_Click(object sender, EventArgs e)
        {
            FormMojiTreninzi formMoji = new FormMojiTreninzi(ulogovaniClan);
            formMoji.ShowDialog();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            FormPrijava formPrijava = new FormPrijava();
            formPrijava.Show();
            this.Close();
        }
    }
}