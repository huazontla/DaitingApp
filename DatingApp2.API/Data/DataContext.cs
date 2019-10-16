using DatingApp2.API.Models;
using Microsoft.EntityFrameworkCore;

namespace DatingApp2.API.Data
{
    public class DataContext : DbContext
    {
        // DbContex es la clase que nos sirve para hacer consultas a la BD
        //csontructor del tipo DbContext
        public DataContext(DbContextOptions<DataContext> options) : base 
        (options)
        {
            
        }

        public DbSet<Value> Values { get; set; }
        
    }
}