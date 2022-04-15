using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shadow_PUDGE.Data;
using Shadow_PUDGE.Models;
using System.Diagnostics;

namespace Shadow_PUDGE.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext, ILogger<HomeController> logger)
        {
            _logger = logger;
            _dbContext = dbContext;
        }
       
        [HttpGet]
        public ActionResult Buy(int? Id)
        {
            ViewBag.Id = Id ??0;
            return View();
        }
        [HttpPost]
        public string Buy(Order order)
        {
           // order.CreatedAt = DateTime.Now;
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
            return "ABOBA";
        }

        public IActionResult Index()
        {
            IEnumerable<Product> products =  _dbContext.Products.Include(p => p.Medias);

            ViewBag.Products = products;

            return View();
        }

        public IActionResult Privacy()
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