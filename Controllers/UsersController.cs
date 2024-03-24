using Microsoft.AspNetCore.Mvc;

namespace HomeWorkAspNetCoreMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsersController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            var users = _context.Users.ToList();
            return View(users);
        }
    }
}
