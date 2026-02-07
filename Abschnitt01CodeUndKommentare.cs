namespace CSharpTutorial.Tests;

public class Abschnitt01CodeUndKommentare
{
    /* 
        Dies ist ein Kommentar,
        der sich über mehrere Zeilen erstreckt.
    
        Das ist praktisch, wenn man längere Erklärungen
        im Code unterbringen möchte, oder wenn man
        einen längeren Abschnitt Code vorübergehend deaktivieren will.
    */

    [Test]
    public void CodeKannKommentareEnthalten()
    {
        // Dies ist ein einzeiliger Kommentar. Man verwendet ihn um den nächsten Codeabschnitt zu erklären.
        Console.WriteLine("Hallo Welt!");

        // Die folgende Zeile sorgt dafür, dass der Test immer erfolgreich ist.
        Assert.Pass();
    }

    [Test]
    public void DieserTestSchlägtFehl()
    {
        // Die folgende Zeile sorgt dafür, dass der Test immer fehlschlägt.
        Assert.Pass();
    }

    // Der folgende Test-Code ist deaktiviert, indem er zum Kommentar gemacht wurde.
    // Schau, was passiert, wenn du die Kommentarzeichen am Anfang und Ende entfernst.

    
    [Test]
    public void DieserTestKompiliertNicht()
    {
        Console.WriteLine("Tschüss Welt!");
        
    }
    
}