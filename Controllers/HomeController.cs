using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using efdemo.Models;
using Microsoft.EntityFrameworkCore;

namespace efdemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly RegistrarContext _context;

        public HomeController(ILogger<HomeController> logger, RegistrarContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var solicitudes = _context.RegistrosProductos
                                        .Include(s => s.Usuario)
                                        .ToList();

            return View(solicitudes);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RegistrarProducto()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RegistrarProducto(RegistrarProducto sa)
        {
            if (ModelState.IsValid) {
                // Guardar el objeto "sa" en la BD
                var usuario = _context.Usuarios.First(u => u.Id == 1);
                sa.Usuario = usuario;
                _context.Add(sa);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(sa);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
