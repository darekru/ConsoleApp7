using System.Numerics;

namespace ConsoleApp7;

public class Ksiazka
{   
    public int Id {  get; set; }
    public string Tytul { get; set; }
    public string Autor { get; set; }
    public int DataPublikacji { get; set; }
    public bool Status { get; set; }

    public Ksiazka(string tytul, string autor, int dataPublikacji)
    {
        Tytul = tytul;
        Autor = autor;
        DataPublikacji = dataPublikacji;
    }

    public void WyswietlInformacjeOKsiazce()
    {
        string TakNie;
        if (Status)
        {
            TakNie = "TAK";
        } 
        else
        {
           TakNie = "NIE";
        }
        Console.WriteLine($"ID: {Id} Autor: {Autor}, Tytul: {Tytul}, Data Publikacji: {DataPublikacji} Przeczytana: {TakNie}");
    }
}