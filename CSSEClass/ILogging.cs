public interface ILogging
{
    /*
        Hierbij voorzien we een abstracte methode LogOutput die één parameter heeft van het type string.
        Wanneer men een contrcat aangaat voor de interface te implementeren dan zal je voor alle abstracte methodes ook
        een implementatie moeten voorzien in de klasse die de interface precies implementeert.
        Jullie dienen dit te voorzien in de klassen:
            - Adres
            - Contact
            - Telefoonnummer
    */
    void LogOutput(string message);
}

public class Adres : ILogging
{
    public void LogOutput(string message)
    {
        // Implementeer de logica om de 'message' naar het logbestand of andere uitvoer te schrijven voor Adres.
        Console.WriteLine("Adres: " + message);
    }
}

public class Contact : ILogging
{
    public void LogOutput(string message)
    {
        // Implementeer de logica om de 'message' naar het logbestand of andere uitvoer te schrijven voor Contact.
        Console.WriteLine("Contact: " + message);
    }
}

public class Telefoonnummer : ILogging
{
    public void LogOutput(string message)
    {
        // Implementeer de logica om de 'message' naar het logbestand of andere uitvoer te schrijven voor Telefoonnummer.
        Console.WriteLine("Telefoonnummer: " + message);
    }
}
