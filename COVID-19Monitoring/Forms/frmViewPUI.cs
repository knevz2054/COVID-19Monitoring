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
    public partial class frmViewPUI : Form
    {
        IDataRepository repository = new DataRepository();

        List<PUI> listPUI;

        public DateTime Now = DateTime.Now;
        public static int personID;
        public static string status;
        public frmViewPUI()
        {
            InitializeComponent();
        }

        private async void frmListPUI_Load(object sender, EventArgs e)
        {
            await LoadPUI();
        }
        public async Task LoadPUI()
        {
            listPUI = await repository.GetPUIsAsync();
            lblPUI.Text = "PUI's: " + listPUI.Count(x => x.Status == null);

            dgvPUI.DataSource = listPUI.Where(x => x.Status == null).Select(x => new
            {
                ID = x.Person.ID,
                FullName = x.Person.LastName + ", " + x.Person.FirstName,
                Age = x.Person.Age,
                Gender = x.Person.Gender,
                HouseNo = x.Person.HouseNo,
                Street = x.Person.Street,
                Barangay = x.Person.Barangay.BrgyName,
                Contact = x.Person.Mobile,
                DateArrived = x.DateArrived,
                Symptoms = x.Symptoms,
                OnSet = x.Onset,
                Status = x.Status,
                DateModified = x.StatusUpdateDate,
            }).ToList();
        }

        private async void dgvPUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if(listPUI.Count(x => x.Status == null) != 0)
            {
                if (dgvPUI.Columns[e.ColumnIndex].HeaderText == "Update Status")
                {
                    status = "PUI";
                    personID = int.Parse(dgvPUI.CurrentRow.Cells[2].Value.ToString());

                    frmPUIstatus obj = new frmPUIstatus();
                    obj.ShowDialog();
                }

                if (dgvPUI.Columns[e.ColumnIndex].HeaderText == "Delete")
                {
                    personID = int.Parse(dgvPUI.CurrentRow.Cells[2].Value.ToString());
                    DialogResult dr = MessageBox.Show("Are you sure to delete selected Person Under Invistigation?", "Warning!", MessageBoxButtons.OKCancel);
                    if (dr == DialogResult.OK)
                    {
                        PUI pui = listPUI.SingleOrDefault(x => x.PersonID == personID);

                        await repository.DeletePUIAsync(personID);
                        await repository.DeletePersonAsync(personID);
                        await LoadPUI();
                    }
                }
            }
        }
    }
}
