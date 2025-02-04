using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ballstore.Models;
using Microsoft.AspNetCore.Authorization;
using ballstore.Data;
using Microsoft.EntityFrameworkCore;

namespace ballstore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
            {
                return RedirectToAction("Index");
            }

            var products = await _context.Products
                .Where(p => p.Name.Contains(query) || p.Description.Contains(query))
                .ToListAsync();

            ViewBag.SearchQuery = query;
            return View(products);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var products = await _context.Products.ToListAsync();
            return View(products);
        }

        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult UserGuide()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
