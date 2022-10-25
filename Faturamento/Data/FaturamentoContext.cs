using Faturamento.Models;
using Microsoft.EntityFrameworkCore;

namespace Faturamento.Data
{
    public class FaturamentoContext : DbContext
    {

        public FaturamentoContext(DbContextOptions<FaturamentoContext> options) : base(options)
        {
        }

        public DbSet<Distribuidora> Distribuidoras { get; set; }
        public DbSet<Fatura> Faturas { get; set; }

    }
}
