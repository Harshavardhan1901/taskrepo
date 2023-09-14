using Microsoft.AspNetCore.Mvc;
using WebAppUsers.Models;

namespace WebAppUsers.Controllers
{
    public class UserController : Controller
    {
        static List<User> users = new List<User>
        {
            new User() {UserId= 1, UserName="sam", UserEmail="sam@yahoo.com", UserPwd="sam@1234" },
            new User() {UserId= 2, UserName="amit", UserEmail="amit@yahoo.com", UserPwd="amit@1234" },
            new User() {UserId= 3, UserName="kumar", UserEmail="kumar@yahoo.com", UserPwd="kumar@1234" },
            new User() {UserId= 4, UserName="anisha", UserEmail="anisha@yahoo.com", UserPwd="ani@1234" },
            new User() {UserId= 5, UserName="anil", UserEmail="anil@yahoo.com", UserPwd="anil@1234" },
        };
        public IActionResult Index()
        {
            return View(users);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new User());
        }
        [HttpPost]
        public IActionResult Create(User model)
        {
            if (ModelState.IsValid)
            {
                users.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

    }
}
