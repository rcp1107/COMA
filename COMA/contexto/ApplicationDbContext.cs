using COMA.model;
using Microsoft.EntityFrameworkCore;

namespace COMA.contexto
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<clientes> clientes { get; set; }
        public DbSet<factura> factura { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                    : base(options)
        {

        }
    }
}
