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
    public partial class frmAddBarangay : Form
    {
        IDataRepository repository = new DataRepository();
        List<Barangay> listBarangay;
        public frmAddBarangay()
        {
            InitializeComponent();
        }
        public async Task LoadBarangay()
        {
            listBarangay = await repository.GetBarangaysAsync();
        }
        private async void frmAddBarangay_Load(object sender, EventArgs e)
        {
            await LoadBarangay();
            if(frmSettings.EditBarangay == true)
            {
                btnAdd.Text = "Update";
                Barangay barangay = await repository.GetBarangayByIdAsync(frmSettings.barangayID);
                txtBarangay.Text = barangay.BrgyName;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text == "Add")
            {
                if (AddValidated())
                {
                    Barangay brgy = new Barangay();
                    brgy.BrgyName = txtBarangay.Text;
                    await repository.AddBarangayAsync(brgy);
                    await LoadBarangay();
                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadBarangay();
                    this.Close();
                }
            }
            
            if(btnAdd.Text == "Update")
            {
                if (UpdateValidated())
                {
                    Barangay brgy = await repository.GetBarangayByIdAsync(frmSettings.barangayID);
                    brgy.BrgyName = txtBarangay.Text;
                    await repository.UpdateBarangayAsync(brgy);
                    await LoadBarangay();
                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadBarangay();
                    btnAdd.Text = "Add";
                    this.Close();
                }
            }
            
        }

        private bool AddValidated()
        {
            if(txtBarangay.Text == string.Empty)
            {
                MessageBox.Show("Barangay name is required...", "Error!");
                return false;
            }
            else if(listBarangay.Count(x => x.BrgyName == txtBarangay.Text) > 0)
            {
                MessageBox.Show("Barangay is already listed...", "Error!");
                return false;
            }
            else
            {
                MessageBox.Show(txtBarangay.Text + " has been added to list of Barangay...", "Success!");
                return true;
            }
        }

        private bool UpdateValidated()
        {
            if (txtBarangay.Text == string.Empty)
            {
                MessageBox.Show("Barangay name is required...", "Error!");
                return false;
            }
            else if (listBarangay.Count(x => x.BrgyName == txtBarangay.Text && x.ID != frmSettings.barangayID) > 0)
            {
                MessageBox.Show("Barangay is already listed...", "Error!");
                return false;
            }
            else
            {
                MessageBox.Show("Barangay name has been updated...", "Success!");
                return true;
            }
        }

        private void frmAddBarangay_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSettings.EditBarangay = false;
        }
    }
}
