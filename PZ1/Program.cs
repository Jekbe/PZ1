namespace PZ1;

internal static class Program
{
    private const double RocznyBudrzet = 300000;
    private static readonly List<Pracownik> Pracownicy = [];

    private static void Main()
    {
        
        
        var manager1 = new Manager(1, "Anna", "Nowak", 35, "K", 6500, 2);
        var manager2 = new Manager(2, "Piotr", "Kowalski", 40, "M", 7000, 3);

        var analityk1 = new Analityk(3, "Ewa", "Dąbrowska", 30, "K", 6000, 5);
        var analityk2 = new Analityk(4, "Marek", "Wiśniewski", 38, "M", 6200, 7);

        var programista1 = new Programista(5, "Tomasz", "Lewandowski", 28, "M", 5800, 4);
        var programista2 = new Programista(6, "Katarzyna", "Zielińska", 32, "K", 6100, 6);

        var zdalnyProgramista1 = new ZdalnyProgramista(7, "Robert", "Wójcik", 29, "M", 5900, 5, 100);
        var zdalnyProgramista2 = new ZdalnyProgramista(8, "Agnieszka", "Mazur", 31, "K", 6200, 7, 150);
        
        Pracownicy.Add(manager1);
        Pracownicy.Add(manager2);
        Pracownicy.Add(analityk1);
        Pracownicy.Add(analityk2);
        Pracownicy.Add(programista1);
        Pracownicy.Add(programista2);
        Pracownicy.Add(zdalnyProgramista1);
        Pracownicy.Add(zdalnyProgramista2);

        var run = true;
        while (run)
        {
            Pomoc();
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0:
                    run = false;
                    break;
                case 1:
                    Lista();
                    break;
                case 2:
                    Info();
                    break;
                case 3:
                    Zwieksz();
                    break;
                case 4:
                    ZwiekszWszystkim();
                    break;
                case 5:
                    SortMalejoco();
                    break;
                case 6:
                    Podsumowanie();
                    break;
                default: 
                    Console.WriteLine("Nieznana opcja");
                    break;
            }
        }
    }

    private static void Lista()
    {
        Console.WriteLine("Pracownicy:");
        foreach (var pracownik in Pracownicy)
        {
            Console.WriteLine(pracownik.Id);
        }
    }

    private static void Info()
    {
        Console.WriteLine("Podaj id: ");
        var id = Convert.ToInt32(Console.ReadLine());
        var pracownik = Pracownicy.FirstOrDefault(p => p.Id == id);
        Console.WriteLine(pracownik);
    }

    private static void Zwieksz()
    {
        Console.WriteLine("Podaj id: ");
        var id = Convert.ToInt32(Console.ReadLine());
        var pracownik = Pracownicy.FirstOrDefault(p => p.Id == id);
        Console.WriteLine("Podaj podwyżkę: ");
        pracownik?.IncreasePensja(Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine("Pensja została podniesiona");
    }

    private static void ZwiekszWszystkim()
    {
        Console.WriteLine("Podaj kwotę: ");
        var podwyzka = Convert.ToInt32(Console.ReadLine());
        
        foreach (var pracownik in Pracownicy)
        {
            pracownik.IncreasePensja(podwyzka);
        }
    }

    private static void SortMalejoco()
    {
        foreach (var pracownik in Pracownicy.OrderByDescending(p => p.Pensja))
        {
            Console.WriteLine(pracownik.ToString());
        }
    }

    private static void Podsumowanie()
    {
        var wyplaty = Pracownicy.Sum(p => p.Pensja);
        Console.WriteLine($"Budrzet wynosi: {RocznyBudrzet}");
        Console.WriteLine($"Wyplaty wyniosły : {wyplaty}");

        var roznica = RocznyBudrzet - wyplaty;
        Console.ForegroundColor = roznica >= 0 ? ConsoleColor.Green : ConsoleColor.Red;
        Console.WriteLine($"Roznica: {roznica}");
        Console.ResetColor();
    }

    private static void Pomoc()
    {
        Console.WriteLine("koniec - 0");
        Console.WriteLine("lista pracowników - 1");
        Console.WriteLine("informacja o pracowniku - 2");
        Console.WriteLine("zwiększ pensję pracownika - 3");
        Console.WriteLine("zwiększ pensję wszystkim - 4");
        Console.WriteLine("lista pracowników według pensji - 5");
        Console.WriteLine("podsumowanie - 6");
    }
}