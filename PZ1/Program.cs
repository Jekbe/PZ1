namespace PZ1;

internal static class Program
{
    private const double RocznyBudrzet = 5000000;
    private static readonly List<Pracownik> Pracownicy = [];

    private static void Main()
    {
        
        
        var manager1 = new Manager();
        var manager2 = new Manager();
        var analityk1 = new Analityk();
        var analityk2 = new Analityk();
        var programista1 = new Programista();
        var programista2 = new Programista();
        var zdalnyProgramista1 = new ZdalnyProgramista();
        var zdalnyProgramista2 = new ZdalnyProgramista();
        
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
        var pracownik = Pracownicy.FirstOrDefault(p => p.Id == Convert.ToInt32(Console.ReadLine()));
        Console.WriteLine(pracownik);
    }

    private static void Zwieksz()
    {
        
    }

    private static void ZwiekszWszystkim()
    {
        
    }

    private static void SortMalejoco()
    {
        
    }

    private static void Podsumowanie()
    {
        
    }

    private static void Pomoc()
    {
        Console.WriteLine("koniec - 0");
    }
}