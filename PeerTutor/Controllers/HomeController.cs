using PeerTutor.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PeerTutor.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            


            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Edit this for your demo";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Edit this for your demo";

            return View();
        }

        public ActionResult LoggedIn()
        {
            var currentUserId = User.Identity.GetUserId();
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
            var currentUser = manager.FindById(User.Identity.GetUserId());
            ViewBag.FirstName = currentUser.FirstName;

            return View();
        }
    }
}