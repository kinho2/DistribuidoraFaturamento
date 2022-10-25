using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Faturamento.Services;

namespace Faturamento.Controllers
{
    public class FaturaController : Controller
    {
        private readonly FaturaService _faturaSevice;

        public FaturaController(FaturaService faturaSevice)
        {
            _faturaSevice = faturaSevice;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _faturaSevice.FindByDateAsync(minDate, maxDate);
            return View(result);
        }
        public async Task<IActionResult> SimpleSearchValor(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = await _faturaSevice.FindByValorAsync(minDate, maxDate);
            return View(result);
        }

    }
}