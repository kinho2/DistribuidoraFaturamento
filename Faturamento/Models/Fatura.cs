using System.ComponentModel.DataAnnotations;
using System;

namespace Faturamento.Models
{
    public class Fatura
    {
        public int Id { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime dia { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double valor { get; set; }
        public Distribuidora Distribuidora { get; set; }


        public Fatura()
        {
        }

        public Fatura(int id, DateTime dia, double valor, Distribuidora distribuidora)
        {
            Id = id;
            this.dia = dia;
            this.valor = valor;
            Distribuidora = distribuidora;
        }
    }
}
