using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BankAccountPC2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BankAccountPC2.Models;


namespace BankAccountPC2.Controllers
{
    public class BankAccountController : Controller
    {
        private readonly ILogger<BankAccountController> _logger;

        private readonly ApplicationDbContext _context;

        public BankAccountController(ILogger<BankAccountController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Crear(Cliente objcliente)
        {
            _logger.LogDebug("Ingreso a Crear Cuenta");
           
            _context.Add(objcliente);
            _context.SaveChanges();

            return View("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}