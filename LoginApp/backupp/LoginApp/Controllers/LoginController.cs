using LoginApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginApp.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(LoginApp.Models.User userModel)
        {
            using (LoginDBEntities db = new LoginDBEntities())
            {

                var userDetails = db.Users .Where(x => x.UserName == userModel.UserName && x.Password == userModel.Password).FirstOrDefault();

                if (userDetails == null)
                {


                    userModel.LoginErrorMessage = "wrong user name or Password";
                    return View("Index", userModel);
                }

                else
                {
                    Session["userId"] = userDetails.UserId;
                    Session["userName"] = userDetails.UserName;
                    return RedirectToAction("Index", "Home");
                }
            }

           


        }

        public ActionResult LogOut()
        {
            int userId = (int) Session["userId"];
            Session.Abandon();
            return RedirectToAction("index", "Login");
        }

    }
}
