using Hospital.Data.interfaces;
using Hospital.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data.Repository
{
    public class SpecialistRepository : ISpecialist
    {
        public readonly AppDBContent appDBContent;

        public SpecialistRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Specialist> AllSpecialists => appDBContent.Specialist;
    }
}
