using System;
using System.ComponentModel.DataAnnotations;

namespace CursoProgramacion.Models
{
    public class Contacto
    { 
         [Display (Name="Nombres")]
        public string Name { get; set; }

         [Display (Name="Apellidos")]
        public string LastName { get; set; }

         [Display (Name="Correos")]
        public string Email { get; set; }

         [Display (Name="Telefono")]
        public int Number { get; set; }
        
         [Display (Name="Curso")]
        public int Course { get; set; }

         [Display (Name="Titulo")]
        public string Title { get; set; }

         [Display (Name="Mensaje")]
        public string Message { get; set; }
        
        public string Response {get;set;}


         

    }
}
        
        