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
    public partial class frmViewList : Form
    {
        IDataRepository repository = new DataRepository();

        List<Barangay> listBarangay;
        List<Person> listPerson;
        List<Place> listPlace;
        List<Symptom> listSymptom;
        List<PUM> listPUM;
        List<PUI> listPUI;
        public frmViewList()
        {
            InitializeComponent();
        }

        private async void frmViewList_Load(object sender, EventArgs e)
        {
            await LoadData();
            if (frmSummary.category == "PUM")
                LoadPUM();

            if (frmSummary.category == "Case Closed PUM")
                LoadPUMcc();

            if (frmSummary.category == "Transferred Out PUM")
                LoadPUMto();

            if (frmSummary.category == "Death PUM")
                LoadPUMdeath();

            if (frmSummary.category == "PUI")
                LoadPUI();

            if (frmSummary.category == "Recovered")
                LoadRecovered();

            if (frmSummary.category == "Transferred Out PUI")
                LoadPUIto();

            if (frmSummary.category == "Hospital")
                LoadHospital();

            if (frmSummary.category == "Death PUI")
                LoadPUIdeath();
        }
        public async Task LoadData()
        {
            listBarangay = await repository.GetBarangaysAsync();
            listPerson = await repository.GetPeopleAsync();
            listPlace = await repository.GetPlacesAsync();
            listSymptom = await repository.GetSymptomsAsync();
            listPUI = await repository.GetPUIsAsync();
            listPUM = await repository.GetPUMsAsync();
        }
        /// <summary>
        /// Load Defaults PUM
        /// </summary>
        public void LoadPUM()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUM.Count(x => x.Status == null && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource = listPUM.Where(x => x.Status == null && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                DaysInQuarantine = (int)(DateTime.Now - x.DateArrived).TotalDays,
            }).OrderByDescending(x => x.DaysInQuarantine).ToList();
        }

        public void LoadPUMcc()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUM.Count(x => x.Status == "Case Closed" && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource = listPUM.Where(x => x.Status == "Case Closed" && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Status = x.Status,
                UpdateDate = x.StatusUpdateDate,
            }).OrderByDescending(x => x.Age).ToList();
        }

        public void LoadPUMto()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUM.Count(x => x.Status == "Transferred Out" && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource = listPUM.Where(x => x.Status == "Transferred Out" && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Status = x.Status,
                UpdateDate = x.StatusUpdateDate,
            }).OrderByDescending(x => x.Age).ToList();
        }

        public void LoadPUMdeath()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUM.Count(x => x.Status == "Death" && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource = listPUM.Where(x => x.Status == "Death" && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Status = x.Status,
                UpdateDate = x.StatusUpdateDate,
            }).OrderByDescending(x => x.Age).ToList();
        }

        /// <summary>
        /// Load Defaults PUI
        /// </summary>
        public void LoadPUI()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUI.Count(x => x.Status == null && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource =listPUI.Where(x => x.Status == null && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                ID = x.Person.ID,
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Symptoms = x.Symptoms,
            }).OrderByDescending(x => x.Age).ToList();
        }

        public void LoadRecovered()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUI.Count(x => x.Status == "Recovered" && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource =listPUI.Where(x => x.Status == "Recovered" && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Symptoms = x.Symptoms,
                Status = x.Status,
                UpdateDate = x.StatusUpdateDate,
            }).OrderByDescending(x => x.Age).ToList();
        }

        public void LoadPUIto()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUI.Count(x => x.Status == "Transferred Out" && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource = listPUI.Where(x => x.Status == "Transferred Out" && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Symptoms = x.Symptoms,
                Status = x.Status,
                UpdateDate = x.StatusUpdateDate,
                }).OrderByDescending(x => x.Age).ToList();
            }

        public void LoadPUIdeath()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUI.Count(x => x.Status == "Death" && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource = listPUI.Where(x => x.Status == "Death" && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Symptoms = x.Symptoms,
                Status = x.Status,
                UpdateDate = x.StatusUpdateDate,
            }).OrderByDescending(x => x.Age).ToList();
        }

        public void LoadHospital()
        {
            lblBarangay.Text = frmSummary.barangayName + ": " + listPUI.Count(x => x.Status == "Hospital" && x.Person.Barangay.BrgyName == frmSummary.barangayName);
            dgvSummary.DataSource = listPUI.Where(x => x.Status == "Hospital" && x.Person.Barangay.BrgyName == frmSummary.barangayName).Select(x => new
            {
                Name = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                CivilStatus = x.Person.CivilStatus,
                Nationality = x.Person.Nationality,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                Time = x.Time,
                PlaceOfOrigin = x.PlaceOfOrigin,
                Symptoms = x.Symptoms,
                Status = x.Status,
                UpdateDate = x.StatusUpdateDate,
            }).OrderByDescending(x => x.Age).ToList();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = frmSummary.barangayName;

            for (int i = 1; i <= dgvSummary.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvSummary.Columns[i - 1].HeaderText;

            for (int i = 0; i < dgvSummary.Rows.Count; i++)
            {
                for (int j = 0; j < dgvSummary.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j + 1] = dgvSummary.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }
    }
}
