using Faturamento.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;
using Faturamento.Data;

namespace Faturamento.Services
{
    public class DistribuidoraService
    {
        private readonly FaturamentoContext _context;

        public DistribuidoraService(FaturamentoContext context)
        {
            _context = context;
        }
        public async Task<List<Distribuidora>> FindAllAsync()
        {
            return await _context.Distribuidoras.ToListAsync();
        }
        public async Task InsertAsync(Distribuidora obj)
        {
            _context.Add(obj);
            await _context.SaveChangesAsync();
        }
        public async Task<Distribuidora> FindByIdAsync(int id)
        {
            return await _context.Distribuidoras.Include(obj => obj.Fatura).FirstOrDefaultAsync(obj => obj.Id == id);
        }
    }
}