
using System.Web.Mvc;

using MVCAssignment.Models;
using MVCAssignment.Helper;
using BL;
using System.Web.Security;
namespace MVCAssignment.Controllers
{
    public class LoginController : Controller
    {
        public ActionResult Login()
            {
              
            return View();
            }

        [ActionName("Login")]
        [HttpPost]
        public ActionResult LoginPost(UserModel user)
            {
            UserValidationBL userValidation = new UserValidationBL();

            if (userValidation.UserExists(new UserModelToUserHelper().UserModelToUserMapping(user)))
                {
                FormsAuthentication.SetAuthCookie(user.UserName, false);
                return RedirectToAction("About", "Home");

                }
            else
                {
                ViewBag.Message = "Invalid UserName or Password";
                return View();
                }
            


            }

        public ActionResult LogOut()
            {
            FormsAuthentication.SignOut();
           
            return Redirect("/Home/About");
            }
        }
}