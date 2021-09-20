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
            List<UsersViewModel> _UsersViewModel = new List<UsersViewModel>();
            //fetch from database
            try
            {
                var list = _db.Users.ToList();

                foreach (var user in list)
                {
                    _UsersViewModel.Add(new UsersViewModel { Email = user.Email, FirstName = user.FirstName });
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