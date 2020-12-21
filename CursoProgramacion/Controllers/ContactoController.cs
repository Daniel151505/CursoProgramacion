using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CursoProgramacion.Models;
using CursoProgramacion.Data;
using Microsoft.EntityFrameworkCore;

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

         public IActionResult Listar()
        {
            //listar
            var listarContactos = _context.Contactos.ToList();
            return View(listarContactos);
            //listar
        }

        
        [HttpPost]

        public IActionResult Registrar (Contacto objContacto){

           if(ModelState.IsValid){

                //Registrar
               _context.Add(objContacto);
               _context.SaveChanges();
                //Registrar

                objContacto.Response="Gracias estamos en contacto";

             }
         return View ("Index", objContacto);

        }

        //editar
        public async Task<IActionResult> Editar (int ? id){
        
            if(id == null){
            return NotFound();
            }else{
                
                var contacto= await _context.Contactos.FindAsync(id);
                if(contacto == null){
                    return NotFound();
                }
                else{
                    return View(contacto);
                }

            }

        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Editar (int id, [Bind("Id,Name,LastName,Email,Number,Course,Title,Message")] Contacto objContactoo ){

            if(id !=objContactoo.Id){
                return NotFound();
            }

            if(ModelState.IsValid){
            try{
                _context.Update(objContactoo);
                await _context.SaveChangesAsync();
                
            }
            catch(DbUpdateConcurrencyException){
                return NotFound();
            }
           
            return RedirectToAction(nameof(Listar));
            }

            return View (objContactoo);

        }
        //editar

         
         //eliminar
        public IActionResult Eliminar (int? id){

                var contacto= _context.Contactos.Find(id);
                _context.Contactos.Remove(contacto);
                _context.SaveChanges();

                return RedirectToAction(nameof(Listar));

         }
        //eliminar
   
    
    }
}