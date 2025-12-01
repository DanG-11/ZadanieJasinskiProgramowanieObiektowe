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

        public bool Wyplac(decimal kwota)
        {
            if(kwota <= 0)
            {
                Console.WriteLine("\nNie można wypłacić kwoty mniejszej lub równej 0.");
                return false;
            }
            else if(Saldo >= kwota)
            {
                Saldo -= kwota;
                Console.WriteLine($"\nNa saldzie obecnie znajduje się {Saldo} zł.");
                return true;
            }
            else
            {
                Console.WriteLine("\nBrak środków.");
                return false;
            }
        }
    }
}
