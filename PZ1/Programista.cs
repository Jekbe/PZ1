namespace PZ1;

public class Programista : Pracownik
{
    public int LiczbaTechnologii { get; set; }

    public Programista()
    {
    }

    public Programista(int id, string imie, string nazwisko, int wiek, string plec, double pensja, int liczbaTechnologii) : base(id, wiek, imie, nazwisko, plec, pensja)
    {
        LiczbaTechnologii = liczbaTechnologii;
    }
    
    public override void IncreasePensja(double increase)
    {
        base.IncreasePensja(increase * LiczbaTechnologii);
    }

    public override string ToString()
    {
        return base.ToString() + $", stanowisko: programista, liczba technologii: {LiczbaTechnologii}";
    }
}