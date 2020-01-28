using KIDKLOUD2._0.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KidKloud.Controllers
{
    public class ChildrenController : Controller
    {
        private ApplicationDbContext _context;

        public ChildrenController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var x = _context.Users.ToList();

        // GET: Children
        var model = new List<string>()
            {
                "Click to Choose Child...","Maleah M. Brown","Jordan A. Brown"
            };
            return View(model);
        }
    }
}