using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoProgramacion.Models
{
    [Table("t_contacto")]
    public class Contacto
    { 
    
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set;}

        [Required(ErrorMessage="Debe escribir los nombres")]
        [Column("name")]
        [Display (Name="Nombre")]
        public string Name { get; set; }

        [Required(ErrorMessage="Debe escribir los apellidos")]
         

        [Display (Name="Apellidos")]
        [Column("lastname")]
        public string LastName { get; set; }

        [Display (Name="Correo")]  
         [Column("email")]
        public string Email { get; set; }

        [DataType(DataType.PhoneNumber)]
        [Display (Name="Telefono")]
        [Column("number")]
        public int Number { get; set; }

        [Display (Name="Curso")]
        [Column("course")]
        public string Course { get; set; }

        [Display (Name="Titulo")]
         [Column("title")]
        public string Title { get; set; }

        [Display (Name="Mensaje")]
         [Column("message")]
        public string Message { get; set; }

        [NotMapped]
        public string Response {get;set;}

    }
}
