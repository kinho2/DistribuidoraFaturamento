using Faturamento.Models;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace Faturamento.Data
{
    public class SeedingService
    {
        private FaturamentoContext _context;


        public SeedingService(FaturamentoContext context)
        {
            _context = context;
        }
        public void Seed()
        {


            if (_context.Distribuidoras.Any() ||
                 _context.Faturas.Any())
            {
                return; // DB has been seeded
            }

            Distribuidora A1 = new Distribuidora(1, "MK Fight");

            Fatura F1 = new Fatura(1, new DateTime(2022, 10, 01), 22174.1664, A1);
            Fatura F2 = new Fatura(2, new DateTime(2022, 10, 02), 24537.6698, A1);
            Fatura F3 = new Fatura(3, new DateTime(2022, 10, 03), 26139.6134, A1);
            Fatura F4 = new Fatura(4, new DateTime(2022, 10, 04), 0.0, A1);
            Fatura F5 = new Fatura(5, new DateTime(2022, 10, 05), 0.0, A1);
            Fatura F6 = new Fatura(6, new DateTime(2022, 10, 06), 26742.6612, A1);
            Fatura F7 = new Fatura(7, new DateTime(2022, 10, 07), 0.0, A1);
            Fatura F8 = new Fatura(8, new DateTime(2022, 10, 08), 42889.2258, A1);
            Fatura F9 = new Fatura(9, new DateTime(2022, 10, 09), 46251.174, A1);
            Fatura F10 = new Fatura(10, new DateTime(2022, 10, 10), 11191.4722, A1);
            Fatura F11 = new Fatura(11, new DateTime(2022, 10, 11), 0.0, A1);
            Fatura F12 = new Fatura(12, new DateTime(2022, 10, 12), 0.0, A1);
            Fatura F13 = new Fatura(13, new DateTime(2022, 10, 13), 3847.4823, A1);
            Fatura F14 = new Fatura(14, new DateTime(2022, 10, 14), 373.7838, A1);
            Fatura F15 = new Fatura(15, new DateTime(2022, 10, 15), 2659.7563, A1);
            Fatura F16 = new Fatura(16, new DateTime(2022, 10, 16), 48924.2448, A1);
            Fatura F17 = new Fatura(17, new DateTime(2022, 10, 17), 18419.2614, A1);
            Fatura F18 = new Fatura(18, new DateTime(2022, 10, 18), 0.0, A1);
            Fatura F19 = new Fatura(19, new DateTime(2022, 10, 19), 0.0, A1);
            Fatura F20 = new Fatura(20, new DateTime(2022, 10, 20), 35240.1826, A1);
            Fatura F21 = new Fatura(21, new DateTime(2022, 10, 21), 43829.1667, A1);
            Fatura F22 = new Fatura(22, new DateTime(2022, 10, 22), 18235.6852, A1);
            Fatura F23 = new Fatura(23, new DateTime(2022, 10, 23), 4355.0662, A1);
            Fatura F24 = new Fatura(24, new DateTime(2022, 10, 24), 13327.1025, A1);
            Fatura F25 = new Fatura(25, new DateTime(2022, 10, 25), 0.0, A1);
            Fatura F26 = new Fatura(26, new DateTime(2022, 10, 26), 0.0, A1);
            Fatura F27 = new Fatura(27, new DateTime(2022, 10, 27), 25681.8318, A1);
            Fatura F28 = new Fatura(28, new DateTime(2022, 10, 28), 1718.1221, A1);
            Fatura F29 = new Fatura(29, new DateTime(2022, 10, 29), 13220.495, A1);
            Fatura F30 = new Fatura(30, new DateTime(2022, 10, 30), 8414.61, A1);





            _context.Distribuidoras.AddRange(A1);
            _context.Faturas.AddRange(F1, F2, F3, F4, F5, F6, F7, F8, F9, F10, F11, F12, F13, F14, F15, F16, F17, F18, F19, F20, F21,F22, F23, F25, F26,F27,F28,F29,F30);
            _context.SaveChanges();

        }

    }
}
