using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Model.Entity
{
    public class Barangay
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [Required(ErrorMessage = "Barangay name is required...")]
        [StringLength(100, ErrorMessage = "Too long for a barangay name...")]
        public string BrgyName { get; set; }
        public virtual ICollection <Person> People { get; set; }
    }
}
