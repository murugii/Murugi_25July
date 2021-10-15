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
    public class RequestsController : Controller
    {
        // GET: ADMIN/Requests
        public ActionResult Index()
        {
            List<RequestsListViewModel> _UsersViewModel = new List<RequestsListViewModel>();
            //fetch from database
            try
            {
                using (var db = new EmergencyMedicalAndAmbulanceDispatchEntities())
                {
                    var list = db.Requests.ToList();

                    foreach (var request in list)
                    {
                        _UsersViewModel.Add(new RequestsListViewModel 
                        {
                            Amount = request.Amount,
                            Date_Time = request.Date_Time.ToString(),
                            Description = request.Description,
                            Location = request.Location,
                            RequesterIdNumber = request.RequesterIdNumber,
                            RequestID = request.RequestID,
                            RequestStatus = request.RequestStatus,
                            RequestType = request.RequestType,
                            VehicleRegistrationNo = request.VehicleRegistrationNo
                        });
                    }
                }

            }
            catch (Exception es)
            {
                string x = es.InnerException.Message;
                x = "" + x;
            }
            return View(_UsersViewModel);
        }
    }
}