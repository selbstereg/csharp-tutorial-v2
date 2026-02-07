/*
    ### Exkurs Boolsche Logik: ###


    Nehmen wir zwei Sätze:
    1. "Paul ist älter als 67 Jahre."
    2. "Paul arbeitet als Programmierer."

    Der erste Satz ist falsch, der zweite Satz ist wahr.


    --- Verknüpfung mit "und" ---

    Wenn man nun diese beiden Sätze mit "und" verbindet, also:

    "Paul ist älter als 67 Jahre UND Paul arbeitet als Programmierer."

    Ist dieser zusammengesetzte Satz dann falsch oder wahr?


    --- Verknüpfung mit "oder" ---

    Wenn man diese beiden Sätze mit "oder" verbindet, also:

    "(Entweder) Paul ist älter als 67 Jahre ODER Paul arbeitet als Programmierer."

    Diesen Satz könnte z.B. jemand äußern, der sich nicht mehr sicher ist, ob er sich
    richtig an mich erinnert, oder mich mit jemandem verwechselt.

    Ist dieser zusammengesetzte Satz falsch oder wahr?


    --- Verneinung ---

    Nun nehmen wir den zweiten Satz und verneinen ihn:

    "Paul arbeitet NICHT als Programmierer."

    Ist der Satz nun wahr oder falsch?

    Dasselbe mit dem ersten Satz:

    "Paul ist NICHT älter als 67 Jahre."

    Ist dieser Satz wahr oder falsch?


    --- Verallgemeinerung ---

    Dies sind allgemeine Logik-Regeln, die man Abstrakt aufschreiben kann:

    - Wahr UND Falsch = Falsch
    - Wahr ODER Falsch = Wahr
    - NICHT Wahr = Falsch
    - NICHT Falsch = Wahr


    --- Übertragung in die Programmierung ---

    In C# gibt es die booleschen Werte "true" (wahr) und "false" (falsch).
    Außerdem gibt es die logischen Operatoren:
    - UND: &&  (shift + 6)
    - ODER: || (alt gr + <)
    - NICHT: !
*/

namespace CSharpTutorial.Tests;

public class Abschnitt05BoolscheLogik
{
    public class Person(int alter, string beschäftigung)
    {
        public int Alter = alter;
        public string Beschäftigung = beschäftigung;
    }

    [Test]
    public void BoolscheLogikDrücktSätzeDerNatürlichenSpracheAus()
    {
        Person paul = new Person(35, "Programmierer");
        
        bool paulIstÄlterAls67 = paul.Alter > 67;
        bool paulIstProgrammierer = paul.Beschäftigung == "Programmierer";

        bool verknüpfterSatzMitUnd = paulIstÄlterAls67 && paulIstProgrammierer;
        bool verknüpfterSatzMitOder = paulIstÄlterAls67 || paulIstProgrammierer;

        Assert.That(verknüpfterSatzMitUnd, Is.EqualTo(true));
        Assert.That(verknüpfterSatzMitOder, Is.EqualTo(false));
    }

    [Test]
    public void BoolscheLogikKannAuchVerneinungenAusdrücken()
    {
        Person paul = new Person(35, "Programmierer");
        
        bool paulIstÄlterAls67 = paul.Alter > 67;
        bool paulIstProgrammierer = paul.Beschäftigung == "Programmierer";

        bool paulIstNichtÄlterAls67 = !paulIstÄlterAls67;
        bool paulIstNichtProgrammierer = !paulIstProgrammierer;
        bool mehrfachVerneinterSatz = !!!!paulIstNichtÄlterAls67;

        Assert.That(paulIstNichtÄlterAls67, Is.EqualTo(true));
        Assert.That(paulIstNichtProgrammierer, Is.EqualTo(false));
        Assert.That(mehrfachVerneinterSatz, Is.EqualTo(false));
    }

    /*
        Hier sind nochmal die zwei Sätze von oben:
        1. "Paul ist älter als 67 Jahre."           --> false
        2. "Paul arbeitet als Programmierer."       --> true

        Fügen wir noch zwei Sätze hinzu:
        3. "Imran ist jünger als 16 Jahre."         --> true
        4. "Imran ist Schüler."                     --> false

        Was passiert, wenn man zwei wahre Sätze mit "und" verknüpft?
        Was passiert, wenn man zwei falsche Sätze mit "oder" verknüpft?

        Aufgabe: Fülle folgende Tabellen aus

         Satz A     | Satz B    | A UND B
        ------------|-----------|---------
         true       | true      |
         true       | false     |
         false      | true      |
         false      | false     |

         Satz A     | Satz B    | A ODER B
        ------------|-----------|---------
         true       | true      |
         true       | false     |
         false      | true      |
         false      | false     |
    
    */

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void TestFürUndTabelle()
    {
        bool trueUndTrue = true && true;
        bool trueUndFalse = true && false;
        bool falseUndTrue = false && true;
        bool falseUndFalse = false && false;        

        Assert.That(trueUndTrue, Is.EqualTo(...));
        Assert.That(trueUndFalse, Is.EqualTo(...));
        Assert.That(falseUndTrue, Is.EqualTo(...));
        Assert.That(falseUndFalse, Is.EqualTo(...));
    }
    /* */

