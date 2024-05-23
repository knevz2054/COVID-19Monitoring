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
    public partial class frmCheckList : Form
    {
        IDataRepository repository = new DataRepository();

        List<Barangay> listBarangay;
        List<Place> listPlace;
        List<Symptom> listSymptom;

        public int textBoxCount;
        public frmCheckList()
        {
            InitializeComponent();
        }

        private async void frmCheckList_Load(object sender, EventArgs e)
        {
            await LoadData();
            foreach (var item in listBarangay)
            {
                cbBarangay.Items.Add(item.BrgyName);
            }

            if (listPlace.Count() > 0)
                await LoadPlaces();

            if (listSymptom.Count() > 0)
                await LoadSymptoms();
        }

        async Task LoadData()
        {
            listBarangay = await repository.GetBarangaysAsync();
            listPlace = await repository.GetPlacesAsync();
            listSymptom = await repository.GetSymptomsAsync();

        }
        private void btnAddPlace_Click(object sender, EventArgs e)
        {
            frmSettings.addFrom = "Checklist";
            frmAddPlace fap = new frmAddPlace();
            fap.ShowDialog();
        }

        private async void btnRefreshPlace_Click(object sender, EventArgs e)
        {
            listPlace = await repository.GetPlacesAsync();
            if (listPlace.Count() > 0)
                await LoadPlaces();
        }

        private void btnAddSymptoms_Click(object sender, EventArgs e)
        {
            frmSettings.addFrom = "Checklist";
            frmAddSymptom fas = new frmAddSymptom();
            fas.ShowDialog();
        }

        private async void btnRefreshSymptoms_Click(object sender, EventArgs e)
        {
            listSymptom = await repository.GetSymptomsAsync();
            if (listSymptom.Count() > 0)
                await LoadSymptoms();
        }

        public async Task LoadPlaces()
        {
            lvPlaces.Items.Clear();
            int num = 1;

            foreach (var item in await repository.GetPlacesAsync())
            {
                ListViewItem lvi = new ListViewItem(num.ToString() + ")");
                lvi.SubItems.Add(item.PlaceOfOrigin);
                lvPlaces.Items.Add(lvi);
                num++;
            }
        }

        public async Task LoadSymptoms()
        {
            lvSymptoms.Items.Clear();
            int num = 1;

            foreach (var item in await repository.GetSymptomsAsync())
            {
                ListViewItem lvi = new ListViewItem(num.ToString() + ")");
                lvi.SubItems.Add(item.Indication);
                lvSymptoms.Items.Add(lvi);
                num++;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (AddValidated())
            {
                try
                {
                    Person person = new Person();
                    btnSubmit.Enabled = false;
                    person.FirstName = txtFirstName.Text.Trim();
                    person.MiddleName = txtMiddleName.Text.Trim();
                    person.LastName = txtLastName.Text.Trim();
                    person.Age = int.Parse(txtAge.Text);
                    person.Gender = cbGender.Text;
                    person.CivilStatus = cbCivilStatus.Text;
                    person.Nationality = txtNationality.Text.Trim();
                    person.HouseNo = txtHouseNo.Text.Trim();
                    person.Street = txtStreet.Text.Trim();
                    person.BrgyID = listBarangay.Where(x => x.BrgyName == cbBarangay.Text).Select(x => x.ID).SingleOrDefault();
                    person.Mobile = txtMobile.Text.Trim();

                    await repository.AddPersonAsync(person);

                    if (lvSymptoms.CheckedItems.Count == 0)
                    {
                        string Places = "";
                        PUM pum = new PUM();
                        pum.Bus = txtBus.Text;
                        pum.PersonID = person.ID;
                        pum.DateArrived = dtpArrived.Value.Date;
                        pum.Time = txtTime.Text.Trim();

                        for (int i = 0; i < lvPlaces.CheckedItems.Count; i++)
                            Places += lvPlaces.CheckedItems[i].SubItems[1].Text + " ";

                        pum.PlaceOfOrigin = Places;

                        await repository.AddPUMAsync(pum);

                        MessageBox.Show(person.FirstName + " " + person.LastName + " has been added to list of PUMs");
                        FindControls<TextBox>(this).Where(x => x.Text != string.Empty).ToList().ForEach(x => x.Clear());
                        FindControls<ComboBox>(this).Where(x => x.SelectedItem != null).ToList().ForEach(x => x.SelectedItem = null);
                        dtpArrived.Value = DateTime.Today;

                        await LoadPlaces();
                    }

                    else
                    {
                        string symptoms = "";
                        string Places = "";
                        PUI pui = new PUI();
                        pui.PersonID = person.ID;
                        pui.Bus = txtBus.Text;
                        pui.DateArrived = dtpArrived.Value.Date;
                        pui.Time = txtTime.Text.Trim();

                        for (int i = 0; i < lvSymptoms.CheckedItems.Count; i++)
                            symptoms += lvSymptoms.CheckedItems[i].SubItems[1].Text + " ";

                        for (int i = 0; i < lvPlaces.CheckedItems.Count; i++)
                            Places += lvPlaces.CheckedItems[i].SubItems[1].Text + " ";

                        pui.Symptoms = symptoms;
                        pui.PlaceOfOrigin = Places;
                        pui.Onset = dtpOnset.Value.Date;

                        await repository.AddPUIAsync(pui);

                        MessageBox.Show(person.FirstName + " " + person.LastName + " has been added to list of PUIs");
                        FindControls<TextBox>(this).Where(x => x.Text != string.Empty).ToList().ForEach(x => x.Clear());
                        FindControls<ComboBox>(this).Where(x => x.SelectedItem != null).ToList().ForEach(x => x.SelectedItem = null);
                        dtpArrived.Value = DateTime.Today;
                        await LoadPlaces();
                        await LoadSymptoms();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                btnSubmit.Enabled = true;
            }
        }
        public IEnumerable<T> FindControls<T>(Control control) where T : Control
        {
            // we can't cast here because some controls in here will most likely not be <T>
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => FindControls<T>(ctrl))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == typeof(T)).Cast<T>();
        }
        private void lvSymptoms_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            dtpOnset.Enabled = lvSymptoms.CheckedItems.Count != 0;
            if (dtpOnset.Enabled == false)
                dtpOnset.Value = DateTime.Today.Date;
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public bool AddValidated()
        {
            textBoxCount = FindControls<TextBox>(this).Count();
            var listTextBoxes = FindControls<TextBox>(this).Where(x => x.Text != string.Empty).ToList();
            var listComboBoxes = FindControls<ComboBox>(this).Where(x => x.SelectedItem == null).ToList();
            if (listTextBoxes.Count() != textBoxCount || listComboBoxes.Count() > 0)
            {
                MessageBox.Show("All fields in personal data are required. Put NS on fields with no data...", "Failed to Submit!");
                return false;
            }
            else if (lvPlaces.CheckedItems.Count == 0)
            {
                MessageBox.Show("Place of Origin is Required...", "Failed to Submit!");
                return false;
            }

            else if (dtpArrived.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Date arrived is later than current date...", "Failed to Submit!");
                return false;
            }

            else if (dtpOnset.Value.Date > DateTime.Today.Date)
            {
                MessageBox.Show("Onset of Symptoms is later than current date...", "Failed to Submit!");
                return false;
            }
            else
                return true;
        }
    }
}
