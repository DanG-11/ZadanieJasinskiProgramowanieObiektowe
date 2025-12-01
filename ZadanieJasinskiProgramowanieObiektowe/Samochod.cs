using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ZadanieJasinskiProgramowanieObiektowe
{
    internal class Samochod
    {
        public string Marka;
        public int RokProdukcji;

        int Predkosc = 0;

        public void Jedz()
        {
            Console.WriteLine("\nBrum brum!");
        }

        public void Przyspiesz()
        {
            Predkosc += 10;
            Console.WriteLine($"\nObecna prędkość samachodu to: {Predkosc}");
        }

        public void Hamuj()
        {
            if(Predkosc >= 10)
            {
                Predkosc -= 10;
                Console.WriteLine($"\nObecna prędkość samachodu to: {Predkosc}");
            }
            else
            {
                Console.WriteLine("\nSamochód już zahamował.");
            }
        }
    }
}
