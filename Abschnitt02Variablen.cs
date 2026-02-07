namespace CSharpTutorial.Tests;

public class Abschnitt02Variablen
{
    
    [Test]
    public void VariablenHabenTypen()
    {
        int zahl = 42;
        string text = "Hallo :)";
        bool boolean = true;

        Assert.That(zahl, Is.EqualTo(42));
        Assert.That(text, Is.EqualTo("Hallo :)"));
        Assert.That(boolean, Is.True);
    }
    /* */

    [Test]
    public void VariablenKannManKopieren()
    {
        int zahl = 42;
        string text = "Hallo :)";
        string textKopie = text;

        Assert.That(zahl, Is.EqualTo(42));
        Assert.That(text, Is.EqualTo("Hallo :)"));
        Assert.That(textKopie, Is.EqualTo("Hallo :)"));
    }
    /* */

    [Test]
    public void TypenKönnenAuchVomWertAbgeleitetWerden()
    {
        var zahl = "Hallo";
        var text = 42;
        
        Assert.That(zahl, Is.EqualTo("Hallo"));
        Assert.That(text, Is.EqualTo(42));
    }
    /* */

    [Test]
    public void VariablenKönnenSichÄndern()
    {
        int zaehler = 0;
        Assert.That(zaehler, Is.EqualTo(0));
        
        zaehler = 10;
        Assert.That(zaehler, Is.EqualTo(10));
        
        zaehler = zaehler + 5;
        Assert.That(zaehler, Is.EqualTo(15));
        
        zaehler += 10;
        Assert.That(zaehler, Is.EqualTo(25));
    }

/*
    [Test]
    public void RechnenMitZahlen()
    {
        int a = 12;
        int b = 3;
        
        int aPlusB = a + b;// addieren
        int aMinusB = a - b;// subtrahieren
        int aMalB = a * b;// multiplizieren
        int aGeteiltDurchb = a / b;// dividieren
        
        Assert.That(aPlusB, Is.EqualTo(0));
        Assert.That(aMinusB, Is.EqualTo(0));
        Assert.That(aMalB, Is.EqualTo(0));
        Assert.That(aGeteiltDurchb, Is.EqualTo(0));
    }
    /* */

    [Test]
    public void ManKannAuchMitKommazahlenRechnen()
    {
        float breite = 5.5f;
        float hoehe = 4.0f;
        
        float flaecheninhalt = breite * hoehe; // breite mal hoehe
        
        double radius = 3.0;
        double pi = Math.PI;
        double umfang = radius * pi*2;
        
        Assert.That(flaecheninhalt, Is.EqualTo(22.0f));
        Assert.That(umfang, Is.EqualTo(18.84955592153876));
    }

    [Test]
    public void TexteKannManMitPlusZusammenfügen()
    {
        string vorname = "Max ";
        string nachname = "Mustermann";
        string gesamterName = vorname + nachname;
        
        int alter = 30;
        string text = "Alter: " + alter;
        
        Assert.That(gesamterName, Is.EqualTo("Max Mustermann"));
        Assert.That(text, Is.EqualTo("Alter: 30"));
    }

    [Test]
    public void VariablenInEinenSatzEinfügen()
    {
        string name = "Anna";
        int alter = 25;
        string satz = $"Ich heiße {name} und bin {alter} Jahre alt.";
        string str = $"hallo {name} ich bin 20";

        Assert.That(str, Is.EqualTo("hallo Anna ich bin 20"));
        
        Assert.That(satz, Is.EqualTo("Ich heiße Anna und bin 25 Jahre alt."));
    }

    [Test]
    public void ZahlenInTextUmwandeln()
    {
        int zahl = 42;
        string zahlAlsText = zahl.ToString();
        
        float pi = 3.1416f;
        string piAlsText = pi.ToString();
        
        Assert.That(zahlAlsText, Is.EqualTo("42"));
        Assert.That(piAlsText, Is.EqualTo("3.1416"));
    }

    [Test]
    public void TextInZahlUmwandeln()
    {
        string zahlenText = "123";
        int geparst = int.Parse(zahlenText);
        
        string doubleText = "3.14";
        double geparstesDouble = double.Parse(doubleText);
        
        Assert.That(geparst, Is.EqualTo(123));
        Assert.That(geparstesDouble, Is.EqualTo(3.14));
    }

}
