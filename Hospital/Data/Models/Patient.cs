using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data.Models
{
    public class Patient
    {
        [Key]
        public int id { get; set; }
        [Required]
        public long iin { get; set; }
        [Required, MaxLength(50)]
        public string patientfio { get; set; }
        [Required, MaxLength(50)]
        public string address { get; set; }
        [RegularExpression(@"^\(?([0-9]{3})\)?[-.●]?([0-9]{3})[-.●]?([0-9]{4})$",
            ErrorMessage = "неверный формат телефона")]
        public string telephone { get; set; }
        public int specialistID { get; set; }
        public virtual Specialist Specialist { get; set; }



    }
}
