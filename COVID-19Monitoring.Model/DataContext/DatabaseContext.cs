using COVID_19Monitoring.Model.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Model.DataContext
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext() : base("Data Source=knevz-pc\\sqlexpress;Initial Catalog=COVID19Monitoring;Integrated Security=True")
        {

        }
        public DbSet<Person> People { get; set; }
        public DbSet<Barangay> Barangays { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<PUM> PUMs { get; set; }
        public DbSet<PUI> PUIs { get; set; }
    }
}
