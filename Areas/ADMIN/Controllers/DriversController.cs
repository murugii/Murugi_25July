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
    public class DriversController : Controller
    {
        EmergencyMedicalAndAmbulanceDispatchEntities _db = new EmergencyMedicalAndAmbulanceDispatchEntities();
        // GET: Drivers
        public ActionResult Index()
        {
            List<DriversViewModel> _UsersViewModel = new List<DriversViewModel>();
            //fetch from database
            try
            {
                using(var db = new EmergencyMedicalAndAmbulanceDispatchEntities())
                {
                    var list = db.Users.Where(x => x.UserType == "Driver").ToList();

                    foreach (var user in list)
                    {
                        _UsersViewModel.Add(new DriversViewModel { Email = user.Email, FirstName = user.FirstName + " " + user.LastName, IdNumber = user.NationalIDNumber.ToString(), Phone = user.PhoneNumber.ToString() });
                    }
                }

            }
            catch (Exception es)
            {
                string x = es.InnerException.Message;
                x = "" +x;
            }

            return View(_UsersViewModel);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public ActionResult CreateUser(UsersViewModel _UsersViewModel)
        {
            string message = null, status = null;

            try
            {
                var user = new User { Email = _UsersViewModel.Email, FirstName = _UsersViewModel.FirstName, Password = _UsersViewModel.Password };

                using (var db = new EmergencyMedicalAndAmbulanceDispatchEntities())
                {
                    db.Configuration.ValidateOnSaveEnabled = false;
                    db.Users.Add(user);
                    db.SaveChanges();

                    status = "000";
                    message = "Avengers! Assemble.....";
                }
            }
            catch (Exception es)
            {
                status = "999";
                message = es.Message;
            }

            var _RequestResponse = new RequestResponse
            {
                message = message,
                status = status
            };

            return Json(JsonConvert.SerializeObject(_RequestResponse), JsonRequestBehavior.AllowGet);
        }
        public ActionResult Edit(string Id)
        {
            return View();
        }
    }
}