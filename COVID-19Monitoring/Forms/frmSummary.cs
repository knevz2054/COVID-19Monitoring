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
    public partial class frmSummary : Form
    {
        IDataRepository repository = new DataRepository();

        List<Barangay> listBarangay;
        List<Person> listPerson;
        List<Place> listPlace;
        List<Symptom> listSymptom;
        List<PUM> listPUM;
        List<PUI> listPUI;

        public static string category;
        public static string barangayName;
        public static string graphName;
        public frmSummary()
        {
            InitializeComponent();
        }

        private async void frmSummary_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        public async Task LoadData()
        {
            listBarangay = await repository.GetBarangaysAsync();
            listPerson = await repository.GetPeopleAsync();
            listPlace = await repository.GetPlacesAsync();
            listSymptom = await repository.GetSymptomsAsync();
            listPUI = await repository.GetPUIsAsync();
            listPUM = await repository.GetPUMsAsync();

            //======================================================== Load PUM ========================================================//
            lblPUM.Text = "PUM: " + listPUM.Count(x => x.Status == null);
            dgvPUM.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUM.Count(xx => xx.Status == null && xx.Person.Barangay.BrgyName == x.BrgyName),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load Cased Closed ========================================================//
            lblCase.Text = "Case Closed: " + listPUM.Count(x => x.Status == "Case Closed");
            dgvCaseClosed.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUM.Where(xx => xx.Status == "Case Closed" && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load Transferred Out PUM ========================================================//
            lblTransferPUM.Text = "Transferred Out: " + listPUM.Count(x => x.Status == "Transferred Out");
            dgvTransferredPUM.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUM.Where(xx => xx.Status == "Transferred Out" && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load Death PUM ========================================================//
            lblDeathPUM.Text = "Death: " + listPUM.Count(x => x.Status == "Death");
            dgvDeathPUM.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUM.Where(xx => xx.Status == "Death" && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load PUI ========================================================//
            lblPUI.Text = "PUI: " + listPUI.Count(x => x.Status == null);
            dgvPUI.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUI.Where(xx => xx.Status == null && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load PUI Recovered ========================================================//
            lblRecovered.Text = "Recovered: " + listPUI.Count(x => x.Status == "Recovered");
            dgvRecovered.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUI.Where(xx => xx.Status == "Recovered" && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load Transferred Out PUI ========================================================//
            lblTransferPUI.Text = "Transferred Out: " + listPUI.Count(x => x.Status == "Transferred Out");
            dgvTransferredPUI.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUM.Where(xx => xx.Status == "Transferred Out" && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load Hospital ========================================================//
            lblHospital.Text = "In Hospital: " + listPUI.Count(x => x.Status == "Hospital");
            dgvHospital.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUI.Where(xx => xx.Status == "Hospital" && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();

            //======================================================== Load Death PUI ========================================================//
            lblDeathPUI.Text = "Death: " + listPUI.Count(x => x.Status == "Death");
            dgvDeathPUI.DataSource = listBarangay.Select(x => new
            {
                Barangay = x.BrgyName,
                Count = listPUI.Where(xx => xx.Status == "Death" && xx.Person.Barangay.BrgyName == x.BrgyName).Count(),
            }).OrderByDescending(x => x.Count).ToList();
        }

        private void dgvPUM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "PUM";
            if (dgvPUM.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvPUM.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvCaseClosed_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "Case Closed PUM";
            if (dgvCaseClosed.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvCaseClosed.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvTransferredPUM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "Transferred Out PUM";
            if (dgvTransferredPUM.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvTransferredPUM.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvDeathPUM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "Death PUM";
            if (dgvDeathPUM.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvDeathPUM.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvPUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "PUI";
            if (dgvPUI.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvPUI.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvRecovered_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "Recovered";
            if (dgvRecovered.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvRecovered.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvTransferredPUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "Transferred Out PUI";
            if (dgvTransferredPUI.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvTransferredPUI.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvHospital_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "Hospital";
            if (dgvHospital.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvHospital.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void dgvDeathPUI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            category = "Death PUI";
            if (dgvDeathPUI.Columns[e.ColumnIndex].HeaderText == "View")
            {
                barangayName = dgvDeathPUI.CurrentRow.Cells[1].Value.ToString();
                frmViewList fvl = new frmViewList();
                fvl.ShowDialog();
            }
        }

        private void btnGraphPUM_Click(object sender, EventArgs e)
        {
            graphName = "PUM";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphCaseClosed_Click(object sender, EventArgs e)
        {
            graphName = "PUM Case Closed";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphTransferredPUM_Click(object sender, EventArgs e)
        {
            graphName = "PUM Transferred";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphDeathPUM_Click(object sender, EventArgs e)
        {
            graphName = "PUM Death";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphPUI_Click(object sender, EventArgs e)
        {
            graphName = "PUI";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphRecovered_Click(object sender, EventArgs e)
        {
            graphName = "PUI Recovered";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphTransferredPUI_Click(object sender, EventArgs e)
        {
            graphName = "PUI Transferred";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphHospital_Click(object sender, EventArgs e)
        {
            graphName = "PUI Hospital";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnGraphDeathPUI_Click(object sender, EventArgs e)
        {
            graphName = "PUI Death";
            frmGraph graph = new frmGraph();
            graph.ShowDialog();
        }

        private void btnExportPUM_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUM";

            for (int i = 1; i < dgvPUM.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvPUM.Columns[i].HeaderText;

            for (int i = 0; i < dgvPUM.Rows.Count; i++)
            {
                for (int j = 1; j < dgvPUM.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvPUM.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportCaseClosed_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUM Case Closed";

            for (int i = 1; i < dgvCaseClosed.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvCaseClosed.Columns[i].HeaderText;

            for (int i = 0; i < dgvCaseClosed.Rows.Count; i++)
            {
                for (int j = 1; j < dgvCaseClosed.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvCaseClosed.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportTransferPUM_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUM Transferred Out";

            for (int i = 1; i < dgvTransferredPUM.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvTransferredPUM.Columns[i].HeaderText;

            for (int i = 0; i < dgvTransferredPUM.Rows.Count; i++)
            {
                for (int j = 1; j < dgvTransferredPUM.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvTransferredPUM.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportDeathPUM_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUM Death";

            for (int i = 1; i < dgvDeathPUM.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvDeathPUM.Columns[i].HeaderText;

            for (int i = 0; i < dgvDeathPUM.Rows.Count; i++)
            {
                for (int j = 1; j < dgvDeathPUM.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvDeathPUM.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportPUI_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUI";

            for (int i = 1; i < dgvPUI.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvPUI.Columns[i].HeaderText;

            for (int i = 0; i < dgvPUI.Rows.Count; i++)
            {
                for (int j = 1; j < dgvPUI.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvPUI.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportRecovered_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUI Recovered";

            for (int i = 1; i < dgvRecovered.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvRecovered.Columns[i].HeaderText;

            for (int i = 0; i < dgvRecovered.Rows.Count; i++)
            {
                for (int j = 1; j < dgvRecovered.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvRecovered.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportTransferPUI_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUI Transferred Out";

            for (int i = 1; i < dgvTransferredPUI.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvTransferredPUI.Columns[i].HeaderText;

            for (int i = 0; i < dgvTransferredPUI.Rows.Count; i++)
            {
                for (int j = 1; j < dgvTransferredPUI.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvTransferredPUI.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportHospital_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUI In Hospital";
            for (int i = 1; i < dgvHospital.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvHospital.Columns[i].HeaderText;

            for (int i = 0; i < dgvHospital.Rows.Count; i++)
            {
                for (int j = 1; j < dgvHospital.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvHospital.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }

        private void btnExportDeathPUI_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application ExlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = ExlApp.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "PUI Death";
            for (int i = 1; i < dgvDeathPUI.Columns.Count; i++)
                ExlApp.Cells[1, i] = dgvDeathPUI.Columns[i].HeaderText;

            for (int i = 0; i < dgvDeathPUI.Rows.Count; i++)
            {
                for (int j = 1; j < dgvDeathPUI.Columns.Count; j++)
                    ExlApp.Cells[i + 2, j] = dgvDeathPUI.Rows[i].Cells[j].Value.ToString();
            }

            ExlApp.Columns.AutoFit();
            ExlApp.Visible = true;
        }
    }
}
