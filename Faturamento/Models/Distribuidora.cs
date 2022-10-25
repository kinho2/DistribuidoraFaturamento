using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Faturamento.Models
{
    public class Distribuidora
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "{0} required")]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        public ICollection<Fatura> Fatura { get; set; } = new List<Fatura>();
        public Distribuidora()
        {
        }

        public Distribuidora(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public void addFatura(Fatura fatura)
        {
            Fatura.Add(fatura);
        }
        public void removefatura(Fatura fatura)
        {
            Fatura.Remove(fatura);
        }

        public double totalFaturas(DateTime initial, DateTime final)
        {
            return Fatura.Where(Fatura => Fatura.dia >= initial && Fatura.dia <= final).Sum(Fatura => Fatura.valor);
        }
    }
}
