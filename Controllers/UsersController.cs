using HomeWorkAspNetCoreMVC.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HomeWorkAspNetCoreMVC.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly ILogger<UsersController> _logger;

        public UsersController(ApplicationDbContext context, ILogger<UsersController> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var users = _context.Users.ToList();

            _logger.LogTrace("LogTrace222222");
            _logger.LogDebug("LogDebug33333333");
            _logger.LogInformation("LogInformation4444");
            _logger.LogWarning("LogWarning5555");
            _logger.LogError("LogError6666");
            _logger.LogCritical("LogCritical7777");

            return View(users);
        }

        public IActionResult Create(int Id)
        {
            return View();

        }

        public IActionResult Edit(int Id)
        {
            return View();
        }

        public IActionResult Delete(int Id)
        {
            return View();
        }
    }
}
