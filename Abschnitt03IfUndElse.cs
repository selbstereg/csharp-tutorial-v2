namespace CSharpTutorial.Tests;

public class Abschnitt03IfUndElse
{
    [Test]
    public void IfFühretCodeAusWennDieBedingungWahrIst()
    {
        int zahl = 15;

        if (zahl > 5) // if bedeutet "wenn". Hier steht also: "Wenn die zahl größer als 5 ist, dann addiere 10 dazu."
        {
            zahl += 10;
        }

        Assert.That(zahl, Is.EqualTo(25));
    }

    [Test]
    public void IfFührtCodeNichtAusWennDieBedingungFalschIst()
    {
        int zahl = 3;

        if (zahl > 5) // Hier steht also: "Wenn die zahl größer als 5 ist, dann addiere 10 dazu."
        {
            zahl = zahl + 10;
        }

        Assert.That(zahl, Is.EqualTo(3));
    }

    [Test]
    public void IfUndElseFührenCodeBedingtAus()
    {
        int zahl = 3;

        if (zahl > 5) // if bedeutet "wenn". Hier steht also: "Wenn die zahl größer als 5 ist, dann addiere 10 dazu."
        {
            zahl = zahl + 10;
        }
        else // else bedeutet "sonst". Hier steht also: "Sonst ziehe 10 ab."
        {
            zahl = zahl + 5;
        }

        Assert.That(zahl, Is.EqualTo(8));
    }

    [Test]
    public void WelcheCodeBlöckeWerdenNichtAusgeführt()
    {
        int zahl = 10;

        if (zahl > 5)
        {
            zahl = zahl + 10; //<-
        }
        if (zahl > 25)
        {
            zahl = zahl + 5; //no
        }
        if (zahl > 15)
        {
            zahl = zahl - 15; //yes
        }
        if (zahl > 10)
        {
            zahl = zahl + 10; //no
        }

        Assert.That(zahl, Is.EqualTo(5));
    }

// TODO: Überleg dir ne bessere Aufgabenstellung, wo klar ist dass der code in die Mitte gehört
//  und dass er universell gelten muss (z.B. random numbers für punkte und dann nen print)
    [Test]
    public void SchreibeDenIfElseCodeBlockSelbst()
    {
        int punkteTeamA = 3;
        int punkteTeamB = 3;
        string gewinner = "";

        if (punkteTeamA < punkteTeamB)
        {
            gewinner = "Team B";
        }
        else if (punkteTeamA == punkteTeamB)
        {
            gewinner = "gleichstand";
        }
        else
        {
            gewinner = "Team A";
        }
        // Schreibe eine If...Else Anweisung, die überprüft welches Team Gewinner ist

        Console.WriteLine($"Gewinner ist {gewinner}!");
        Assert.Pass();
    }
    /* */
}