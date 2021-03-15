using Hospital.Data;
using Hospital.Data.interfaces;
using Hospital.Data.Models;
using Hospital.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Controllers
{
    public class PatientsController : Controller
    {
        private readonly IAllPatients _allPatients;
        private readonly ISpecialist _allSpecialist;
        //private readonly AppDBContent _content;

        public PatientsController(IAllPatients allPatients, ISpecialist allSpecialist)
        {
            _allPatients = allPatients;
            _allSpecialist = allSpecialist;
        }

        public ViewResult List()
        {
            ViewBag.Title = "Cтраница с пациентами";
            PatientListViewModel obj = new PatientListViewModel();
            obj.allPatients =_allPatients.AllPatient;
            //obj.currSpecialist = "Доктор";
            return View(obj);
        }

        public ViewResult Create(Patient patient)
        {
            PatientListViewModel obj = new PatientListViewModel();
            
            
            //_content.Add(patient);
            //_content.SaveChanges();
            return View();
        }

        public ViewResult Update(Patient patient)
        {
            //_content.Update(patient);
            //_content.SaveChanges();
            return View();
        }
        public ViewResult Delete(Patient patient)
        {
            //_content.Remove(patient);
            //_content.SaveChanges();
            return View();

        }


 

    }
}
