using Hospital.Data.interfaces;
using Hospital.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data.Repository
{
    public class PatientsRepository : IAllPatients
    {
        public readonly AppDBContent appDBContent;

        public PatientsRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Patient> AllPatient => appDBContent.Patient.Include(c => c.Specialist);

        public Patient getObjectPatient(int iinPatient) => appDBContent.Patient.FirstOrDefault(p => p.iin == iinPatient);


    }
}
