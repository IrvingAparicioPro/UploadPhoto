using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UploadPhoto.Models;

namespace UploadPhoto.Controllers
{
    public class HomeController : Controller
    {
        Profile profileO;
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(HttpPostedFileBase photo, string profileID)
        {
            profileO = new Profile();

            List<Profile> profileList = new List<Profile>();



            return View();
        }
    }
}