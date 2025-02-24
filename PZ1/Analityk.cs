namespace PZ1;

public class Analityk : Pracownik
{
    private int LiczbaKlientow { get; }

    public Analityk()
    {
        LiczbaKlientow = 11;
    }

    public Analityk(int id, int wiek, string imie, string nazwisko, string plec, double pensja, int liczbaKlientow) : base(id, wiek, imie, nazwisko, plec, pensja)
    {
        LiczbaKlientow = liczbaKlientow;
    }
    
    protected override void IncresePensja(double increase)
    {
        base.IncresePensja(increase * LiczbaKlientow);
    }

    public override string ToString()
    {
        return base.ToString() + $", stanowisko: analityk, liczba klientów: {LiczbaKlientow}";
    }
}