using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CursoProgramacion.Models;
using CursoProgramacion.Data;

namespace CursoProgramacion.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;


        public ContactoController(ILogger<HomeController> logger, DatabaseContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]

        public IActionResult Registrar (Contacto objContacto){

           if(ModelState.IsValid){

               _context.Add(objContacto);
               _context.SaveChanges();
                objContacto.Response="Gracias estamos en contacto";
             }
         return View ("Index", objContacto);

        }
    
    }
}
