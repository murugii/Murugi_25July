using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Murugi_25July.Models;
using Murugi_25July.ViewModels;
using Newtonsoft.Json;

namespace Murugi_25July.Areas.ADMIN.Controllers
{
    public class AmbulancesController : Controller
    {
        EmergencyMedicalAndAmbulanceDispatchEntities _db = new EmergencyMedicalAndAmbulanceDispatchEntities();
        // GET: ADMIN/Ambulances
        public ActionResult Index()
        {
            List<AmbulancesViewModel> _UsersViewModel = new List<AmbulancesViewModel>();
            //fetch from database
            try
            {
                var list = _db.Vehicles.ToList();

                foreach (var user in list)
                {
                    _UsersViewModel.Add(new AmbulancesViewModel { RegistrationNumber = user.RegistrationNumber, VehicleType = user.VehicleType, Color = user.Color });
                }

            }
            catch (Exception es)
            {

            }

            return View(_UsersViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}