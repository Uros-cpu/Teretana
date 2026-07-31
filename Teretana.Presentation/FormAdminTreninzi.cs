using System;
using System.Windows.Forms;
using Teretana.BusinessLayer;
using Teretana.DataLayer;

namespace Teretana.Presentation
{
    public partial class FormAdminTreninzi : Form
    {
        private TreningService treningService = new TreningService();
        private int? izabraniId = null; // pamti koji trening je selektovan za izmenu

        public FormAdminTreninzi()
        {
            InitializeComponent();
        }

        private void FormAdminTreninzi_Load(object sender, EventArgs e)
        {
            UcitajTreninge();
        }

        private void UcitajTreninge()
        {
            dgvAdminTreninzi.DataSource = null;
            dgvAdminTreninzi.DataSource = treningService.VratiSveTreninge();

            if (dgvAdminTreninzi.Columns.Count > 0)
            {
                dgvAdminTreninzi.Columns["IdTreninga"].HeaderText = "ID";
                dgvAdminTreninzi.Columns["Naziv"].HeaderText = "Naziv";
                dgvAdminTreninzi.Columns["Trener"].HeaderText = "Trener";
                dgvAdminTreninzi.Columns["TipTreninga"].HeaderText = "Tip";
                dgvAdminTreninzi.Columns["Trajanje"].HeaderText = "Trajanje";
                dgvAdminTreninzi.Columns["MaxBrojUcesnika"].HeaderText = "Max uč.";
                dgvAdminTreninzi.Columns["DatumTermina"].HeaderText = "Datum";
                dgvAdminTreninzi.Columns["DatumTermina"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
            }
        }

        // Klik na red u gridu - popuni polja za izmenu
        private void dgvAdminTreninzi_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAdminTreninzi.CurrentRow == null) return;

            Trening t = (Trening)dgvAdminTreninzi.CurrentRow.DataBoundItem;

            izabraniId = t.IdTreninga;
            txtNaziv.Text = t.Naziv;
            txtTrener.Text = t.Trener;
            txtTipTreninga.Text = t.TipTreninga;
            txtTrajanje.Text = t.Trajanje.ToString();
            txtMaxUcesnika.Text = t.MaxBrojUcesnika.ToString();
            dtpDatumTermina.Value = t.DatumTermina;

            lblPoruka.Text = "";
        }

        // Pomoćna metoda - čita polja i pravi Trening objekat
        private Trening ProcitajPolja()
        {
            int trajanje;
            int maxUcesnika;

            if (!int.TryParse(txtTrajanje.Text, out trajanje))
            {
                lblPoruka.Text = "Trajanje mora biti broj.";
                return null;
            }

            if (!int.TryParse(txtMaxUcesnika.Text, out maxUcesnika))
            {
                lblPoruka.Text = "Max broj učesnika mora biti broj.";
                return null;
            }

            return new Trening
            {
                Naziv = txtNaziv.Text,
                Trener = txtTrener.Text,
                TipTreninga = txtTipTreninga.Text,
                Trajanje = trajanje,
                MaxBrojUcesnika = maxUcesnika,
                DatumTermina = dtpDatumTermina.Value
            };
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            Trening noviTrening = ProcitajPolja();
            if (noviTrening == null) return; // greška u parsiranju, poruka već postavljena

            string greska = treningService.DodajTrening(noviTrening);

            if (greska == null)
            {
                lblPoruka.Text = "";
                MessageBox.Show("Trening je dodat.");
                UcitajTreninge();
                OcistiPolja();
            }
            else
            {
                lblPoruka.Text = greska;
            }
        }

        private void btnIzmeni_Click(object sender, EventArgs e)
        {
            if (izabraniId == null)
            {
                lblPoruka.Text = "Izaberite trening iz liste za izmenu.";
                return;
            }

            Trening izmenjeniTrening = ProcitajPolja();
            if (izmenjeniTrening == null) return;

            izmenjeniTrening.IdTreninga = izabraniId.Value;

            string greska = treningService.IzmeniTrening(izmenjeniTrening);

            if (greska == null)
            {
                lblPoruka.Text = "";
                MessageBox.Show("Trening je izmenjen.");
                UcitajTreninge();
                OcistiPolja();
            }
            else
            {
                lblPoruka.Text = greska;
            }
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (izabraniId == null)
            {
                lblPoruka.Text = "Izaberite trening iz liste za brisanje.";
                return;
            }

            DialogResult potvrda = MessageBox.Show(
                "Da li ste sigurni da želite da obrišete ovaj trening?",
                "Potvrda brisanja",
                MessageBoxButtons.YesNo);

            if (potvrda == DialogResult.Yes)
            {
                treningService.ObrisiTrening(izabraniId.Value);
                UcitajTreninge();
                OcistiPolja();
                lblPoruka.Text = "";
            }
        }

        private void OcistiPolja()
        {
            txtNaziv.Text = "";
            txtTrener.Text = "";
            txtTipTreninga.Text = "";
            txtTrajanje.Text = "";
            txtMaxUcesnika.Text = "";
            dtpDatumTermina.Value = DateTime.Now;
            izabraniId = null;
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
