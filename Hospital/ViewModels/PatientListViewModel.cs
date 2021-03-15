using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.ViewModels
{
    public class PatientListViewModel
    {
        public IEnumerable<Patient> allPatients { get; set; }

        public string currSpecialist { get; set; }
    }
}
