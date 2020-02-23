using IMCO.Base;
using IMCO.Models.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IMCO.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
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

        public ActionResult Login()
        {
            // return Content("<html>sam</html>");
            return View();
        }

        [HttpPost]
        public ActionResult Login(ClsLogin clsLogin)//(string UserName,string Password)
        {
            
            //ClsLogin clsLogin = new ClsLogin();
            //clsLogin.UserName = UserName;
            //clsLogin.Password= Password;
            // return Content("<html>sam</html>");
            return View();
        }
    }
}