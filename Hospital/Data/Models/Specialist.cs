using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class Specialist
    {
        [Key]
        public int id { get; set; }
        [Required, MaxLength(20)]
        public string position { get; set; }
        [Required, MaxLength(50)]
        public string specialistFio { get; set; }
        [Required, MaxLength(50)]
        public string diagnosis { get; set; }
        [Required, MaxLength(250)]
        public string complaints { get; set; }
        public DateTime dateOfVisit { get; set; }
        public List<Patient> patients { get; set; }
    }
}
