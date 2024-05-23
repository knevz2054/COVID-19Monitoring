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
    public partial class frmAddPlace : Form
    {
        IDataRepository repository = new DataRepository();
        List<Place> listPlace;
        public frmAddPlace()
        {
            InitializeComponent();
        }
        public async Task LoadPlace()
        {
            listPlace = await repository.GetPlacesAsync();
        }
        private async void frmAddPlace_Load(object sender, EventArgs e)
        {
            await LoadPlace();

            if (frmSettings.EditPlace == true)
            {
                btnAdd.Text = "Update";
                Place place = await repository.GetPlaceByIdAsync(frmSettings.placeID);
                txtPlace.Text = place.PlaceOfOrigin;
            }
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text == "Add")
            {
                if (AddValidated())
                {
                    Place place = new Place();
                    place.PlaceOfOrigin = txtPlace.Text;
                    await repository.AddPlaceAsync(place);
                    await LoadPlace();
                    
                    if(frmSettings.addFrom == "Setting")
                    {
                        frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                        await setting.LoadPlace();
                    }

                    if (frmSettings.addFrom == "Checklist")
                    {
                        frmCheckList check = (frmCheckList)Application.OpenForms["frmCheckList"];
                        await check.LoadPlaces();
                    }
                    this.Close();
                }
            }

            if (btnAdd.Text == "Update")
            {
                if (UpdateValidated())
                {
                    Place place = await repository.GetPlaceByIdAsync(frmSettings.placeID);
                    place.PlaceOfOrigin = txtPlace.Text;
                    await repository.UpdatePlaceAsync(place);
                    await LoadPlace();
                    frmSettings setting = (frmSettings)Application.OpenForms["frmSettings"];
                    await setting.LoadPlace();
                    btnAdd.Text = "Add";
                    this.Close();
                }
            }
        }

        private bool AddValidated()
        {
            if (txtPlace.Text == string.Empty)
            {
                MessageBox.Show("Place name is required...", "Error!");
                return false;
            }
            else if (listPlace.Count(x => x.PlaceOfOrigin == txtPlace.Text) > 0)
            {
                MessageBox.Show("Place is already listed...", "Error!");
                return false;
            }
            else
            {
                MessageBox.Show(txtPlace.Text + " has been added to list of Origin of place...", "Success!");
                return true;
            }
        }

        private bool UpdateValidated()
        {
            if (txtPlace.Text == string.Empty)
            {
                MessageBox.Show("Place name is required...", "Error!");
                return false;
            }
            else if (listPlace.Count(x => x.PlaceOfOrigin == txtPlace.Text && x.ID != frmSettings.placeID) > 0)
            {
                MessageBox.Show("Place is already listed...", "Error!");
                return false;
            }
            else
            {
                MessageBox.Show("Place name has been updated...", "Success!");
                return true;
            }
        }

        private void frmAddPlace_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmSettings.EditPlace = false;
            frmSettings.addFrom = string.Empty;
        }
    }
}
