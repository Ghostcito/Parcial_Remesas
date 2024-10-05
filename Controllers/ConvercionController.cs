using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.Extensions.Logging;
using Proyecto_Parcial.Data;

namespace Proyecto_Parcial.Controllers
{
    public class ConvercionController : Controller
    {
        private readonly ILogger<ConvercionController> _logger;
        private readonly ApplicationDbContext _context;

        public ConvercionController(ILogger<ConvercionController> logger, ApplicationDbContext context)

        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Conversion conversion)
        {
            _context.Add(conversion);
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}