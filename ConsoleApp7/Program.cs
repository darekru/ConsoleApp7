//Aplikacja konsolowa - zarzadzenia biblioteka
//Wyswietlic wszystkie ksiazki ktore posiadam - ZROBIONE
//Ksiazka bedzie zawierac tytul, autora, rok wydania - ZROBIONE
//Mozliwosc dodawania nowych ksiazek - ZROBIONE
//Mozliwosc zdecydowania kiedy aplikacja zostanie wylaczona - ZROBIONE

//ZADANIE DO WLASNEGO WYKONANIA: Dodaj możliwość oznaczania książek
//jako przeczytane, dodaj numerowanie książek
//Wprowadzic mozliwosc modyfikacji - zmien ksiazke nieprzeczytana w przeczytana

using ConsoleApp7;

Biblioteka biblio = new Biblioteka();

bool czyKontynuowac = true;

while (czyKontynuowac)
{
    Console.WriteLine("--------------------------------------------------------------");
    Console.WriteLine("Witaj w systemie zarządzania biblioteką");
    Console.WriteLine("Wybierz dostępną operację:");
    Console.WriteLine("1. Dodaj książkę");
    Console.WriteLine("2. Wyświetl książki");
    Console.WriteLine("3. Zmień statu z przeczytana na nieprzeczytana i odwrotnie");
    Console.WriteLine("4. Wyjdź z aplikacji");
    Console.WriteLine("Wpisz numer operacji i zatwierdź Enterem:");

    string operacja = Console.ReadLine();

    switch (operacja)
    {
        case "1":
            Console.WriteLine("Wpisz tytuł i zatwierdź enterem:");
            string tytul = Console.ReadLine();
            Console.WriteLine("Wpisz autora i zatwierdź enterem:");
            string autor = Console.ReadLine();
            Console.WriteLine("Wpisz datę publikacji i zatwierdź enterem:");
            string dataPublikacjiTekst = Console.ReadLine();
            int dataPublikacji;
            int.TryParse(dataPublikacjiTekst, out dataPublikacji);
            Ksiazka ksiazka = new Ksiazka(tytul, autor, dataPublikacji);
            biblio.DodajKsiazke(ksiazka);
            break;
        case "2":
            biblio.WyswietlKsiazki();
            break;
        case "3":
            Console.WriteLine("Wpisz numer książki do zmiany statusu i zatwierdź enterem:");
            string numerKsiazkiText = Console.ReadLine();
            int numerKsiazki;
            int.TryParse(numerKsiazkiText, out numerKsiazki);
            biblio.changeStatus(numerKsiazki);
            break;
        case "4":
            czyKontynuowac = false;
            Console.WriteLine("Zamykam aplikację...");
            break;
        default:
            Console.WriteLine("Nie ma takiej operacji. Spróbuj ponownie...");
            break;
    }
}
