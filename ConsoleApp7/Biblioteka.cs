using System.Collections.Generic;

namespace ConsoleApp7;

public class Biblioteka
{
    public List<Ksiazka> ksiazki = new List<Ksiazka>();

    public void DodajKsiazke(Ksiazka nowaKsiazka)
    {
        nowaKsiazka.Id = new_id();
        nowaKsiazka.Status = false;
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

    public int new_id()
    {   
        int max_id = 0;
        foreach (Ksiazka ksiazka in ksiazki)
        {
            if (ksiazka.Id > max_id)
            {
                max_id = ksiazka.Id;
            }
        }
        return max_id + 1;

    }

    public void changeStatus(int id)
    {
        var response = ksiazki.Find(r => r.Id == id);

        if (response != null)
        {
            response.Status = !response.Status;
            /*if (response.Status)
            {
                response.Status = false;
            }
            else
            {
                response.Status = true;
            }*/
        }
        else
        {
            Console.WriteLine("*********************************************************");
            Console.WriteLine("Uwaga!!! brak wybranej książki - NIE mogę zmienić statusu");
            Console.WriteLine("*********************************************************");
        }

        
    }
}