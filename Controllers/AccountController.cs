using Microsoft.AspNetCore.Mvc;

namespace SchoolManagementSystem.Controllers
{
    public class AccountController : Controller
    {
        //[Route("/User/Login")]
        public IActionResult Login()
        {
            return View();
        }
    }
}
