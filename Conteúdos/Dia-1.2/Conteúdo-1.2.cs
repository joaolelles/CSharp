// Cast Implícito
public class Program
{
    public static void Main()
    {
        int someIntNumber = 51;
        long longNumberCast = someIntNumber;

        Console.WriteLine(longNumberCast);
    }
}

// Cast Explícito
public class Program
{
    public static void Main()
    {
        long someLongNumber = 516144066604654;
        int intNumber = (int)someLongNumber;

        Console.WriteLine(intNumber);
    }
}

// utilizando o Convert
public class Program
{
    public static void Main()
    {
        long someLongNumber = 516144564564654;
        int intNumber = Convert.ToInt32(someLongNumber);
        Console.WriteLine(intNumber);
    }
}

// utilizando o TryParse
bool canConvert = Int32.TryParse(userEntry, out valueConverted)