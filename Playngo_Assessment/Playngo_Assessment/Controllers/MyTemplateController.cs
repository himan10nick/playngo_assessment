using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Playngo_Assessment.Controllers
{
    public class MyTemplateController : Controller
    {
       
        public ActionResult Index()
        {
            ViewBag.Movies = new List<string>()
            {
                "Captain America : Civil War",
                "Suicide Squad",
                "Doctor Strange",
                "The Purge 3"
            };

            ViewBag.Status = new List<string>()
            {
                "Now Showing",
                "Next Showing",
                "Coming soon",
                "To Be Announced.."
            };

            return View();
        }

        public ActionResult Feedback()
        {
            ViewBag.Users = new List<string>()
            {
               "Nick:",
               "They have better actions than the recent ones",
               "John Doe",
                "I must say.. It's the first time I've been satisfied over the quality, Well Done Marvel, You've done it again..",
               "Abigail",
               "I was impressed how the story goes on, Even the villains are better than before, I'm excited to the next moive!"
              
            };

            return View("Feedback");
        }
        public ActionResult Reservation()
        {

            ViewBag.Reservation = new List<string>()
            {
               "Cinema 1 (Captain America) : SOLD OUT",
               "Cinema 2 (Captain America) : 21 Seats Left",
               "Cinema 3 (Suicide Squad) : Tickets Available Soon",
               "Cinema 4 (Doctor Strange) : Tickets To be announced.."
            };

            return View("Reservation");
        }


    }
}
