using Faturamento.Models.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Threading.Tasks;
using Faturamento.Services;

namespace Faturamento.Controllers
{
    public class DistribuidoraController : Controller
        {

            private readonly DistribuidoraService _distribuidoraService;
        public DistribuidoraController(DistribuidoraService distribuidoraService)
        {
            _distribuidoraService = distribuidoraService;
        }

        public async Task<IActionResult> Index()
            {
                var list = await _distribuidoraService.FindAllAsync();
                return View(list);
            }
            public async Task<IActionResult> Details(int? id)
            {
                if (id == null)
                {
                    return RedirectToAction(nameof(Error), new { message = "Id not provided" });
                }
                var obj = await _distribuidoraService.FindByIdAsync(id.Value);
                if (obj == null)
                {
                    return RedirectToAction(nameof(Error), new { message = "Id not found" });
                }
                return View(obj);
            }
            public IActionResult Error(string message)
            {
                var viewModel = new ErrorViewModel
                {
                    Message = message,
                    RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
                };
                return View(viewModel);
            }
        }
    }