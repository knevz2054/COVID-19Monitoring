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
    public partial class frmPUMstatus : Form
    {
        IDataRepository repository = new DataRepository();
        List<PUM> listPUM;
        public frmPUMstatus()
        {
            InitializeComponent();
        }

        private async void frmPUMstatus_Load(object sender, EventArgs e)
        {
            await LoadPUM();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            PUM pum = listPUM.SingleOrDefault(x => x.PersonID == frmViewPUM.personID);
            pum.Status = cbPUMstatus.Text;
            pum.StatusUpdateDate = dtpDateUpdated.Value.Date;

            DialogResult dr = MessageBox.Show("Updating the status of " + pum.Person.FirstName + " " + pum.Person.LastName + " to " + cbPUMstatus.Text + ".", "Confirmation!", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                await repository.UpdatePUMAsync(pum);
                MessageBox.Show("Status Updated...", "Success!");

                frmViewPUM list = (frmViewPUM)Application.OpenForms["frmListPUM"];
                await list.LoadPUM();
                this.Close();
            }
        }

        public async Task LoadPUM()
        {
            listPUM = await repository.GetPUMsAsync();
        }
    }
}
