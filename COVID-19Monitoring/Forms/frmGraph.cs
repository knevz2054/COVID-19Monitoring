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
using System.Windows.Forms.DataVisualization.Charting;

namespace COVID_19Monitoring.Forms
{
    public partial class frmGraph : Form
    {
        IDataRepository repository = new DataRepository();

        List<Barangay> listBarangay;
        List<PUM> listPUM;
        List<PUI> listPUI; 
        public frmGraph()
        {
            InitializeComponent();
        }

        private async void frmGraph_Load(object sender, EventArgs e)
        {
            await LoadData();

            if(frmSummary.graphName == "PUM")
            {
                chart1.Series[0].Name = "PUM";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count  = listPUM.Count(xx => xx.Status == null && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();
                
                GridGraph();
                
                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUM Case Closed")
            {
                chart1.Series[0].Name = "PUM Case Closed";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUM.Count(xx => xx.Status == "Case Closed" && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUM Transferred")
            {
                chart1.Series[0].Name = "PUM Transferred Out";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUM.Count(xx => xx.Status == "Transferred Out" && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUM Death")
            {
                chart1.Series[0].Name = "PUM Death";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUM.Count(xx => xx.Status == "Death" && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUI")
            {
                chart1.Series[0].Name = "PUI";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUI.Count(xx => xx.Status == null && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUI Recovered")
            {
                chart1.Series[0].Name = "PUI Recovered";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUI.Count(xx => xx.Status == "Recovered" && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUI Transferred")
            {
                chart1.Series[0].Name = "PUI Transferred Out";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUI.Count(xx => xx.Status == "Transferred Out" && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUI Hospital")
            {
                chart1.Series[0].Name = "PUI In Hospital";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUI.Count(xx => xx.Status == "Hospital" && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

            if (frmSummary.graphName == "PUI Death")
            {
                chart1.Series[0].Name = "PUI Death";

                var DataList = listBarangay.Select(x => new
                {
                    Barangay = x.BrgyName,
                    Count = listPUM.Count(xx => xx.Status == "Death" && xx.Person.Barangay.BrgyName == x.BrgyName),
                }).OrderByDescending(x => x.Count).ToList();

                GridGraph();

                int i = 0;
                foreach (var item in DataList)
                {
                    this.chart1.Series[0].Points.AddXY(item.Barangay, item.Count);
                    this.chart1.Series[0].Points[i].Label = item.Count.ToString();
                    i++;
                }
            }

        }
        public async Task LoadData()
        {
            listBarangay = await repository.GetBarangaysAsync();
            listPUI = await repository.GetPUIsAsync();
            listPUM = await repository.GetPUMsAsync();
        }
        public void GridGraph()
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;
            chart1.ChartAreas["ChartArea1"].AxisY.Interval = 50;
            chart1.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisX.MinorGrid.LineWidth = 0;
            chart1.ChartAreas["ChartArea1"].AxisY.MinorGrid.LineWidth = 0;
        }
    }
}
