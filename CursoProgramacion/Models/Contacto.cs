using System;
using System.ComponentModel.DataAnnotations;

namespace CursoProgramacion.Models
{
    public class Contacto
    { 

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public int Number { get; set; }

        public int Course { get; set; }

        public string Title { get; set; }

        public string Message { get; set; }
        
        public string Response {get;set;}


         

    }
}
        
        