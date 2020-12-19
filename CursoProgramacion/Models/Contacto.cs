using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoProgramacion.Models
{
    [Table("t-contacto")]
    public class Contacto
    { 

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set;}

         [Column("name")]
         [Required(ErrorMessage="Debe escribir los nombres")]
         [Display (Name="Nombres")]
        public string Name { get; set; }
         
         [Column("lastname")]
         [Required(ErrorMessage="Debe escribir los apellidos")]
         [Display (Name="Apellidos")]
        public string LastName { get; set; }
         
         [Column("email")]
         [Display (Name="Correos")]
        public string Email { get; set; }

         [DataType(DataType.PhoneNumber)]
         [Column("number")]
         [Display (Name="Telefono")]
        public int Number { get; set; }
        
         [Display (Name="Curso")]
         [Column("course")]
        public int Course { get; set; }

         [Display (Name="Titulo")]
         [Column("title")]
        public string Title { get; set; }

         [Display (Name="Mensaje")]
         [Column("message")]
        public string Message { get; set; }
        
        public string Response {get;set;}


         

    }
}
        
        