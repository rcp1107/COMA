using COMA.model;
using Microsoft.EntityFrameworkCore;

namespace COMA.contexto
{
    public class ApplicationDbContext: DbContext //Esta clase va heredar de DbContext
    {
        public DbSet<clientes> clientes { get; set; } //Se crea DbSet de tipo clientes el cual es la clase que se creó en model
        public DbSet<factura> factura { get; set; }// es necesario importa model
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {

        }
    }
}
