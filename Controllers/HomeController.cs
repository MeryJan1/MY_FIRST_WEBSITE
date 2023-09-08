using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjeSon.Models.DataContext;
namespace ProjeSon.Controllers
{
    public class HomeController : Controller
    {

        private PersonelSiteDB db = new PersonelSiteDB();

        public ActionResult Index()
        {
            var about = db.aboutinfos.OrderByDescending(p => p.Id).First();
            ViewBag.About = about;

            var skills = db.Skillsinfos.ToList();
            ViewBag.Skills = skills;

            var services = db.Servicesinfos.ToList();
            ViewBag.Services = services;

            var profil = db.Profilinfos.OrderByDescending(p => p.Id).First();
            ViewBag.Profil = profil;

            var information =db.Informationinfos.OrderByDescending(p => p.Id).First();
            ViewBag.Informations = information; 
            
            var navbar = db.Navbarinfos.OrderByDescending(p => p.Id).First();
            ViewBag.Navbar = navbar;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}