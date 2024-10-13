using Microsoft.AspNetCore.Mvc;
using SchoolManagementSystem.DataAccess.Abstract;

namespace SchoolManagementSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public IActionResult Index()
        {
            ViewBag.Text = "Hello";
            return View();
        }
    }
}
