namespace PZ1;

public class Programista : Pracownik
{
    private int LiczbaTechnologii { get; }

    public Programista()
    {
        LiczbaTechnologii = 6;
    }

    public Programista(int id, int wiek, string imie, string nazwisko, string plec, double pensja, int liczbaTechnologii) : base(id, wiek, imie, nazwisko, plec, pensja)
    {
        LiczbaTechnologii = liczbaTechnologii;
    }
    
    protected override void IncresePensja(double increase)
    {
        base.IncresePensja(increase * LiczbaTechnologii);
    }

    public override string ToString()
    {
        return base.ToString() + $", stanowisko: programista, liczba technologii: {LiczbaTechnologii}";
    }
}