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
    public partial class frmPUIstatus : Form
    {
        IDataRepository repository = new DataRepository();
        List<PUI> listPUI;
        public frmPUIstatus()
        {
            InitializeComponent();
        }

        private async void frmPUIstatus_Load(object sender, EventArgs e)
        {
            await LoadPUI();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            PUI pui = listPUI.SingleOrDefault(x => x.PersonID == frmViewPUI.personID);
            pui.Status = cbPUIstatus.Text;
            pui.StatusUpdateDate = dtpDateUpdated.Value.Date;

            DialogResult dr = MessageBox.Show("Updating the status of " + pui.Person.FirstName + " " + pui.Person.LastName + " to " + cbPUIstatus.Text + ".", "Confirmation!", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                await repository.UpdatePUIAsync(pui);
                MessageBox.Show("Status Updated...", "Success!");

                frmViewPUI list = (frmViewPUI)Application.OpenForms["frmListPUI"];
                await list.LoadPUI();
                this.Close();
            }
        }

        public async Task LoadPUI()
        {
            listPUI = await repository.GetPUIsAsync();
        }
    }
}
