using Hospital.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Specialist.Any())
                content.Specialist.AddRange(Specialists.Select(c => c.Value));

            if (!content.Patient.Any()) {
                content.AddRange(
                    new Patient
                    {
                        iin = 123456456123,
                        patientfio = "Сидоров сидр сидорович",
                        address = "Pushkina-5",
                        telephone = "8876587478",
                        Specialist = Specialists["Терапевт"]
                    },
                     new Patient
                     {
                         iin = 123547896325,
                         patientfio = "Иванов иван иванович",
                         address = "Pushkina-321",
                         telephone = "5684694684",
                         Specialist = Specialists["Терапевт"]
                     }
               );
            }
            content.SaveChanges();
        }


        private static Dictionary<string, Specialist> specialist;
        public static Dictionary<string, Specialist> Specialists
        {
            get
            {
                if (specialist == null)
                {
                    var list = new Specialist[] {
                        new Specialist {position="Терапевт",specialistFio="Петров петр петрович",diagnosis="qqqq",complaints="qwr"}
                    };

                    specialist = new Dictionary<string, Specialist>();

                    foreach (Specialist el in list)
                    {
                        specialist.Add(el.position, el);
                    }
                }
                return specialist;
            }
        }


        public void Create()
        {
          
  
        } 
        public void Update()
        {
            
        }
        public void Delete ()
        {
            
        }  
        

    }
}

