using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
using Faturamento.Models;
using Faturamento.Data;
using Microsoft.EntityFrameworkCore;

namespace Faturamento.Services
{
    public class FaturaService
    {
        private readonly FaturamentoContext _context;

        public FaturaService(FaturamentoContext context)
        {
            _context = context;
        }

        public async Task<List<Fatura>> FindByDateAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Faturas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.dia >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.dia <= maxDate.Value);
            }
            return await result
                .Include(x => x.Distribuidora)
                .OrderByDescending(x => x.dia)
                .ToListAsync();
        }
        public async Task<List<Fatura>> FindByValorAsync(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Faturas select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.dia >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.dia <= maxDate.Value);
            }
            return await result
                .Include(x => x.Distribuidora)
                .OrderByDescending(x => x.valor)
                .ToListAsync();
        }
        internal Task FindAllAsync()
        {
            throw new NotImplementedException();
        }
    }
}
