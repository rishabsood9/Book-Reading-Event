using Shared;
using System.Web.Mvc;
using MVCAssignment.Models;
using MVCAssignment.Helper;
using BL;
namespace MVCAssignment.Controllers
{
    public class RegisterController : Controller
    {
        // GET: Register
        public ActionResult Register()
        {
            
            return View();
        }
        [HttpPost]
        [ActionName("Register")]
        public ActionResult RegisterPost(RegisterUserModel userModel)
            {
            User user = new RegisterUserModelToUserHelper().RegisterUserModelToUserMapping(userModel);
            if (ModelState.IsValid)
                {
                new RegisterUserBL().AddUser(user);
                return RedirectToAction("Login", "Login");
                }
            return View();

            }
    }
}