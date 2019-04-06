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
        //INITIALIZATION
        Profile ProfileO;
        List<Profile> ProfileList;

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Search(string profilePersonalID)
        {
            ProfileO = new Profile();
            ProfileList = new List<Profile>();

            ProfileList.ToList();

            foreach (var profL in ProfileList)
            {
                if (profL.personalId == profilePersonalID)
                {
                    ProfileO.name = profL.name;
                    ProfileO.Profession = profL.Profession;
                    ProfileO.photo = profL.photo;
                }
                return View();
            }
            return View(ProfileO);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Creating(string personalId, string name, int professionId, HttpPostedFileBase photo)
        {
            return View();
        }
    }
}