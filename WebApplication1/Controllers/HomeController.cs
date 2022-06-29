using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using System.Text.Json;
using System.Web.Script.Serialization;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public InventarioViewModel inventario;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            inventario = new InventarioViewModel();
        }

        public IActionResult OnGetProductos()
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string output = jss.Serialize(inventario.productos);
            return new JsonResult(output);
        }

        public IActionResult Index()
        {
            return View(inventario);
        }

        public IActionResult Vision()
        {
            return View();
        }

        public IActionResult Mision()
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