namespace PZ1;

public abstract class Pracownik
{
    private int Id { get; }
    private int Wiek { get; }
    private string Imie { get; }
    private string Nazwisko { get; }
    private string Plec { get; }
    private double Pensja { get; set; }
    
    protected Pracownik()
    {
        Id = 1;
        Imie = "Jan";
        Nazwisko = "Kowalski";
        Plec = "M";
        Wiek = 40;
        Pensja = 6000;
    }

    protected Pracownik(int id, int wiek, string imie, string nazwisko, string plec, double pensja)
    {
        Id = id;
        Wiek = wiek;
        Imie = imie;
        Nazwisko = nazwisko;
        Plec = plec;
        Pensja = pensja;
    }
    
    protected virtual void IncresePensja(double increase)
    {
        Pensja += increase;
    }

    public override string ToString()
    {
        return $"ID: {Id}, {Imie} {Nazwisko}, wiek: {Wiek}, płeć: {Plec}, pensja: {Pensja}";
    }
}