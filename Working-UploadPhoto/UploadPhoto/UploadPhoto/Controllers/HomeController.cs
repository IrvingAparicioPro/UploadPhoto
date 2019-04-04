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
        //VARIABLES
        Profile profileO;
        List<Profile> profileList;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string profilePersonalID, HttpPostedFileBase photo)
        {
            profileO = new Profile();
            profileList = new List<Profile>();

            profileList.ToList();

            foreach (var profL in profileList)
            {
                if (profL.personalId == profilePersonalID)
                {
                    profileO.name = profL.name;
                    profileO.Profession = profL.Profession;
                    profileO.photo = profL.photo;
                }
                return View();
            }
            return View(profileO);
        }
    }
}