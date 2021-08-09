using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            //return View(movie);
            return RedirectToAction("Index", "Home",new {id = 123,value = "posh"});
        }

        public ActionResult Index(int ? id)
        {
            if (!id.HasValue)
            {
                return Content("No Id Supplied");
            }
            else
            {
            return Content($"id = {id}");
            }
        }
    }
}