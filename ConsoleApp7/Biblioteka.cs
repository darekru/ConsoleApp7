namespace ConsoleApp7;

public class Biblioteka
{
    public List<Ksiazka> ksiazki = new List<Ksiazka>();

    public void DodajKsiazke(Ksiazka nowaKsiazka)
    {
        ksiazki.Add(nowaKsiazka);
        Console.WriteLine($"Dodano książkę: {nowaKsiazka.Tytul}");
    }

    public void WyswietlKsiazki()
    {
        if (ksiazki.Count == 0)
        {
            Console.WriteLine("Sorry biedaku, ale nie masz jeszcze książek!");
            return;
        }

        Console.WriteLine("Książki dostępne w bibliotece:");
        foreach (Ksiazka ksiazka in ksiazki)
        {
            ksiazka.WyswietlInformacjeOKsiazce();
        }
    }
}