    // AUFGABE: Schreibe einen weiteren Test für die zweite Tabelle (ODER)
    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void TestFürOderTabelle()
    {
        bool trueOderTrue = ...;
        bool trueOderFalse = ...;
        ...

        Assert.That(trueOderTrue, Is.EqualTo(...));
        Assert.That(trueOderFalse, Is.EqualTo(...));
        Assert.That(falseOderTrue, Is.EqualTo(...));
        Assert.That(falseOderFalse, Is.EqualTo(...));
    }
    /* */

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void BoolscheLogikKannEntscheidenObJemandInRenteGehenKann()
    {
        Person paul = new Person(35, "Programmierer");

        int rentenalter = 67;

        if (...)
        {
            paul.Beschäftigung = "Renter";
        }

        Assert.That(paul.Beschäftigung, Is.EqualTo("Programmierer"));
    }
    /* */

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void BoolscheLogikKannDieRichtigeAnredeWählen()
    {
        Person imran = new Person(15, "Schüler");
        Person paul = new Person(35, "Programmierer");

        string anredeFürImran = "";

        if (...)
        {
            anredeFürImran = "Du";
        }
        else
        {
            anredeFürImran = "Sie";
        }

        string textFürImran = $"{anredeFürImran} Paket kommt morgen um 10 Uhr an";

        Assert.That(textFürImran, Is.EqualTo("Dein Paket kommt morgen um 10 Uhr an"));

        string anredeFürPaul = "";

        if (...)
        {
            anredeFürPaul = "Du";
        }
        else
        {
            anredeFürPaul = "Sie";
        }

        string textFürPaul = $"{anredeFürPaul} Paket kommt morgen um 10 Uhr an";

        Assert.That(textFürPaul, Is.EqualTo("Ihr Paket kommt morgen um 10 Uhr an"));
    }
    /* */

    // AUFGABE: Erweitere die Klasse Person um eine Methode "AnredeGenitiv", die basierend auf dem Alter
    //          die richtige Anrede ("Dein" oder "Ihr") zurückgibt.

    /* ----- DIESE ZEILE LÖSCHEN, UM DEN TEST ZU AKTIVIEREN -----
    [Test]
    public void WennManEineMethodeVerwendetMussManDenIfElseBlockNichtZweimalSchreiben()
    {
        Person imran = new Person(15, "Schüler");
        Person paul = new Person(35, "Programmierer");

        string textFürImran = $"{imran.AnredeGenitiv()} Paket kommt morgen um 10 Uhr an";
        string textFürPaul = $"{paul.AnredeGenitiv()} Paket kommt morgen um 10 Uhr an";

        Assert.That(textFürImran, Is.EqualTo("Dein Paket kommt morgen um 10 Uhr an"));
        Assert.That(textFürPaul, Is.EqualTo("Ihr Paket kommt morgen um 10 Uhr an"));
    }
    /* */

    /*
        Durch die Boolsche Logik wird besonders deutlich, dass Programmiersprachen und natürliche
        Sprachen sehr ähnlich sind. Auch Programme sind Texte, die man lesen kann und die eine
        Bedeutung haben. Der Unterschied einer Programmiersprache zu einer natürlichen
        Sprache ist im wesentlichen:

        1. eine Programmiersprache folgt so klaren Regeln, dass auch ein Computer sie verstehen kann
        2. eine Programmiersprache kennt keine Zweideutigkeiten oder Ungenauigkeiten, so
           dass ein Computer ein Programm immer genau gleich ausführt.

        Durch die Fortschritte im Bereich der Künstlichen Intelligenz können Computer auch
        zunehmend natürliche Sprachen verstehen.
        Eine Küntliche Intelligenz verarbeitet einen Text in Natürlicher Sprache aber nach
        statistischen Regeln und es kann niemals garantiert werden, dass sie ihn immer gleich
        verarbeitet.
    */
}