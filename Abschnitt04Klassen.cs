namespace CSharpTutorial.Tests;

public class Abschnitt04Klassen
{

    public class Person // Das hier ist eine Klasse namens Person
    {
        public string Name; // Das hier ist ein "Feld" der Klasse Person
        public int Alter;
        public int GrößeInCm;
    }

    [Test]
    public void KlassenDefinierenNeueTypenMitMehrerenFeldern()
    {
        Person imran = new Person(); // Variable "imran" ist kein int oder string sondern eine Person
        imran.Name = "Imran";        // Jede Person halt die "Felder" Name, Alter und GrößeInCm
        imran.Alter = 14;
        imran.GrößeInCm = 175;

        Person paul = new Person();
        paul.Name = "Paul";
        paul.Alter = 35;
        paul.GrößeInCm = 178;

        Person misterX = imran;

        Assert.That(imran.Name, Is.EqualTo("Imran"));
        Assert.That(imran.Alter, Is.EqualTo(14));
        Assert.That(imran.GrößeInCm, Is.EqualTo(175));

        Assert.That(paul.Name, Is.EqualTo("Paul"));
        Assert.That(paul.Alter, Is.EqualTo(35));
        Assert.That(paul.GrößeInCm, Is.EqualTo(178));

        Assert.That(misterX, Is.SameAs(imran));
    }






    // AUFGABE: Schreibe eine Klasse "Auto" mit den öffentlichen Feldern: Marke (string), Modell (string), BaujahrinJahr (int)
    // Lass den Test in Ruhe, schreib nur die Klasse!
    public class Auto
    {
        public string Marke;
        public string Modell;
        public int Baujahr;
    }


    [Test]
    public void AufgabeKlasseMitPublicFeldern()
    {
        Auto meinAuto = new Auto();
        meinAuto.Marke = "VW";
        meinAuto.Modell = "Golf";
        meinAuto.Baujahr = 2018;

        Assert.That(meinAuto.Marke, Is.EqualTo("VW"));
        Assert.That(meinAuto.Modell, Is.EqualTo("Golf"));
        Assert.That(meinAuto.Baujahr, Is.EqualTo(2018));
    }
    /* */






    public class Konto
    {
        public int kontostandInCent = 0;
    }

    [Test]
    public void PrivateFelderKannManVonAussenNichtSehen()
    {
        Konto meinKonto = new Konto();
        meinKonto.kontostandInCent = 1000;
        Assert.That(meinKonto.kontostandInCent, Is.EqualTo(1000));
    }
    /* */





    public class Mensch
    {
        public string Vorname;
        public string Nachname;

        public string VollständigerName() // Das hier ist eine "Methode" der Klasse Mensch
        {
            return Vorname + " " + Nachname;
        }
    }

    [Test]
    public void MethodenEnthaltenCodeDerDieFelderDerKlasseBenutzt()
    {
        Mensch person = new Mensch();
        person.Vorname = "Paul";
        person.Nachname = "Bauknecht";

        Assert.That(person.VollständigerName(), Is.EqualTo("Paul Bauknecht"));
    }







    // AUFGABE: Schreibe eine Klasse "Taschenrechner" mit den öffentlichen Feldern: Zahl1 (int), Zahl2 (int)
    // und den Methoden: Addiere() und Multipliziere() die jeweils das Ergebnis zurückgeben
    // Lass den Test in Ruhe, schreib nur die Klasse!
    public class Taschenrechner
    {
        public int Zahl1;
        public int Zahl2;
        public int Addiere()
        {
            return Zahl1 + Zahl2;
        }
        public int Multipliziere()
        {
            return Zahl1 * Zahl2;
        }

    }
    [Test]

    public void AufgabeKlasseMitFeldernUndMethoden()
    {
        Taschenrechner rechner = new Taschenrechner();
        rechner.Zahl1 = 10;
        rechner.Zahl2 = 5;

        Assert.That(rechner.Addiere(), Is.EqualTo(15));
        Assert.That(rechner.Multipliziere(), Is.EqualTo(50));
    }
    /* */





    public class Hund(string name, string rasse, int alterInJahren) // Das hier ist ein Konstruktor
    {
        private string Name = name;
        private string Rasse = rasse;
        private int AlterInJahren = alterInJahren;
        
        public string Beschreibung()
        {
            return $"Der Hund heißt {Name}, ist ein {Rasse} und {AlterInJahren} Jahre alt.";
        }
    }

    [Test]
    public void KonstruktorenStellenSicherDassAlleFelderGesetztWerden()
    {
        Hund meinHund = new Hund("Martin", "Dackel", 4);
        Assert.That(meinHund.Beschreibung(), Is.EqualTo("Der Hund heißt Martin, ist ein Dackel und 4 Jahre alt."));
    }






