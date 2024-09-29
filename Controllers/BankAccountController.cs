using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BankAccountPC2.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BankAccountPC2.Models;
using BankAccountPC2.ViewModel;

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
            var misclientes = from o in _context.DataCliente select o;
            var viewModel = new ClienteViewModel{
                FormCliente = new Cliente(),
                ListCliente = misclientes
            };
            return View(misclientes.ToList());
        }

        [HttpPost]
        public IActionResult Crear(ClienteViewModel viewModel)
        {
            _logger.LogDebug("Ingreso a Crear Cuenta");
            
            var cliente=new Cliente{
                NombreT=viewModel.FormCliente.NombreT,
                TipoC=viewModel.FormCliente.TipoC,
                SaldoI=viewModel.FormCliente.SaldoI,
                Email=viewModel.FormCliente.Email,
            };

            _context.Add(cliente);
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