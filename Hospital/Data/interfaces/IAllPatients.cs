using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data.interfaces
{
    public interface IAllPatients
    {
        IEnumerable<Patient> AllPatient { get; }

        Patient getObjectPatient(int iinPatient);
    }
}
