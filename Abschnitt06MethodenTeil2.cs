/*
    In Abschnitt04Klassen haben wir bereits Methoden kennengelernt.
    Methoden sind Code-Blöcke, die zu einer Klasse gehören und die Felder der Klasse verwenden können.

    In diesem Abschnitt lernen wir Methoden noch besser kennen:
    - Methoden können Parameter entgegennehmen
    - Methoden können Werte zurückgeben (return)
    - Methoden müssen nicht immer etwas zurückgeben (void)
    - Methoden können andere Methoden aufrufen
*/

namespace CSharpTutorial.Tests;

public class Abschnitt06MethodenTeil2
{
    public class Rechner
    {
        public int Addiere(int a, int b) // Diese Methode hat zwei Parameter: a und b
        {
            return a + b; // return gibt das Ergebnis zurück
        }

        public int Subtrahiere(int a, int b)
        {
            return a - b;
        }
    }

    [Test]
    public void MethodenKönnenParameterEntgegennehmen()
    {
        Rechner rechner = new Rechner();
        
        int ergebnis1 = rechner.Addiere(10, 5);
        int ergebnis2 = rechner.Addiere(20, 30);
        int ergebnis3 = rechner.Subtrahiere(100, 25);

        Assert.That(ergebnis1, Is.EqualTo(0));
        Assert.That(ergebnis2, Is.EqualTo(0));
        Assert.That(ergebnis3, Is.EqualTo(0));
    }

    public class Person(string name, int alter)
    {
        public string Name = name;
        public int Alter = alter;

        public string Begrüßung(string anrede)
        {
            return $"{anrede}, ich bin {Name} und bin {Alter} Jahre alt.";
        }
    }

    [Test]
    public void MethodenKönnenParameterUndFelderKombinieren()
    {
        Person paul = new Person("Paul", 35);
        Person imran = new Person("Imran", 15);

        string begrüßungPaul = paul.Begrüßung("Hallo");
        string begrüßungImran = imran.Begrüßung("Hi");

        Assert.That(begrüßungPaul, Is.EqualTo("Hi, ich bin Paul und bin 35 Jahre alt."));
        Assert.That(begrüßungImran, Is.EqualTo("Hallo, ich bin Imran und bin 15 Jahre alt."));
    }

    public class Drucker
    {
        public void DruckeText(string text) // void bedeutet: Diese Methode gibt nichts zurück
        {
            Console.WriteLine($"Drucke: {text}");
        }

        public void DruckeMehrfach(string text, int anzahl)
        {
            for (int i = 0; i < anzahl; i++)
            {
                Console.WriteLine($"Drucke: {text}");
            }
        }
    }

    [Test]
    public void MethodenMitVoidGebenNichtsZurück()
    {
        Drucker drucker = new Drucker();
        
        drucker.DruckeText("Hallo Welt");
        drucker.DruckeMehrfach("Test", 3);
        
        // Diese Methoden geben nichts zurück, man kann ihr Ergebnis also nicht in einer Variable speichern
        Assert.Pass(); // Dieser Test prüft nur, dass der Code kompiliert und ausgeführt wird
    }

    public class Temperaturprüfer
    {
        public string BewerteTemperatur(int temperatur)
        {
            if (temperatur < 0)
            {
                return "Es ist eiskalt!";
            }
            if (temperatur < 10)
            {
                return "Es ist kalt";
            }
            if (temperatur < 20)
            {
                return "Es ist kühl";
            }
            if (temperatur < 30)
            {
                return "Es ist warm";
            }
            return "Es ist heiß!"; // Wenn keine der obigen Bedingungen zutrifft
        }
    }

    [Test]
    public void MethodenKönnenMehrereReturnStatementsHaben()
    {
        Temperaturprüfer prüfer = new Temperaturprüfer();

        Assert.That(prüfer.BewerteTemperatur(-5), Is.EqualTo("Es ist eiskalt!"));
        Assert.That(prüfer.BewerteTemperatur(5), Is.EqualTo("Es ist kalt"));
        Assert.That(prüfer.BewerteTemperatur(15), Is.EqualTo("Es ist kühl"));
        Assert.That(prüfer.BewerteTemperatur(25), Is.EqualTo("Es ist heiß!"));
        Assert.That(prüfer.BewerteTemperatur(35), Is.EqualTo("Es ist warm"));
    }


    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    public class Parabel(double c) // x² + c
    {
        private double C = c;

        private double Addiere(double a, double b) // Diese Methode ist private. Von außen ist sie nicht sichtbar.
        {
            return a + b;
        }

        private double Multipliziere(double a, double b) // Diese Methode ist private. Von außen ist sie nicht sichtbar.
        {
            return a * b;
        }

        public double BerechneFormel(double x)
        {
            // Diese Methode ruft andere Methoden auf: 2 * x + 5
            double quadriert = Multipliziere(x, x);
            double ergebnis = ...;
            return ergebnis;
        }
    }


