namespace CSSEClass;

public class Mathoperations
{
    public static void Test()
    {
        Console.WriteLine("Test");
    }
}

public static void MultiplicationTable(int x, bool generateAll, bool outputTxt)
{
    StringBuilder sb = New StringBuilder();
      
    // genereer specifieke tafel van x
     for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine(i +" x "+ x +" = " + x*i);
    }


    // genereer de tafel van 1 => 10
    Console.WriteLine("--------- Tafels van 1 tot 10! -------------");
        for (int j = 1; j <= 10; j++)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(j +" x "+i+" = " + j*i);
            }
        }
    // wegschrijven
    Console.WriteLine(sb.Tostring());
}
/*
using System;
using System.IO;

public class MathOperations
{
    public void MultiplicationTable(int x, int maxMultiplier = 10)
    {
        for (int i = 0; i <= maxMultiplier; i++)
        {
            int result = x * i;
            Console.WriteLine($"{x} x {i} = {result}");
        }
    }

    public int Sum(int a, int b)
    {
        return a + b;
    }

    public int Subtraction(int a, int b)
    {
        return a - b;
    }

    public int Division(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Divisor cannot be zero.");
        }
        return a / b;
    }

    public int Multiplication(int a, int b)
    {
        return a * b;
    }

    public int Modulo(int a, int b)
    {
        if (b == 0)
        {
            throw new ArgumentException("Divisor cannot be zero.");
        }
        return a % b;
    }

    public double Exponentiation(double a, double b)
    {
        return Math.Pow(a, b);
    }

    public double AreaTriangle(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }

    public double AreaRectangle(double length, double width)
    {
        return length * width;
    }

    public double AreaSquare(double sideLength)
    {
        return sideLength * sideLength;
    }

    public double AreaParallellogram(double baseLength, double height)
    {
        return baseLength * height;
    }

    public double AreaRhombus(double diagonal1, double diagonal2)
    {
        return (diagonal1 * diagonal2) / 2;
    }

    public double AreaTrapezium(double topLength, double bottomLength, double height)
    {
        return 0.5 * (topLength + bottomLength) * height;
    }

    public double AreaCircle(double radius)
    {
        return Math.PI * radius * radius;
    }

    public double PerimeterTriangle(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }

    public double PerimeterRectangle(double length, double width)
    {
        return 2 * (length + width);
    }

    public double PerimeterSquare(double sideLength)
    {
        return 4 * sideLength;
    }

    public double PerimeterParallellogram(double side1, double side2)
    {
        return 2 * (side1 + side2);
    }

    public double PerimeterRhombus(double sideLength)
    {
        return 4 * sideLength;
    }

    public double PerimeterTrapezium(double side1, double side2, double side3, double side4)
    {
        return side1 + side2 + side3 + side4;
    }

    public double PerimeterCircle(double radius)
    {
        return 2 * Math.PI * radius;
    }

    // Add other methods for volume calculations here
}

public class Generator
{
    private Random random;

    public Generator()
    {
        random = new Random();
    }

    public int RandomNumber(int start = 0, int end = int.MaxValue)
    {
        return random.Next(start, end + 1);
    }

    public int[] RandomNumbers(int count, int start = 0, int end = int.MaxValue)
    {
        int[] numbers = new int[count];
        for (int i = 0; i < count; i++)
        {
            numbers[i] = RandomNumber(start, end);
        }
        return numbers;
    }

    public char RandomChar(char start = 'a', char end = 'z')
    {
        int startInt = Convert.ToInt32(start);
        int endInt = Convert.ToInt32(end);
        int randomInt = random.Next(startInt, endInt + 1);
        return Convert.ToChar(randomInt);
    }

    public string RandomChars(int count, char start = 'a', char end = 'z')
    {
        string chars = "";
        for (int i = 0; i < count; i++)
        {
            chars += RandomChar(start, end);
        }
        return chars;
    }

    public string PasswordGenerator(int length, bool includeLowercase = true, bool includeUppercase = true, bool includeDigits = true, bool includeSymbols = false)
    {
        string lowercaseChars = "abcdefghijklmnopqrstuvwxyz";
        string uppercaseChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string digitChars = "0123456789";
        string symbolChars = "!@#$%^&*()_-+=<>?";

        string validChars = "";
        if (includeLowercase)
            validChars += lowercaseChars;
        if (includeUppercase)
            validChars += uppercaseChars;
        if (includeDigits)
            validChars += digitChars;
        if (includeSymbols)
            validChars += symbolChars;

        if (validChars == "")
            throw new ArgumentException("At least one character type must be included.");

        string password = "";
        for (int i = 0; i < length; i++)
        {
            int randomIndex = random.Next(0, validChars.Length);
            password += validChars[randomIndex];
        }

        return password;
    }
}

public class Contact
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Phone Number: {PhoneNumber}";
    }
}

public class ContactList
{
    private List<Contact> contacts;

    public ContactList()
    {
        contacts = new List<Contact>();
    }

    public void AddContact(string name, string phoneNumber)
    {
        Contact contact = new Contact { Name = name, PhoneNumber = phoneNumber };
        contacts.Add(contact);
    }

    public List<Contact> GetContacts()
    {
        return contacts;
    }

    public void SaveContacts(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Contact contact in contacts)
            {
                writer.WriteLine($"{contact.Name},{contact.PhoneNumber}");
            }
        }
    }

    public void LoadContacts(string filePath)
    {
        contacts.Clear();
        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length == 2)
                {
                    string name = parts[0];
                    string phoneNumber = parts[1];
                    AddContact(name, phoneNumber);
                }
            }
        }
    }
}

public class Program
{
    public static void Main()
    {
        // Voorbeeldgebruik van de MathOperations class
        MathOperations mathOperations = new MathOperations();
        mathOperations.MultiplicationTable(5);
        int sum = mathOperations.Sum(2, 3);
        Console.WriteLine($"Sum: {sum}");
        int difference = mathOperations.Subtraction(5, 2);
        Console.WriteLine($"Difference: {difference}");
        int division = mathOperations.Division(10, 2);
        Console.WriteLine($"Division: {division}");
        int multiplication = mathOperations.Multiplication(4, 3);
        Console.WriteLine($"Multiplication: {multiplication}");
        int modulo = mathOperations.Modulo(7, 3);
        Console.WriteLine($"Modulo: {modulo}");
        double exponentiation = mathOperations.Exponentiation(2, 3);
        Console.WriteLine($"Exponentiation: {exponentiation}");

        // Voorbeeldgebruik van de Generator class
        Generator generator = new Generator();
        int randomNumber = generator.RandomNumber(1, 10);
        Console.WriteLine($"Random number: {randomNumber}");
        int[] randomNumbers = generator.RandomNumbers(5, 1, 10);
        Console.WriteLine("Random numbers:");
        foreach (int num in randomNumbers)
        {
            Console.WriteLine(num);
        }
        char randomChar = generator.RandomChar('a', 'z');
        Console.WriteLine($"Random char: {randomChar}");
        string randomChars = generator.RandomChars(5, 'a', 'z');
        Console.WriteLine($"Random chars: {randomChars}");
        string password = generator.PasswordGenerator(8, includeLowercase: true, includeUppercase: true, includeDigits: true);
        Console.WriteLine($"Password: {password}");

        // Voorbeeldgebruik van de ContactList class
        ContactList contactList = new ContactList();
        contactList.AddContact("John Doe", "1234567890");
        contactList.AddContact("Jane Smith", "0987654321");
        List<Contact> contacts = contactList.GetContacts();
        Console.WriteLine("Contacts:");
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact);
        }
        contactList.SaveContacts("contacts.txt");
        contactList.LoadContacts("contacts.txt");
        contacts = contactList.GetContacts();
        Console.WriteLine("Loaded contacts:");
        foreach (Contact contact in contacts)
        {
            Console.WriteLine(contact);
        }
    }
}

using System;

public class MathOperations
{
    public static void GenerateMultiplicationTable(int x, int start, int end)
    {
        for (int i = start; i <= end; i++)
        {
            int result = x * i;
            Console.WriteLine($"{x} * {i} = {result}");
        }
    }

    public static void GenerateAllMultiplicationTables(int start, int end)
    {
        for (int i = 1; i <= 10; i++)
        {
            GenerateMultiplicationTable(i, start, end);
            Console.WriteLine();
        }
    }
}

public class MathOperations
{
    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

public class MathOperations
{
    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class MathOperations
{
    public static int Divide(int a, int b)
    {
        if (b != 0)
        {
            return a / b;
        }
        else
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}

public class MathOperations
{
    public static int Multiply(int a, int b)
    {
        return a * b;
    }
}

public class MathOperations
{
    public static int Modulo(int a, int b)
    {
        if (b != 0)
        {
            return a % b;
        }
        else
        {
            throw new DivideByZeroException("Cannot divide by zero.");
        }
    }
}

public class MathOperations
{
    public static int Exponentiate(int a, int b)
    {
        return (int)Math.Pow(a, b);
    }
}


public class MathOperations
{
    public static double CalculateTriangleArea(double baseLength, double height)
    {
        return 0.5 * baseLength * height;
    }
}

public class MathOperations
{
    public static double CalculateRectangleArea(double length, double width)
    {
        return length * width;
    }
}


public class MathOperations
{
    public static double CalculateSquareArea(double sideLength)
    {
        return sideLength * sideLength;
    }
}

public class MathOperations
{
    public static double CalculateParallellogramArea(double baseLength, double height)
    {
        return baseLength * height;
    }
}

public class MathOperations
{
    public static double CalculateRhombusArea(double diagonal1, double diagonal2)
    {
        return 0.5 * diagonal1 * diagonal2;
    }
}

public class MathOperations
{
    public static double CalculateTrapeziumArea(double base1, double base2, double height)
    {
        return 0.5 * (base1 + base2) * height;
    }
}

public class MathOperations
{
    public static double CalculateCircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }
}

public class MathOperations
{
    public static double CalculateTrianglePerimeter(double side1, double side2, double side3)
    {
        return side1 + side2 + side3;
    }
}

public class MathOperations
{
    public static double CalculateRectanglePerimeter(double length, double width)
    {
        return 2 * (length + width);
    }
}

public class MathOperations
{
    public static double CalculateSquarePerimeter(double sideLength)
    {
        return 4 * sideLength;
    }
}

public class MathOperations
{
    public static double CalculateParallellogramPerimeter(double side1, double side2)
    {
        return 2 * (side1 + side2);
    }
}

public class MathOperations
{
    public static double CalculateRhombusPerimeter(double sideLength)
    {
        return 4 * sideLength;
    }
}

public class MathOperations
{
    public static double CalculateTrapeziumPerimeter(double base1, double base2, double side1, double side2)
    {
        return base1 + base2 + side1 + side2;
    }
}

public class MathOperations
{
    public static double CalculateCirclePerimeter(double radius)
    {
        return 2 * Math.PI * radius;
    }
}

public class MathOperations
{
    public static double CalculateCubeVolume(double sideLength)
    {
        return sideLength * sideLength * sideLength;
    }
}

public class MathOperations
{
    public static double CalculateCylinderVolume(double radius, double height)
    {
        return Math.PI * radius * radius * height;
    }
}

using System;

public class Generator
{
    private static Random random = new Random();

    public static int GenerateRandomNumber()
    {
        return random.Next();
    }

    public static int GenerateRandomNumber(int min, int max)
    {
        return random.Next(min, max);
    }

    public static int GenerateRandomNumber(int max)
    {
        return random.Next(max);
    }

    public static char GenerateRandomChar()
    {
        int num = random.Next(26);
        char c = (char)('a' + num);
        return c;
    }
}

using System;

public class Generator
{
    private static Random random = new Random();

    public static int[] GenerateRandomNumbers(int count)
    {
        int[] numbers = new int[count];
        for (int i = 0; i < count; i)

        {
            numbers[i] = random.Next();
        }
        return numbers;
    }
} */





