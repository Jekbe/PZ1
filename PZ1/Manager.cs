namespace PZ1;

public class Manager : Pracownik
{
    public int LiczbaProjektow { get; set; }

    public Manager()
    {
    }

    public Manager(int id, string imie, string nazwisko, int wiek, string plec, double pensja, int liczbaProjektow) : base(id, wiek, imie, nazwisko, plec, pensja)
    {
        LiczbaProjektow = liczbaProjektow;
    }

    public override void IncreasePensja(double increase)
    {
        base.IncreasePensja(increase * LiczbaProjektow);
    }

    public override string ToString()
    {
        return base.ToString() + $", stanowisko: manager, liczba projektow: {LiczbaProjektow}";
    }
}