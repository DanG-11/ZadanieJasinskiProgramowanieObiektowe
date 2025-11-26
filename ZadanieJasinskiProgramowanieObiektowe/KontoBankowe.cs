using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieJasinskiProgramowanieObiektowe
{
    internal class KontoBankowe
    {
        public decimal Saldo = 0;

        public void Wplac(decimal kwota)
        {
            Saldo += kwota;
            Console.WriteLine($"\nSaldo obecnie wynosi {Saldo} zł.");
        }
    }
}
