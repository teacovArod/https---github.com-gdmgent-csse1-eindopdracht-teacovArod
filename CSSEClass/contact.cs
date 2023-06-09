/*
30. Contacten
Voorzie de nodige klassen voor het opslaan van Contacten (naam, voornaam, adres, telefoonnummers, e-mailadressen, website,...).
Adres en Telefoonnummer is een aparte klasse.

Je kan via de applicatie contacten toevoegen, uitlezen, aanpassen en verwijderen

Elk contact ga je wegschrijven naar een tekstbestand, gebruik van "txt" is hierbij voldoende.
Bij het opstarten van het programma ga je alle files inlezen (GetFiles kan hierbij helpen) en opslaan in datacollectie.
Je kan items in de datacollectie aanpassen door een zoekactie uit te voeren.
*/

using System.Text;

public class Contact : ILogging
{

    /*
    Voorzie de velden die nodig zijn voor het bewaren van de gegevens van een contact.
    Gegevens:
     - Naam
     - Voornaam
     - Adres
     - Telefoonnummers
     - E-mailadressen
     - Website
    */

    private string naam;
    private string voornaam;
    
    private Adres adres;
    private List<Telefoonnummer> telefoonnummers;
    private string[] emailadressen;

    private string website;

    // Properties
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    /*
        Voorzie hier de properties die nodig zijn voor de verschillende velden van een contact.
    */
    // Property Naam van het type string voor het opvullen en opvragen van het veld naam, ook van het type string.
    public string Naam
    {
        get{ return this.naam; }
        set{ this.naam = value; }
    }
    // Property Voornaam van het type string voor het opvullen en opvragen van het veld voornaam, ook van het type string.
    public string Voornaam
    {
        get{ return this.voornaam; }
        set{ this.voornaam = value; }
    }

    // Property nog voorzien voor Adres...

    // Property Telefoonnummers van het type List van Telefoonnummer voor het opvullen en opvragen van het veld telefoonnummers, ook van het type List met objecten van het type Telefoonnummer
    public List<Telefoonnummer> Telefoonnummers
    {
        get{ return this.telefoonnummers; }
        set{ this.telefoonnummers = value; }
    }
    // Property nog voorzien voor Emailadressen...

    // Property Website van het type string voor het opvullen en opvragen van het veld website, ook van het type string.
    public string Website
    {
        get{ return this.website; }
        set{ this.website = value; }
    }

    // Constructor
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    // Hierbij de default constructor voor het aanmaken van een object Contact.
    public Contact()
    {}

    // Hierbij de constructor waar we alle waarden gaan meegeven die nodig zijn voor de velden/properties van een object Adres.
    public Contact(string n, string fn, Adres a, string[] emails, List<Telefoonnummer> t, string w)
    {
        this.Naam = n;
        this.Voornaam = fn;
        // Voorzie het nodige voor het adres...
        // Voorzie het nodige voor de e-mailadressen...
        this.Telefoonnummers = t;
        this.Website = w;
    }

    // Methods
    // =-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=--=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    // DumpContent is de functie die we gaan gebruiken voor het teruggeven van een string waarin alle inhoud zit, met de 
    // waarde van de verschillende properties, deze functie kan je dan gebruiken om de gegevens weg te schrijven naar een 
    // tekstbestand.
    public string DumpContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Naam: " + this.Naam + "\n");
        sb.Append("Voornaam: " + this.Voornaam + "\n");
        // Voorzie ook het nodige voor de andere velden...
        // Adres...
        // E-mailadressen...
        foreach (Telefoonnummer item in this.Telefoonnummers)
        {
            sb.Append("Telefoonnummer; Type: " + item.Type + "; Nummer: " + "voorzie hier het nummer nog!!!" + "\n");
        }
        sb.Append("Website: " + this.Website + "\n");
        LogOutput(sb.ToString());
        return sb.ToString();
    }

    public void WriteContact()
    {
        // Wegschrijven naar een txt (tekstbestand van het type txt).
        // Hierbij de variabele voor het huidige pad aan te roepen aangevuld met daarbij Contacts, zodat de txt's allemaal in een aparte map Contacts komen te staan.
        string docPath = Directory.GetCurrentDirectory() + "\\Contacts";
            // Wegschrijven van de string array naar de nieuwe file met de naam van het contact.
        using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, this.Naam + "_" + this.Voornaam + ".txt")))
        {
            outputFile.Write(DumpContent());
            LogOutput("DumpContent of contact to TXT file completed!");
        }
    }

    // LogOutput is de implementatie van de interface ILogging, deze methode gaan we gebruiken voor output 
    // weg te schrijven naar de console.
    public void LogOutput(string message)
    {
        Console.WriteLine(message);
    }
}
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

