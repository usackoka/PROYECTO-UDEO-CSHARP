using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;
using System.Text.Json;
// using System.Web.Script.Serialization;

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

        public string OnGetProductos()
        {
            return "";
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

        public IActionResult DetalleProducto(string id = "") {
            inventario.setProduct(Convert.ToInt32(id));
            return View(inventario);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}