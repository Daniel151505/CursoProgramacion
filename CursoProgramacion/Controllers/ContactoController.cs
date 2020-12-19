using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CursoProgramacion.Models;

namespace CursoProgramacion.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ContactoController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]


        public IActionResult Registrar (Contacto objContacto){

           if(ModelState.IsValid){
                objContacto.Response="Gracias estamos en contacto";
             }
         return View ("Index", objContacto);

        }
    
    }
}
