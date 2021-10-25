
using Crud_do_petshop.Models;
using Microsoft.EntityFrameworkCore;

namespace Crud_do_petshop.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<Servico> options)
            : base(options)
        {

        }
        public DbSet<Servico> Servico { get; set; }
    }
}