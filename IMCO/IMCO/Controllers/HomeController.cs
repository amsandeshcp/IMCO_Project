using IMCO.Base;
using IMCO.Core.Base;
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
            #region ValidationProcess with API

            #region PostConcept
            //ClsLoginRequest obj = new ClsLoginRequest();
            //obj.Model = clsLogin;
            //obj.UserId = 0;

            //var objResult2 = Post<ResponseDto<ClsLoginResponse>>($"api/user-verify/validate-login", obj);
            #endregion

            #region GetConcept
            var objResult2 = Get<bool>(string.Format("api/user-verify/validate-login?Uname={0}&Pass={1}", clsLogin.UserName, clsLogin.Password));
            #endregion

            ViewBag.status = objResult2;
            #endregion
            return View();
        }
    }
}