    [Test]
    public void MethodenKönnenAndereMethodenAufrufen()
    {
        Parabel parabel = new Parabel(1);

        double ergebnis = parabel.BerechneFormel(2);

        Assert.That(ergebnis, Is.EqualTo(5));
    }
    /* */

    // AUFGABE: Schreibe eine Klasse "NotizBuch" mit folgenden Methoden:
    // - FügeNotizHinzu(string notiz) -> void, fügt die Notiz zu einem privaten string-Feld hinzu (mit Zeilenumbruch \n)
    // - ZähleNotizen() -> int, gibt zurück, wie viele Notizen gespeichert sind (Tipp: Zähle die \n Zeichen)
    // - HoleAlleNotizen() -> string, gibt alle Notizen zurück
    // Lass den Test in Ruhe, schreib nur die Klasse!

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void AufgabeNotizBuchMitVerschiedenenMethodenTypen()
    {
        NotizBuch buch = new NotizBuch();
        
        buch.FügeNotizHinzu("Milch kaufen");
        buch.FügeNotizHinzu("Hausaufgaben machen");
        buch.FügeNotizHinzu("Sport");

        Assert.That(buch.ZähleNotizen(), Is.EqualTo(3));
        Assert.That(buch.HoleAlleNotizen(), Is.EqualTo("Milch kaufen\nHausaufgaben machen\nSport\n"));
    }
    /* */

    public class Rechner2
    {
        public int Addiere(int a, int b)
        {
            return a + b;
        }

        public double Addiere(double a, double b) // Gleicher Name, aber andere Parameter-Typen!
        {
            return a + b;
        }

        public int Addiere(int a, int b, int c) // Gleicher Name, aber unterschiedliche Anzahl Parameter!
        {
            return a + b + c;
        }
    }

    [Test]
    public void MethodenKönnenÜberladenWerden()
    {
        Rechner2 rechner = new Rechner2();

        int ergebnis1 = rechner.Addiere(5, 10);        // Ruft die erste Methode auf
        double ergebnis2 = rechner.Addiere(5.5, 10.3); // Ruft die zweite Methode auf
        int ergebnis3 = rechner.Addiere(1, 2, 3);      // Ruft die dritte Methode auf

        Assert.That(ergebnis1, Is.EqualTo(15));
        Assert.That(ergebnis2, Is.EqualTo(15.8));
        Assert.That(ergebnis3, Is.EqualTo(0));
    }

    // AUFGABE: Schreibe eine Klasse "Begrüßer" mit mehreren überladenen "Begrüße" Methoden:
    // - Begrüße(string name) -> gibt zurück: "Hallo {name}!"
    // - Begrüße(string vorname, string nachname) -> gibt zurück: "Hallo {vorname} {nachname}!"
    // - Begrüße(string name, int alter) -> gibt zurück: "Hallo {name}, du bist {alter} Jahre alt!"
    // Lass den Test in Ruhe, schreib nur die Klasse!

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void AufgabeÜberladeneMethodenFürBegrüßung()
    {
        Begrüßer begrüßer = new Begrüßer();

        string gruß1 = begrüßer.Begrüße("Paul");
        string gruß2 = begrüßer.Begrüße("Paul", "Bauknecht");
        string gruß3 = begrüßer.Begrüße("Imran", 15);

        Assert.That(gruß1, Is.EqualTo("Hallo Paul!"));
        Assert.That(gruß2, Is.EqualTo("Hallo Paul Bauknecht!"));
        Assert.That(gruß3, Is.EqualTo("Hallo Imran, du bist 15 Jahre alt!"));
    }
    /* */

    // AUFGABE: Schreibe eine Klasse "Bankkonto" mit:
    // - Konstruktor der den Kontostand bei Eröffnung des Kontos entgegennimmt (private int kontostandInCent)
    // - private Methode IstGedeckt(int betrag) -> prüft ob genug Geld da ist
    // - public Methode Abheben(int betrag) -> void, zieht Geld ab wenn gedeckt, sonst Meldung auf Console
    // - public Methode Einzahlen(int betrag) -> void, fügt Geld hinzu
    // - public Methode HoleKontostand() -> int, gibt Kontostand zurück
    // Lass den Test in Ruhe, schreib nur die Klasse!

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void AufgabeBankkontoMitPrivatenUndÖffentlichenMethoden()
    {
        Bankkonto konto = new Bankkonto(10000); // 100 Euro in Cent

        konto.Abheben(3000); // 30 Euro abheben
        Assert.That(konto.HoleKontostand(), Is.EqualTo(7000));

        konto.Einzahlen(5000); // 50 Euro einzahlen
        Assert.That(konto.HoleKontostand(), Is.EqualTo(12000));

        konto.Abheben(15000); // 150 Euro abheben - geht nicht, weil nicht genug Geld da ist
        Assert.That(konto.HoleKontostand(), Is.EqualTo(12000)); // Kontostand bleibt gleich
    }
    /* */
}