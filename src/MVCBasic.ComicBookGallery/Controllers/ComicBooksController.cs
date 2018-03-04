using MVCBasic.ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCBasic.ComicBookGallery.Data;

namespace MVCBasic.ComicBookGallery.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail(int? id)
        {
            if (id == null)
                return HttpNotFound();
            return View(ComicBookRepository.GetComicBook((int)id));
        }
    }
}