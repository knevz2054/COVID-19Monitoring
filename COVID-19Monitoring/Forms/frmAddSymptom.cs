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
    public partial class frmAddSymptom : Form
    {
        IDataRepository repository = new DataRepository();
        List<Symptom> listSymptom;
        public frmAddSymptom()
        {
            InitializeComponent();
        }
        public async Task LoadSymptom()
        {
            listSymptom = await repository.GetSymptomsAsync();
        }
        private async void frmAddSymptom_Load(object sender, EventArgs e)
        {
            await LoadSymptom();

            if (frmSettings.EditSympton == true)
            {
                btnAdd.Text = "Update";
                Symptom symptom = await repository.GetSymptomByIdAsync(frmSettings.symptomID);
                txtSymptom.Text = symptom.Indication;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (AddValidated())
                {
                    Symptom symptom = new Symptom();
                    symptom.Indication = txtSymptom.Text;
                    await repository.AddSymptomAsync(symptom);
                    await LoadSymptom();
                    if (frmSettings.addFrom == "Setting")
                    {
                        frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                        await setting.LoadSymptom();
                    }
                    if (frmSettings.addFrom == "Checklist")
                    {
                        frmCheckList check = (frmCheckList)Application.OpenForms["frmCheckList"];
                        await check.LoadSymptoms();
                    }

                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (UpdateValidated())
                {
                    Symptom symptom = await repository.GetSymptomByIdAsync(frmSettings.symptomID);
                    symptom.Indication = txtSymptom.Text;
                    await repository.UpdateSymptomAsync(symptom);
                    await LoadSymptom();
                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadSymptom();
                    btnAdd.Text = "Add";
                    this.Close();
                }
            }
        }

        private bool AddValidated()
        {
            if (txtSymptom.Text == string.Empty)
            {
                MessageBox.Show("Symptom is required...", "Error!");
                return false;
            }
            else if (listSymptom.Count(x => x.Indication == txtSymptom.Text) > 0)
            {
                MessageBox.Show("Symptom is already listed...", "Error!");
                return false;
            }
            else
            {
                MessageBox.Show(txtSymptom.Text + " has been added to list of symptoms...", "Success!");
                return true;
            }
        }

        private bool UpdateValidated()
        {
            if (txtSymptom.Text == string.Empty)
            {
                MessageBox.Show("Symptom is required...", "Error!");
                return false;
            }
            else if (listSymptom.Count(x => x.Indication == txtSymptom.Text && x.ID != frmSettings.symptomID) > 0)
            {
                MessageBox.Show("Symptom is already listed...", "Error!");
                return false;
            }
            else
            {
                MessageBox.Show("Symptom has been updated...", "Success!");
                return true;
            }
        }

        private void frmAddSymptom_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSettings.EditSympton = false;
            frmSettings.addFrom = string.Empty;
        }
    }
}
