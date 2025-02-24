namespace PZ1;

public class ZdalnyProgramista : Programista
{
    private int Odleglosc { get; }

    public ZdalnyProgramista()
    {
        Odleglosc = 150;
    }

    public ZdalnyProgramista(int id, int wiek, string imie, string nazwisko, string plec, double pensja, int liczbaTechnologii, int odleglosc) : base(id, wiek, imie, nazwisko, plec, pensja, liczbaTechnologii)
    {
        Odleglosc = odleglosc;
    }
    
    protected override void IncresePensja(double increase)
    {
        base.IncresePensja(increase * 20 / Odleglosc);
    }

    public override string ToString()
    {
        return base.ToString() + $", stanowisko: zdalny programista, odległość: {Odleglosc}";
    }
}