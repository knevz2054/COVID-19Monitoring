using COVID_19Monitoring.Model.DataContext;
using COVID_19Monitoring.Model.Entity;
using COVID_19Monitoring.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Repository.DataProvider
{
    public class DataRepository : IDataRepository
    {
        DatabaseContext _db = new DatabaseContext();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="barangay"></param>
        /// <returns></returns>
        public async Task<Barangay> AddBarangayAsync(Barangay barangay)
        {
            _db.Barangays.Add(barangay);
            await _db.SaveChangesAsync();
            return barangay;
        }

        public async Task<Barangay> DeleteBarangayAsync(int id)
        {
            Barangay barangay = await _db.Barangays.FindAsync(id);
            _db.Barangays.Remove(barangay);
            await _db.SaveChangesAsync();
            return barangay;
        }

        public async Task<Barangay> GetBarangayByIdAsync(int id)
        {
            return await _db.Barangays.FindAsync(id);
        }

        public async Task<List<Barangay>> GetBarangaysAsync()
        {
            return await _db.Barangays.AsNoTracking().ToListAsync();
        }

        public async Task<Barangay> UpdateBarangayAsync(Barangay barangay)
        {
            _db.Entry(barangay).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return barangay;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        public async Task<Person> AddPersonAsync(Person person)
        {
            _db.People.Add(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<Person> DeletePersonAsync(int id)
        {
            Person person = await _db.People.FindAsync(id);
            _db.People.Remove(person);
            await _db.SaveChangesAsync();
            return person;
        }

        public async Task<List<Person>> GetPeopleAsync()
        {
            return await _db.People.AsNoTracking().ToListAsync();
        }

        public async Task<Person> GetPersonAsync(int id)
        {
            return await _db.People.FindAsync(id);
        }

        public async Task<Person> UpdatePersonAsync(Person person)
        {
            _db.Entry(person).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return person;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="place"></param>
        /// <returns></returns>
        public async Task<Place> AddPlaceAsync(Place place)
        {
            _db.Places.Add(place);
            await _db.SaveChangesAsync();
            return place;
        }

        public async Task<Place> DeletePlaceAsync(int id)
        {
            Place place = await _db.Places.FindAsync(id);
            _db.Places.Remove(place);
            await _db.SaveChangesAsync();
            return place;
        }

        public async Task<Place> GetPlaceByIdAsync(int id)
        {
            return await _db.Places.FindAsync(id);
        }

        public async Task<List<Place>> GetPlacesAsync()
        {
            return await _db.Places.AsNoTracking().OrderBy(x => x.PlaceOfOrigin).ToListAsync();
        }

        public async Task<Place> UpdatePlaceAsync(Place place)
        {
            _db.Entry(place).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return place;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pum"></param>
        /// <returns></returns>
        public async Task<PUM> AddPUMAsync(PUM pum)
        {
            _db.PUMs.Add(pum);
            await _db.SaveChangesAsync();
            return pum;
        }

        public async Task<PUM> DeletePUMAsync(int id)
        {
            PUM pum = await _db.PUMs.FindAsync(id);
            _db.PUMs.Remove(pum);
            await _db.SaveChangesAsync();
            return pum;
        }

        public async Task<PUM> GetPUMByIdAsync(int id)
        {
            return await _db.PUMs.FindAsync(id);
        }

        public async Task<List<PUM>> GetPUMsAsync()
        {
            return await _db.PUMs.AsNoTracking().ToListAsync();
        }

        public async Task<PUM> UpdatePUMAsync(PUM pum)
        {
            _db.Entry(pum).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return pum;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="pui"></param>
        /// <returns></returns>
        public async Task<PUI> AddPUIAsync(PUI pui)
        {
            _db.PUIs.Add(pui);
            await _db.SaveChangesAsync();
            return pui;
        }

        public async Task<PUI> DeletePUIAsync(int id)
        {
            PUI pui = await _db.PUIs.FindAsync(id);
            _db.PUIs.Remove(pui);
            await _db.SaveChangesAsync();
            return pui;
        }

        public async Task<PUI> GetPUIByIdAsync(int id)
        {
            return await _db.PUIs.FindAsync(id);
        }

        public async Task<List<PUI>> GetPUIsAsync()
        {
            return await _db.PUIs.AsNoTracking().ToListAsync();
        }

        public async Task<PUI> UpdatePUIAsync(PUI pui)
        {
            _db.Entry(pui).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return pui;
        }

        public async Task<Symptom> AddSymptomAsync(Symptom symptom)
        {
            _db.Symptoms.Add(symptom);
            await _db.SaveChangesAsync();
            return symptom;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<Symptom> DeleteSymptomAsync(int id)
        {
            Symptom symptom = await _db.Symptoms.FindAsync(id);
            _db.Symptoms.Remove(symptom);
            await _db.SaveChangesAsync();
            return symptom;
        }

        public async Task<Symptom> GetSymptomByIdAsync(int id)
        {
            return await _db.Symptoms.FindAsync(id);
        }

        public async Task<List<Symptom>> GetSymptomsAsync()
        {
            return await _db.Symptoms.AsNoTracking().OrderBy(x => x.Indication).ToListAsync();
        }

        public async Task<Symptom> UpdateSymptomAsync(Symptom symptom)
        {
            _db.Entry(symptom).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return symptom;
        }
    }
}
