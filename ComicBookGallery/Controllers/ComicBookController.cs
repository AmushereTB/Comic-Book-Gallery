using ComicBookGallery.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBookGallery.Controllers
{
    public class ComicBookController : Controller
    {
        public ActionResult Detail()
        {
            var comicBook = new ComicBook()
            {
                SeriesTitle = "Spider Man",
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! " +
                                 "Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Warning = "there is no artist in List",
                Artists = new Artist[] {
                    new Artist(){Name = "Den", Role ="Script"},
                    new Artist(){Name = "Humberto", Role ="Pencils"},
                    new Artist(){Name = "Edger", Role ="Inks"},
                    new Artist(){Name = "Colors", Role ="Colors"},
                    new Artist(){Name = "Letters", Role ="Letters"},
                }

            };


            return View(comicBook);

        }
    }
}