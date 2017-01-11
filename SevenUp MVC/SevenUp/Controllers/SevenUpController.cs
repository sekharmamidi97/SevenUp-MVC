using SevenUp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SevenUp.Controllers
{
    public class SevenUpController : Controller
    {
        // GET: SevenUp
        public ActionResult SevenUp()
        {
            return View("SevenUp", new SevenUpModel());
        }

        public ActionResult SevenUpResults(SevenUpModel model)
        {
            return View("SevenUpResults", model);
        }
    }
}