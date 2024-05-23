using COVID_19Monitoring.Model.Entity;
using COVID_19Monitoring.Repository.DataProvider;
using COVID_19Monitoring.Repository.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COVID_19Monitoring.Forms
{
    public partial class frmSettings : Form
    {
        IDataRepository repository = new DataRepository();

        List<Barangay> listBarangay;
        List<Place> listPlace;
        List<Symptom> listSymptom;

        public static int barangayID;
        public static int placeID;
        public static int symptomID;

        public static bool EditBarangay = false;
        public static bool EditPlace = false;
        public static bool EditSympton = false;

        public static string addFrom;
        public frmSettings()
        {
            InitializeComponent();
        }
        public async Task LoadBarangay()
        {
            listBarangay = await repository.GetBarangaysAsync();
            dgvBarangay.DataSource = listBarangay.Select(x => new
            {
                ID = x.ID,
                Barangay = x.BrgyName,
            }).ToList();
        }

        public async Task LoadPlace()
        {
            listPlace = await repository.GetPlacesAsync();
            dgvPlace.DataSource = listPlace.Select(x => new
            {
                ID = x.ID,
                Place = x.PlaceOfOrigin,
            }).ToList();
        }

        public async Task LoadSymptom()
        {
            listSymptom = await repository.GetSymptomsAsync();
            dgvSymptom.DataSource = listSymptom.Select(x => new
            {
                ID = x.ID,
                Symptom = x.Indication,
            }).ToList();
        }

        private async void dgvBarangay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listBarangay.Count() != 0)
            {
                if (dgvBarangay.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    barangayID = int.Parse(dgvBarangay.CurrentRow.Cells[2].Value.ToString());
                    EditBarangay = true;

                    frmAddBarangay fab = new frmAddBarangay();
                    fab.ShowDialog();
                }

                if (dgvBarangay.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    barangayID = int.Parse(dgvBarangay.CurrentRow.Cells[2].Value.ToString());
                    Barangay barangay = await repository.GetBarangayByIdAsync(barangayID);
                    DialogResult dr = MessageBox.Show("Are you sure to delete Barangay " + barangay.BrgyName + " from list?", "Warning!", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        await repository.DeleteBarangayAsync(barangayID);
                        MessageBox.Show("Delete Successfull!", "Success!");
                        await LoadBarangay();
                    }
                }
            }
        }

        private async void frmSettings_Load(object sender, EventArgs e)
        {
            await LoadBarangay();
            await LoadPlace();
            await LoadSymptom();
        }

        private async void dgvPlace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listPlace.Count() != 0)
            {
                if (dgvPlace.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    placeID = int.Parse(dgvPlace.CurrentRow.Cells[2].Value.ToString());
                    EditPlace = true;

                    frmAddPlace fap = new frmAddPlace();
                    fap.ShowDialog();
                }

                if (dgvPlace.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    placeID = int.Parse(dgvPlace.CurrentRow.Cells[2].Value.ToString());
                    Place place = await repository.GetPlaceByIdAsync(placeID);
                    DialogResult dr = MessageBox.Show("Are you sure to delete " + place.PlaceOfOrigin + " from list?", "Warning!", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        await repository.DeletePlaceAsync(placeID);
                        MessageBox.Show("Delete Successfull!", "Success!");
                        await LoadPlace();
                    }
                }
            }
        }

        private async void dgvSymptom_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (listSymptom.Count() != 0)
            {
                if (dgvSymptom.Columns[e.ColumnIndex].HeaderText == "Edit")
                {
                    symptomID = int.Parse(dgvSymptom.CurrentRow.Cells[2].Value.ToString());
                    EditSympton = true;

                    frmAddSymptom fas = new frmAddSymptom();
                    fas.ShowDialog();
                }

                if (dgvSymptom.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    symptomID = int.Parse(dgvSymptom.CurrentRow.Cells[2].Value.ToString());
                    Symptom symptom = await repository.GetSymptomByIdAsync(symptomID);
                    DialogResult dr = MessageBox.Show("Are you sure to delete " + symptom.Indication + " from list?", "Warning!", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        await repository.DeleteSymptomAsync(symptomID);
                        MessageBox.Show("Delete Successfull!", "Success!");
                        await LoadSymptom();
                    }
                }
            }
        }

        private void btnCreateBarangay_Click(object sender, EventArgs e)
        {
            frmAddBarangay fab = new frmAddBarangay();
            fab.ShowDialog();
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            addFrom = "Setting";
            frmAddPlace fap = new frmAddPlace();
            fap.ShowDialog();
        }

        private void btnCreateSymptom_Click(object sender, EventArgs e)
        {
            addFrom = "Setting";
            frmAddSymptom fas = new frmAddSymptom();
            fas.ShowDialog();
        }
    }
}
