namespace PZ1;

public class ZdalnyProgramista : Programista
{
    public int Odleglosc { get; }

    public ZdalnyProgramista()
    {
        Odleglosc = 150;
    }

    public ZdalnyProgramista(int id, int wiek, string imie, string nazwisko, string plec, double pensja, int liczbaTechnologii, int odleglosc) : base(id, wiek, imie, nazwisko, plec, pensja, liczbaTechnologii)
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