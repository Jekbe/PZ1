namespace PZ1;

public abstract class Pracownik
{
    public int Id { get; }
    public int Wiek { get; }
    public string Imie { get; }
    public string Nazwisko { get; }
    public string Plec { get; }
    public double Pensja { get; set; }
    
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
    
    public virtual void IncreasePensja(double increase)
    {
        Pensja += increase;
    }

    public override string ToString()
    {
        return $"ID: {Id}, {Imie} {Nazwisko}, wiek: {Wiek}, płeć: {Plec}, pensja: {Pensja}";
    }
}