using System;
using System.Windows.Forms;
using Teretana.BusinessLayer;
using Teretana.DataLayer;

namespace Teretana.Presentation
{
    public partial class FormMojiTreninzi : Form
    {
        private PrijavaService prijavaService = new PrijavaService();
        private Clan ulogovaniClan;

        public FormMojiTreninzi(Clan clan)
        {
            InitializeComponent();
            ulogovaniClan = clan;
        }

        private void FormMojiTreninzi_Load(object sender, EventArgs e)
        {
            UcitajMojePrijave();
        }

        private void UcitajMojePrijave()
        {
            dgvMojiTreninzi.DataSource = null;
            dgvMojiTreninzi.DataSource = prijavaService.VratiMojePrijave(ulogovaniClan.IdClana);

            if (dgvMojiTreninzi.Columns.Count > 0)
            {
                dgvMojiTreninzi.Columns["IdPrijave"].Visible = false; // ne treba korisniku da vidi ID
                dgvMojiTreninzi.Columns["IdTreninga"].Visible = false; // ni ovaj, samo je referenca
                dgvMojiTreninzi.Columns["NazivTreninga"].HeaderText = "Naziv treninga";
                dgvMojiTreninzi.Columns["Trener"].HeaderText = "Trener";
                dgvMojiTreninzi.Columns["TipTreninga"].HeaderText = "Tip";
                dgvMojiTreninzi.Columns["DatumTermina"].HeaderText = "Datum i vreme";
                dgvMojiTreninzi.Columns["DatumTermina"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvMojiTreninzi.Columns["DatumPrijave"].HeaderText = "Datum prijave";
                dgvMojiTreninzi.Columns["DatumPrijave"].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm";
                dgvMojiTreninzi.Columns["Status"].HeaderText = "Status";
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            if (dgvMojiTreninzi.CurrentRow == null)
            {
                lblPoruka.Text = "Izaberite prijavu iz liste.";
                return;
            }

            PrijavaSaTreningom izabranaPrijava = (PrijavaSaTreningom)dgvMojiTreninzi.CurrentRow.DataBoundItem;

            prijavaService.OtkaziPrijavu(izabranaPrijava.IdPrijave);

            lblPoruka.Text = "";
            MessageBox.Show("Prijava je otkazana.");
            UcitajMojePrijave(); // osveži listu
        }

        private void btnNazad_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMojiTreninzi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMojiTreninzi.Columns[e.ColumnIndex].Name == "Status" && e.Value != null)
            {
                if (e.Value.ToString() == "otkazano")
                {
                    dgvMojiTreninzi.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Gray;
                }
                else
                {
                    dgvMojiTreninzi.Rows[e.RowIndex].DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
                }
            }
        }
    }
}