using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using COVID_19Monitoring.Forms;

namespace COVID_19Monitoring
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmHome home = new frmHome();
            home.TopLevel = false;
            pnlContent.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnPUI.Enabled = true;
            btnPUM.Enabled = true;
            btnSummary.Enabled = true;
            btnSettings.Enabled = true;
            btnHome.Enabled = false;
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmCheckList checklist = new frmCheckList();
            checklist.TopLevel = false;
            pnlContent.Controls.Add(checklist);
            checklist.Dock = DockStyle.Fill;
            checklist.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = false;
            btnPUI.Enabled = true;
            btnPUM.Enabled = true;
            btnSummary.Enabled = true;
            btnSettings.Enabled = true;
            btnHome.Enabled = true;
        }

        private void btnPUM_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmViewPUM flp = new frmViewPUM();
            flp.TopLevel = false;
            pnlContent.Controls.Add(flp);
            flp.Dock = DockStyle.Fill;
            flp.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnPUI.Enabled = true;
            btnPUM.Enabled = false;
            btnSummary.Enabled = true;
            btnSettings.Enabled = true;
            btnHome.Enabled = true;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmSummary summary = new frmSummary();
            summary.TopLevel = false;
            pnlContent.Controls.Add(summary);
            summary.Dock = DockStyle.Fill;
            summary.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnPUI.Enabled = true;
            btnPUM.Enabled = true;
            btnSummary.Enabled = false;
            btnSettings.Enabled = true;
            btnHome.Enabled = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmSettings setting = new frmSettings();
            setting.TopLevel = false;
            pnlContent.Controls.Add(setting);
            setting.Dock = DockStyle.Fill;
            setting.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnPUI.Enabled = true;
            btnPUM.Enabled = true;
            btnSummary.Enabled = true;
            btnSettings.Enabled = false;
            btnHome.Enabled = true;
        }

        private void btnPUI_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmViewPUI flp = new frmViewPUI();
            flp.TopLevel = false;
            pnlContent.Controls.Add(flp);
            flp.Dock = DockStyle.Fill;
            flp.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnPUI.Enabled = false;
            btnPUM.Enabled = true;
            btnSummary.Enabled = true;
            btnSettings.Enabled = true;
            btnHome.Enabled = true;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Application.OpenForms.OfType<Form>().Where(x => x.Name != "Main").ToList().ForEach(x => x.Close());
            frmHome home = new frmHome();
            home.TopLevel = false;
            pnlContent.Controls.Add(home);
            home.Dock = DockStyle.Fill;
            home.Show();

            btnHome.Enabled = true;
            btnForm.Enabled = true;
            btnPUI.Enabled = true;
            btnPUM.Enabled = true;
            btnSummary.Enabled = true;
            btnSettings.Enabled = true;
            btnHome.Enabled = false;
        }
    }
}
