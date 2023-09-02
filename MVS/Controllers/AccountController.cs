using Microsoft.AspNetCore.Mvc;
using MVS.Models;

namespace MVS.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SignUp(Users user)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
