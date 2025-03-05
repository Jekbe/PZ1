namespace PZ1;

public abstract class Pracownik
{
    public int Id { get; set; }
    public int Wiek { get; set; }
    public string Imie { get; set;  }
    public string Nazwisko { get; set; }
    public string Plec { get; set; }
    public double Pensja { get; set; }
    
    protected Pracownik()
    {
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