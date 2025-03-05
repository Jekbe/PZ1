namespace PZ1;

public class ZdalnyProgramista : Programista
{
    public int Odleglosc { get; set; }

    public ZdalnyProgramista()
    {
    }

    public ZdalnyProgramista(int id, string imie, string nazwisko, int wiek, string plec, double pensja, int liczbaTechnologii, int odleglosc) : base(id,  imie, nazwisko, wiek, plec, pensja, liczbaTechnologii)
    {
        Odleglosc = odleglosc;
    }
    
    public override void IncreasePensja(double increase)
    {
        base.IncreasePensja(increase * 20 / Odleglosc);
    }

    public override string ToString()
    {
        return base.ToString() + $", stanowisko: zdalny programista, odległość: {Odleglosc}";
    }
}