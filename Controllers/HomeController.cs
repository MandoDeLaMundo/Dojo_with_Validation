using Microsoft.AspNetCore.Mvc;
using Dojo_Survey.Models;


namespace Dojo_Survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public ViewResult Register()
        {

            return View("register");
        }

        [HttpPost("/users/process-registration")]
        public IActionResult ProcessRegistration(User newUser)
        {
            if(!ModelState.IsValid)
            {
                return View("register");
            }
            else
            {
                return View("result", newUser);
            }
        }

        [HttpPost("/result")]
        public ViewResult Result(string NameField, string DojoField, string LanguageField, string CommentField)
        {
            return View("result");
        }
    }
}