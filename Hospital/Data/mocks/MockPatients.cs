using Hospital.Data.interfaces;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data.mocks
{
    public class MockPatients : IAllPatients
    {
        private readonly ISpecialist _specialist = new MockSpecialist();
        public IEnumerable<Patient> AllPatient {
            get
            {
                return new List<Patient> {
                    new Patient {
                        iin = 990927351465, 
                        patientfio = "Сидоров сидр сидорович", 
                        address="Pushkina-5", telephone="8876587478",
                        Specialist=_specialist.AllSpecialists.First() 
                    },
                     new Patient {
                        iin = 123547896325,
                        patientfio = "Иванов иван иванович",
                        address="Pushkina-321", telephone="+684694684",
                        Specialist=_specialist.AllSpecialists.First()
                    }
                };
            }
        }

        public Patient getObjectPatient(int iinPatient)
        {
            throw new NotImplementedException();
        }
    }
}
