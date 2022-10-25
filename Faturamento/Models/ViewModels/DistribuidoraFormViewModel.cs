using System.Collections.Generic;

namespace Faturamento.Models.ViewModel
{
    public class DistribuidoraFormViewModel
    {
        public Distribuidora Distribuidora { get; set; }
        public ICollection<Fatura> Faturamento { get; set; }

    }
}
