using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CursoProgramacion.Data
{
    public class DatabaseContext: DbContext
    {


        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
 
        }

        public DbSet<CursoProgramacion.Models.Contacto> Contactos {get; set;} 


    }
}
