using MVCBasic.ComicBookGallery.Models;
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
            var comicBook = new ComicBook()
            {
                Title = "The Amazing Spider-Man ",
                Issue = 700,
                DescriptionHtml = "<p>Description</p>",
                Artists = new List<Artist>()
                {
                    new Artist(){Name="Name One", Role="Role One"},
                    new Artist(){Name="Name Two", Role="Role Two"},
                    new Artist(){Name="NameThree", Role="Role Three"}
                }
            };
            return View(comicBook);
        }
    }
}