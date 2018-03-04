using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasic.ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.Title = "ExampleTitle";
            ViewBag.No = 2;
            ViewBag.Artist = new string[]
            {
                "Name: Name",
                "Age: 25",
                "Gender: Female"
            };
            return View();
        }
    }
}