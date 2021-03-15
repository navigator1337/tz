using Hospital.Data.interfaces;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data.mocks
{
    public class MockSpecialist : ISpecialist
    {
        public IEnumerable<Specialist> AllSpecialists {
            get{
                return new List<Specialist> {
                    new Specialist {position="Терапевт",specialistFio="Петров петр петрович",diagnosis="qqqq",complaints="qwr"}
                };
            }
        }

       
    }
}
