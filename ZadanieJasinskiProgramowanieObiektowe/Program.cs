using ZadanieJasinskiProgramowanieObiektowe;

Samochod klasaSamochod = new Samochod("Fiar", 2010);

Samochod auto1 = new Samochod("BMW", 2022);
Samochod auto2 = new Samochod("Audi", 2023);

Kalkulator kalkulatorek = new Kalkulator();

KontoBankowe kontoBankowe = new KontoBankowe();

//klasaSamochod.Marka = "Fiat";
//klasaSamochod.RokProdukcji = 2010;

//auto1.Marka = "BMW";
//auto1.RokProdukcji = 2022;

//auto2.Marka = "Audi";
//auto2.RokProdukcji = 2023;

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

while (true)
{
    Console.WriteLine("""
                      Chcesz się rozpędzić czy zachamować?
                      1 - Rozpędzić
                      2 - Zachamować
                      3 - Koniec
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
    else if (WyborKontroliSamochodu == 3)
    {
        Console.WriteLine("\nKoniec kontroli samochodu.");
        break;
    }
    else
    {
        Console.WriteLine("\nNiema takiej opcji.");
    }
}

double wyplaconaKasa = 0;

Console.WriteLine("""
                  Chcesz wypłacić pieniądze z konta?
                  1 - Tak
                  2 - Nie
                  """);

int WyborWyplaty = Convert.ToInt32(Console.ReadLine());

if (WyborWyplaty == 1)
{
    Console.WriteLine("\nIle chcesz wypłacić?");
    decimal KwotaWyplaty = Convert.ToDecimal(Console.ReadLine());
    kontoBankowe.Wyplac(KwotaWyplaty);
    wyplaconaKasa += Convert.ToDouble(KwotaWyplaty);
}
else if (WyborWyplaty == 2)
{
    Console.WriteLine("\nKoniec wypłat z konta.");
}
else
{
    Console.WriteLine("\nNiema takiej opcji.");
}

double cenaPaliwa = 6.5;
double litry = 20;

double cenaPaliwaNaWycieczke = kalkulatorek.Mnozenie(cenaPaliwa, litry);

if(wyplaconaKasa >= cenaPaliwaNaWycieczke)
{
    Console.Write($"\nZatankowano samochód {klasaSamochod.Marka}");
}
else
{
    Console.Write("\nWybrałeś za mało gotówki na paliwo.");
}