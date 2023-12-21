using API_Personas.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Personas.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        // coleccion de entidades
        public DbSet<Person> Persons { get; set; }
    }
}
