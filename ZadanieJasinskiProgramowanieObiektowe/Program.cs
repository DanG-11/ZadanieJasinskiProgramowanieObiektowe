using ZadanieJasinskiProgramowanieObiektowe;

Samochod klasaSamochod = new Samochod();

Samochod auto1 = new Samochod();
Samochod auto2 = new Samochod();

Kalkulator kalkulatorek = new Kalkulator();

KontoBankowe kontoBankowe = new KontoBankowe();

klasaSamochod.Marka = "Fiat";
klasaSamochod.RokProdukcji = 2010;

auto1.Marka = "BMW";
auto1.RokProdukcji = 2022;

auto2.Marka = "Audi";
auto2.RokProdukcji = 2023;

Console.WriteLine(klasaSamochod.Marka);
Console.WriteLine(klasaSamochod.RokProdukcji);

klasaSamochod.Jedz();

Console.WriteLine("\n" + auto1.Marka);
Console.WriteLine(auto1.RokProdukcji);

Console.WriteLine("\n" + auto2.Marka);
Console.WriteLine(auto2.RokProdukcji);

Console.WriteLine("\nPodaj pierwszą cyfrę do zsumowania:");
int PierwszaCyfraSumowania = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\nPodaj drugą cyfrę do zsumowania:");
int DrugaCyfraSumowania = Convert.ToInt32(Console.ReadLine());

kalkulatorek.Dodaj(PierwszaCyfraSumowania, DrugaCyfraSumowania);

Console.WriteLine("\nIle chcesz wpłacić?");
decimal PieniadzeDoWplacenia = Convert.ToDecimal(Console.ReadLine());
kontoBankowe.Wplac(PieniadzeDoWplacenia);

Console.WriteLine("\nIle chcesz wpłacić?");
PieniadzeDoWplacenia = Convert.ToDecimal(Console.ReadLine());
kontoBankowe.Wplac(PieniadzeDoWplacenia);

Console.WriteLine("\nIle chcesz wpłacić?");
PieniadzeDoWplacenia = Convert.ToDecimal(Console.ReadLine());
kontoBankowe.Wplac(PieniadzeDoWplacenia);

Console.WriteLine("""
            Chcesz się rozpędzić czy zachamować?
            1 - Rozpędzić
            2 - Zachamować
            """);
int WyborKontroliSamochodu = Convert.ToInt32(Console.ReadLine());
if (WyborKontroliSamochodu == 1)
{
    klasaSamochod.Przyspiesz();
}
else if (WyborKontroliSamochodu == 2)
{
    klasaSamochod.Hamuj();
}
else
{
    Console.WriteLine("Niema takiej opcji.");
}
//comment w commitcie