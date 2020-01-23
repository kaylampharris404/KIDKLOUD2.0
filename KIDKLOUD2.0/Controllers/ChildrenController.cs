using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKloud.Controllers
{
    public class ChildrenController : Controller
    {
        // GET: Children
        public ActionResult Index()
        {
            var model = new List<string>()
            {
                "Click to Choose Child...","Maleah M. Brown","Jordan A. Brown"
            };
            return View(model);
        }
    }
}