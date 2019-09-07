using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCTask1.Models;

namespace MVCTask1.Controllers
{
    public class UserManageController : Controller
    {
        // GET: UserManage
        public ActionResult List()
        {
            List<ImageModel> userlist = new List<ImageModel>();
            var user = new ImageModel(1, "Arathy", "arathy@gmail.com", "arathy", "81", "Beautiful-Girl-Images-11.jpg", "Female", 1);
            userlist.Add(user);

            user = new ImageModel(1, "Archana", "archana@gmail.com", "arathy", "56", "butterfly-2049567__340.jpg", "Female", 1);
            userlist.Add(user);

            return View(userlist);
        }



        [HttpGet]
        public ActionResult signupAuto()
        {
            ImageModel imageModel = new ImageModel();
            imageModel.StateId = new StateModel();

            SelectList countrylist = new SelectList(imageModel.StateId.GetCountries, "CountryId", "CountryName");
            SelectList statelist = new SelectList(imageModel.GetStates, "StateId", "StateName");

            ViewBag.CountryDataSource = countrylist;
            ViewBag.StateDataSource = statelist;
            return View();
        }

        [HttpPost]
        public ActionResult signupAuto(ImageModel imageModel)
        {
            return View();
        }


        [HttpGet]
        public ActionResult signup()
        {
            ImageModel imageModel = new ImageModel();
            imageModel.StateId = new StateModel();

            SelectList countrylist = new SelectList(imageModel.StateId.GetCountries, "CountryId", "CountryName");
            SelectList statelist = new SelectList(imageModel.GetStates, "StateId", "StateName");

            ViewBag.CountryDataSource = countrylist;
            ViewBag.StateDataSource = statelist;
            return View();
        }

        [HttpPost]
        public ActionResult signup(ImageModel imageModel)
        {
            return View();
        }

        [HttpGet]
        public ActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignIn(ImageModel imageModel)
        {
            return View();
        }
    }
}