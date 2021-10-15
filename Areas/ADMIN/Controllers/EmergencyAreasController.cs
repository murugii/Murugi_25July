using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Murugi_25July.Models;

namespace Murugi_25July.Areas.ADMIN.Controllers
{
    public class EmergencyAreasController : Controller
    {
        EmergencyMedicalAndAmbulanceDispatchEntities _db = new EmergencyMedicalAndAmbulanceDispatchEntities();
        // GET: ADMIN/EmergencyAreas
        public ActionResult Index()
        {

            List<ViewModels.EmergencyAreas> _EmergencyAreasViewModel = new List<ViewModels.EmergencyAreas>();
            //fetch from database
            try
            {
                using(var db = new EmergencyMedicalAndAmbulanceDispatchEntities())
                {
                    var list = db.EmergencyLocations.ToList();

                    foreach (var area in list)
                    {
                        _EmergencyAreasViewModel.Add(new ViewModels.EmergencyAreas { Id = area.Id, Description = area.Description });
                    }
                }                

            }
            catch (Exception es)
            {

            }

            return View(_EmergencyAreasViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}