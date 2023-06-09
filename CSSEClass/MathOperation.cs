
using System.Text;

namespace CSSEClass;
public class MathOperations
{
    const double PI = 3.1459;
    public static void Test()
    {
        LogOutput("Test!");
    }


    /*
    Tafel van x (0 -> X); Multiplication table
    Som (+) ==> Sum
    Verschil (-) ==> Substraction
    Quotiënt (/) ==> Division
    Product (*) ==> Multiplication
    Restdeling (%) ==> Modulo
    Machtsverheffing (Math.Pow) ==> Exponentiation
    Oppervlakteberekening (referentie: https://thirdspacelearning.com/gcse-maths/geometry-and-measure/area/Links to an external site.) :
    Driehoek ==> Area Triangle
    Rechthoek ==> Area Rectangle
    Vierkant ==> Area Square
    Parallellogram ==> Area Parallellogram
    Ruit ==> Area Rhombus
    Trapezium ==> Area Trapezium
    Cirkel ==> Area Circle
    Omtrekberekening:
    Driehoek ==> Perimeter Triangle
    Rechthoek ==> Perimeter Rectangle
    Vierkant ==> Perimeter Square
    Parallellogram ==> Perimeter Parallellogram
    Ruit ==> Perimeter Rhombus
    Trapezium ==> Perimeter Trapezium
    Cirkel ==> Perimeter Circle
    Volumeberekening:
    
    Kubus ==> Volume Cube (referentie: https://www.cuemath.com/measurement/volume-of-cube/Links to an external site.)
    Cilinder ==> Volume Cylinder (referentie: https://www.omnicalculator.com/math/cylinder-volume#:~:text=Find%20the%20volume%20of%20the,2(h%2Br)Links to an external site..) 
    */

    public static void MultiplicationTable(int x, bool generateAll, bool outputTxt)
    {
        StringBuilder sb = new StringBuilder();
        // Genereer specifieke tafel van x
        sb.Append("--------- Tafels van x -------------\n");
        for (int i = 0; i <= 10; i++)
        {
            sb.Append(i + " x " + x + " = " + i*x);
        }

        if(generateAll)
        {
            // Genereer de tafels van 1 -> 10
            sb.Append("--------- Tafels van 1 tot 10! -------------");
            for (int j = 1; j <= 10; j++)
            {
                for (int i = 0; i <= 10; i++)
                {
                    sb.Append(j + " x " + i + " = " + j*i);
                }
            }
        }

        // Wegschrijven...
        if(outputTxt)
        {
            // Wegschrijven naar een txt (tekstbestand van het type txt).
            // Set a variable to the Documents path.
            string txtPath = Directory.GetCurrentDirectory();

            // Write the string array to a new file named "outputMultiplicationTable.txt".
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(txtPath, "outputMultiplicationTable.txt")))
            {
                outputFile.Write(sb.ToString());
                LogOutput("Output to TXT completed!");
            }
        }
        else
        {
            LogOutput(sb.ToString());
        }
    }

    public static double Sum(double p1, double p2)
    {
        return p1 + p2;
    }

    public static double Substraction(double p1, double p2)
    {
        return p1 - p2;
    }

    // Het nodige nog voorzien voor Division
    // Het nodige nog voorzien voor Multiplication
    // Het nodige nog voorzien voor Modulo
    
    // Functie Exponentiation voor het verheffen tot een macht
    public static double Exponentiation(double a, double b)
    {
        return Math.Pow(a, b);
    }
    
    // Het nodige nog voorzien voor AreaTriangle
    // Het nodige nog voorzien voor AreaRectangle
    // Het nodige nog voorzien voor AreaSquare
    // Het nodige nog voorzien voor AreaParallellogram
    // Het nodige nog voorzien voor AreaRhombus
    public class Ruit
{
    public double BerekenOppervlakte(double diagonaal1, double diagonaal2)
    {
        double oppervlakte = (diagonaal1 * diagonaal2) / 2;
        return oppervlakte;
    }

    Ruit mijnRuit = new Ruit();
    double diagonaal1 = 6.0;
    double diagonaal2 = 8.0;
    double oppervlakte = mijnRuit.BerekenOppervlakte(diagonaal1, diagonaal2);
    Console.WriteLine("De oppervlakte van de ruit is: " + oppervlakte);

    }

    // Het nodige nog voorzien voor AreaTrapezium

    // Functie AreaCircle voor het berekenen van de oppervlakte van een cirkel.
    public static double AreaCircle(double r)
    {
        LogOutput("Math.Pow: " + r + "^2: " + Math.Pow(r, 2.0));
        return PI*Math.Pow(r, 2.0);
    }

    // Het nodige nog voorzien voor PerimeterTriangle

    // Het nodige nog voorzien voor PerimeterRectangle
    // Het nodige nog voorzien voor PerimeterSquare
    // Het nodige nog voorzien voor PerimeterParallellogram
    // Het nodige nog voorzien voor PerimeterRhombus
    // Het nodige nog voorzien voor PerimeterTrapezium
    public class Trapezium
{
    public double BerekenOppervlakte(double basis1, double basis2, double hoogte)
    {
        double oppervlakte = (basis1 + basis2) * hoogte / 2;
        return oppervlakte;
    }
    Trapezium mijnTrapezium = new Trapezium();
    double basis1 = 5.0;
    double basis2 = 7.0;
    double hoogte = 4.0;
    double oppervlakte = mijnTrapezium.BerekenOppervlakte(basis1, basis2, hoogte);
    Console.WriteLine("De oppervlakte van het trapezium is: " + oppervlakte);

}

    // Het nodige nog voorzien voor PerimeterCircle
        public class Cirkel
    {
        public double BerekenOppervlakte(double straal)
        {
            double oppervlakte = Math.PI * Math.Pow(straal, 2);
            return oppervlakte;
        }
    }

    Cirkel mijnCirkel = new Cirkel();
    double straal = 3.0;
    double oppervlakte = mijnCirkel.BerekenOppervlakte(straal);
    Console.WriteLine("De oppervlakte van de cirkel is: " + oppervlakte);

    // Het nodige nog voorzien voor VolumeCube
    // Het nodige nog voorzien voor VolumeCylinder


    // LogOutput, deze methode gaan we gebruiken voor output weg te schrijven naar de console.
    public static void LogOutput(string message)
    {
        Console.WriteLine(message);
    }
}
