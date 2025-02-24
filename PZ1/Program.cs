namespace PZ1;

class Program
{
    private const double RocznyBudrzet = 5000000;
    
    static void Main(string[] args)
    {
        var pracownicy = new List<Pracownik>();
        
        var manager1 = new Manager();
        var manager2 = new Manager();
        var analityk1 = new Analityk();
        var analityk2 = new Analityk();
        var programista1 = new Programista();
        var programista2 = new Programista();
        var zdalnyProgramista1 = new ZdalnyProgramista();
        var zdalnyProgramista2 = new ZdalnyProgramista();
        
        pracownicy.Add(manager1);
        pracownicy.Add(manager2);
        pracownicy.Add(analityk1);
        pracownicy.Add(analityk2);
        pracownicy.Add(programista1);
        pracownicy.Add(programista2);
        pracownicy.Add(zdalnyProgramista1);
        pracownicy.Add(zdalnyProgramista2);

        var run = true;
        while (run)
        {
            switch (Console.ReadLine())
            {
                case "koniec":
                    run = false;
                    break;
                case "lista":
                    break;
                case "info":
                    break;
                case "zwieksz":
                    break;
                case "zwiekszWszystkim":
                    break;
                case "sortMalejoco":
                    break;
                case "podsumowanie":
                    break;
                default: 
                    Console.WriteLine("Nieznana opcja");
                    break;
            }
        }
    }
}