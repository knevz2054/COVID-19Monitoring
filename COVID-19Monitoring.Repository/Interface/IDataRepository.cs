using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.Interface
{
    public interface IDataRepository
    {
        Task<List<Barangay>> GetBarangaysAsync();
        Task<Barangay> GetBarangayByIdAsync(int id);
        Task<Barangay> AddBarangayAsync(Barangay barangay);
        Task<Barangay> UpdateBarangayAsync(Barangay barangay);
        Task<Barangay> DeleteBarangayAsync(int id);

        Task<List<Person>> GetPeopleAsync();
        Task<Person> GetPersonAsync(int id);
        Task<Person> AddPersonAsync(Person person);
        Task<Person> UpdatePersonAsync(Person person);
        Task<Person> DeletePersonAsync(int id);

        Task<List<Place>> GetPlacesAsync();
        Task<Place> GetPlaceByIdAsync(int id);
        Task<Place> AddPlaceAsync(Place place);
        Task<Place> UpdatePlaceAsync(Place place);
        Task<Place> DeletePlaceAsync(int id);

        Task<List<PUI>> GetPUIsAsync();
        Task<PUI> GetPUIByIdAsync(int id);
        Task<PUI> AddPUIAsync(PUI pui);
        Task<PUI> UpdatePUIAsync(PUI pui);
        Task<PUI> DeletePUIAsync(int id);

        Task<List<PUM>> GetPUMsAsync();
        Task<PUM> GetPUMByIdAsync(int id);
        Task<PUM> AddPUMAsync(PUM pum);
        Task<PUM> UpdatePUMAsync(PUM pum);
        Task<PUM> DeletePUMAsync(int id);

        Task<List<Symptom>> GetSymptomsAsync();
        Task<Symptom> GetSymptomByIdAsync(int id);
        Task<Symptom> AddSymptomAsync(Symptom symptom);
        Task<Symptom> UpdateSymptomAsync(Symptom symptom);
        Task<Symptom> DeleteSymptomAsync(int id);
    }
}
