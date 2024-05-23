using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Model.Entity
{
    public class Person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "First name is required...")]
        [StringLength(50, ErrorMessage = "Too long for a first name...")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Middle name is required...")]
        [StringLength(50, ErrorMessage = "Too long for a middle name...")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last name is required...")]
        [StringLength(50, ErrorMessage = "Too long for a last name...")]
        public string LastName { get; set; }
        public int Age { get; set; }
        [StringLength(50, ErrorMessage = "Too long for a last name...")]
        public string Gender { get; set; }
        public string CivilStatus { get; set; }
      
        [StringLength(50, ErrorMessage = "Too long for a nationality...")]
        public string Nationality { get; set; }
        [StringLength(50, ErrorMessage = "Too long for a house number...")]
        public string HouseNo { get; set; }
        [StringLength(100, ErrorMessage = "Too long for a street...")]
        public string Street { get; set; }
        [StringLength(11, ErrorMessage = "Too long for a mobile number...")]
        public string Mobile { get; set; }
        [ForeignKey("Barangay")]
        public int BrgyID { get; set; }

        public virtual Barangay Barangay { get; set; }
        public virtual ICollection<PUI> PUIs { get; set; }
        public virtual ICollection<PUM> PUMs { get; set; }
    }
}