    // AUFGABE: Schreibe eine Klasse "Buch" mit einem Konstruktor, der Titel (string), Autor (string) und SeitenAnzahl (int) entgegennimmt
    // Die Klasse soll eine Methode Info() haben, die einen Text zurückgibt: "'{Titel}' von {Autor} hat {SeitenAnzahl} Seiten."
    // Lass den Test in Ruhe, schreib nur die Klasse!
    public class Buch(string titel, string Autor, int SeitenAnzahl)
    {
        public string Titel = titel;
        public string Autor = Autor;
        public int SeitenAnzahl = SeitenAnzahl;


        public string Info()
        {
            return ($"'{titel}' von {Autor} hat {SeitenAnzahl} Seiten.");
        }

    }

    // 
   
    [Test]
    public void AufgabeKlasseMitKonstruktor()
    {
        Buch meinBuch = new Buch("Harry Potter", "J.K. Rowling", 335);
        Assert.That(meinBuch.Info(), Is.EqualTo("'Harry Potter' von J.K. Rowling hat 335 Seiten."));
    }
    /* */





    public class Katze(string name)
    {
        private string privaterName = name;

        public string Name { 
            get // die get-Methode bestimmt, was passiert, wenn man auf den Namen der Katze zugreift, also katze.Name schreibt
            {
                Console.WriteLine("Jemand liest den Namen der Katze!");
                return privaterName;
            }
            set // die set-Methode bestimmt, was passiert, wenn man katze.Name = "NeuerName" ausführt
            {
                Console.WriteLine("Jemand ändert den Namen der Katze! Der neue Name ist " + value);
                privaterName = value;
            }
        }
    }

    [Test]
    public void PropertiesBestimmenWasPassiertWennManEineEigenschaftLiestOderSchreibt()
    {
        Katze meineKatze = new Katze("Mimi");
        meineKatze.Name = "Miezi";

        Assert.That(meineKatze.Name, Is.EqualTo("Mimi"));
    }







    public class KatzeDieManNichtUmbenennenKann(string name)
    {
        private string privaterName = name;

        public string Name { 
            get // die get-Methode bestimmt, was passiert, wenn man auf den Namen der Katze zugreift, also katze.Name schreibt
            {
                Console.WriteLine("Jemand liest den Namen der Katze!");
                return privaterName;
            }
        }
    }

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void PropertiesKönnenAuchNurLesenErlauben()
    {
        KatzeDieManNichtUmbenennenKann meineKatze = new KatzeDieManNichtUmbenennenKann("Simone");
        meineKatze.Name = "Letizia"; // Das hier führt zu einem Fehler, weil die set-Methode fehlt

        Assert.That(meineKatze.Name, Is.EqualTo("Simone"));
    }
    /* */







    public class KatzeMitGeheimemNamen()
    {
        private string privaterName = "Lucky";
        public string Name
        {
            set
            {
                Console.WriteLine("Jemand ändert den Namen der Katze! Der neue Name ist " + value);
                privaterName = value;
            }
        }
    }

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void PropertiesKönnenAuchNurSchreibenErlauben()
    {
        KatzeMitGeheimemNamen meineKatze = new KatzeMitGeheimemNamen();
        // Man kann den Namen der Katze noch setzen
        meineKatze.Name = "Whiskers";
        // Man kann ihn aber nicht mehr lesen
        Assert.That(meineKatze.Name, Is.EqualTo("Whiskers"));
    }
    /* */







    // AUFGABE: Schreibe eine Klasse "Papagei" mit einem Konstruktor, der den Namen entgegennimmt
    // Der Papagei hat eine Property "Name" mit get und set
    // Der Papagei kann nur 3 Mal umbenannt werden (beim Erstellen zählt nicht)
    // Beim 4. Mal Umbenennen soll der Name NICHT geändert werden (der Papagei kann sich den neuen Namen nicht mehr merken)
    // Tipp: Du brauchst ein privates Feld, das zählt, wie oft der Name geändert wurde
    // Lass den Test in Ruhe, schreib nur die Klasse!

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void AufgabePapageiDerSichNamenNurDreimalMerkenKann()
    {
        Papagei meinPapagei = new Papagei("Koko");
        Assert.That(meinPapagei.Name, Is.EqualTo("Koko"));

        meinPapagei.Name = "Polly"; // 1. Umbenennung
        Assert.That(meinPapagei.Name, Is.EqualTo("Polly"));

        meinPapagei.Name = "Charlie"; // 2. Umbenennung
        Assert.That(meinPapagei.Name, Is.EqualTo("Charlie"));

        meinPapagei.Name = "Max"; // 3. Umbenennung
        Assert.That(meinPapagei.Name, Is.EqualTo("Max"));

        meinPapagei.Name = "Bella"; // 4. Umbenennung - funktioniert NICHT mehr!
        Assert.That(meinPapagei.Name, Is.EqualTo("Max")); // Name bleibt "Max"
    }
    /* */
}