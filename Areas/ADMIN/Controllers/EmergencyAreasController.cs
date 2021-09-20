using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Murugi_25July.Areas.ADMIN.Controllers
{
    public class EmergencyAreasController : Controller
    {
        // GET: ADMIN/EmergencyAreas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}