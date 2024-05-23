using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COVID_19Monitoring.Model.Entity
{
    public class PUM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        [ForeignKey("Person")]
        public int PersonID { get; set; }
        public DateTime DateArrived { get; set; }
        [StringLength(15, ErrorMessage = "Too long for a time...")]
        public string Time { get; set; }
        [StringLength(20, ErrorMessage = "Too long for a bus number...")]
        public string Bus { get; set; }
        [StringLength(50, ErrorMessage = "Too long for a status...")]
        public string Status { get; set; }
        public DateTime? StatusUpdateDate { get; set; }
        [StringLength(15, ErrorMessage = "Too long for a place of origin...")]
        public string PlaceOfOrigin { get; set; }

        public virtual Person Person { get; set; }
    }
}
