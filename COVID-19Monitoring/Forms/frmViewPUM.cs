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
using System.Data.Entity;

namespace COVID_19Monitoring.Forms
{
    public partial class frmViewPUM : Form
    {
        IDataRepository repository = new DataRepository();

        List<PUM> listPUM;

        public DateTime Now = DateTime.Now;
        public static int personID;
        public static string status;
        public frmViewPUM()
        {
            InitializeComponent();
        }

        private async void frmListPUM_Load(object sender, EventArgs e)
        {
           await LoadPUM();
        }
        public async Task LoadPUM()
        {
            listPUM = await repository.GetPUMsAsync();

            lblPUM.Text = "PUM's: " + listPUM.Count(x => x.Status == null);

            dgvPUM.DataSource = listPUM.Where(x => x.Status == null).Select(x => new
            {
                ID = x.Person.ID,
                FullName = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                Bus = x.Bus,
                DateArrived = x.DateArrived,
                DaysInQuarantine =  (int)(DateTime.Now - x.DateArrived).TotalDays,
                Status = x.Status,
                DateModified = x.StatusUpdateDate,

            }).OrderByDescending(x => x.DaysInQuarantine).ToList();
        }

        private async void dgvPUM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(listPUM.Count(x => x.Status == null) != 0)
            {
                if (dgvPUM.Columns[e.ColumnIndex].HeaderText == "Update Status")
                {
                    status = "PUM";
                    personID = int.Parse(dgvPUM.CurrentRow.Cells[2].Value.ToString());

                    frmPUMstatus obj = new frmPUMstatus();
                    obj.ShowDialog();
                }

                if (dgvPUM.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    personID = int.Parse(dgvPUM.CurrentRow.Cells[2].Value.ToString());
                    DialogResult dr = MessageBox.Show("Are you sure to delete selected Person Under Monitoring?", "Warning!", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        PUM pum = listPUM.SingleOrDefault(x => x.PersonID == personID);

                        await repository.DeletePUMAsync(pum.ID);
                        await repository.DeletePersonAsync(personID);
                        await LoadPUM();
                    }
                }
            }
        }
    }
}
