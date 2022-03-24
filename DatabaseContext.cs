using CRUDCaminhoes.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDCaminhoes
{
    public class DatabaseContext : DbContext
    {
        public  DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {

        }
        public DbSet<Caminhao> Caminhao { get; set; }
    }
}
