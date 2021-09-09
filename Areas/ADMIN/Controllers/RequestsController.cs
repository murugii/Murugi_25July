using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Murugi_25July.Areas.ADMIN.Controllers
{
    public class RequestsController : Controller
    {
        // GET: ADMIN/Requests
        public ActionResult Index()
        {
            return View();
        }
    }
}