public interface ILogging
{
    void LogOutput(string message);
}

public class Adres
{
    // Voeg de velden toe die nodig zijn voor het bewaren van adresgegevens.
    private string straat;
    private string stad;
    private string postcode;

    // Voeg de properties toe voor het opvragen en instellen van adresgegevens.
    public string Straat
    {
        get { return straat; }
        set { straat = value; }
    }

    public string Stad
    {
        get { return stad; }
        set { stad = value; }
    }

    public string Postcode
    {
        get { return postcode; }
        set { postcode = value; }
    }

    // Voeg een constructor toe om een nieuw adresobject te maken met de opgegeven gegevens.
    public Adres(string straat, string stad, string postcode)
    {
        this.straat = straat;
        this.stad = stad;
        this.postcode = postcode;
    }
}

public class Telefoonnummer
{
    // Voeg de velden toe die nodig zijn voor het bewaren van telefoonnummergegevens.
    private string type;
    private string nummer;

    // Voeg de properties toe voor het opvragen en instellen van telefoonnummergegevens.
    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public string Nummer
    {
        get { return nummer; }
        set { nummer = value; }
    }

    // Voeg een constructor toe om een nieuw telefoonnummerobject te maken met de opgegeven gegevens.
    public Telefoonnummer(string type, string nummer)
    {
        this.type = type;
        this.nummer = nummer;
    }
}

public class Contact : ILogging
{
    // Voeg de velden toe die nodig zijn voor het bewaren van contactgegevens.
    private string naam;
    private string voornaam;
    private Adres adres;
    private List<Telefoonnummer> telefoonnummers;
    private string[] emailadressen;
    private string website;

    // Voeg de properties toe voor het opvragen en instellen van contactgegevens.
    public string Naam
    {
        get { return naam; }
        set { naam = value; }
    }

    public string Voornaam
    {
        get { return voornaam; }
        set { voornaam = value; }
    }

    public Adres Adres
    {
        get { return adres; }
        set { adres = value; }
    }

    public List<Telefoonnummer> Telefoonnummers
    {
        get { return telefoonnummers; }
        set { telefoonnummers = value; }
    }

    public string[] Emailadressen
    {
        get { return emailadressen; }
        set { emailadressen = value; }
    }

    public string Website
    {
        get { return website; }
        set { website = value; }
    }

    // Voeg een constructor toe om een nieuw contactobject te maken met de opgegeven gegevens.
    public Contact(string naam, string voornaam, Adres adres, string[] emailadressen, List<Telefoonnummer> telefoonnummers, string website)
    {
        this.naam = naam;
        this.voornaam = voornaam;
        this.adres = adres;
        this.emailadressen = emailadressen;
        this.telefoonnummers = telefoonnummers;
        this.website = website;
    }

    // Implementeer de DumpContent-methode om de contactgegevens naar een string te converteren.
    public string DumpContent()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Naam: " + naam + "\n");
        sb.Append("Voornaam: " + voornaam + "\n");
        sb.Append("Adres: " + adres.Straat + " " + adres.Stad + " " + adres.Postcode + "\n");
        sb.Append("Telefoonnummers:\n");
        foreach (Telefoonnummer telefoonnummer in telefoonnummers)
        {
            sb.Append("- Type: " + telefoonnummer.Type + ", Nummer: " + telefoonnummer.Nummer + "\n");
        }
        sb.Append("E-mailadressen:\n");
        foreach (string emailadres in emailadressen)
        {
            sb.Append("- " + emailadres + "\n");
        }
        sb.Append("Website: " + website + "\n");
        return sb.ToString();
    }

    // Implementeer de WriteContact-methode om de contactgegevens naar een tekstbestand weg te schrijven.
    public void WriteContact()
    {
        string docPath = Directory.GetCurrentDirectory() + "\\Contacts";
        Directory.CreateDirectory(docPath); // Maak de map "Contacts" aan als deze nog niet bestaat.
        string fileName = Path.Combine(docPath, naam + "_" + voornaam + ".txt");
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.Write(DumpContent());
            LogOutput("Contactgegevens succesvol weggeschreven naar het bestand: " + fileName);
        }
    }

    // Implementeer de LogOutput-methode van de ILogging-interface om uitvoer naar de console te schrijven.
    public void LogOutput(string message)
    {
        Console.WriteLine(message);
    }
}
