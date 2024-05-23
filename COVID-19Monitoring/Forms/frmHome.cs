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
    public partial class frmHome : Form
    {
        IDataRepository repository = new DataRepository();

        List<PUI> listPUI;
        List<PUM> listPUM;
        public frmHome()
        {
            InitializeComponent();
        }

        private async void frmHome_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        async Task LoadData()
        {
            listPUM = await repository.GetPUMsAsync();
            listPUI = await repository.GetPUIsAsync();

            lblPUM.Text = listPUM.Count(x => x.Status == null).ToString();
            lblCaseClosed.Text = listPUM.Count(x => x.Status == "Case Closed").ToString();
            lblPUMtrans.Text = listPUM.Count(x => x.Status == "Transferred Out").ToString();
            lblPUMdeath.Text = listPUM.Count(x => x.Status == "Death").ToString();

            lblPUI.Text = listPUI.Count(x => x.Status == null).ToString();
            lblRecovered.Text = listPUI.Count(x => x.Status == "Recovered").ToString();
            lblPUItrans.Text = listPUI.Count(x => x.Status == "Transferred Out").ToString();
            lblHospital.Text = listPUI.Count(x => x.Status == "Hospital").ToString();
            lblPUIdeath.Text = listPUI.Count(x => x.Status == "Death").ToString();
        }
    }
}
