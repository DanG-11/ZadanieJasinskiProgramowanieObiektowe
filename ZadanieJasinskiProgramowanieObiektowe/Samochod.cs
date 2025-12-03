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
        private string _marka;
        private int _rokProdukcji;

        private int _predkosc;

        public string Marka { get;  set; }

        public int RokProdukcji {
            get { return _rokProdukcji; }
            set {
                int obecnyRok = DateTime.Now.Year;
                if (value < 1886 || value > obecnyRok)
                {
                    _rokProdukcji = 2000;
                }
                else
                {
                    _rokProdukcji = value;
                }
            }
        }

        int Predkosc = 0;

        public Samochod(string marka, int rokProdukcji)
        {
            Marka = marka;
            RokProdukcji = rokProdukcji;
        }

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
