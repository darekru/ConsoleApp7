namespace ConsoleApp7;

public class Ksiazka
{
    public string Tytul { get; set; }
    public string Autor { get; set; }
    public int DataPublikacji { get; set; }

    public Ksiazka(string tytul, string autor, int dataPublikacji)
    {
        Tytul = tytul;
        Autor = autor;
        DataPublikacji = dataPublikacji;
    }

    public void WyswietlInformacjeOKsiazce()
    {
        Console.WriteLine($"Autor: {Autor}, Tytul: {Tytul}, Data Publikacji: {DataPublikacji}");
    }
}