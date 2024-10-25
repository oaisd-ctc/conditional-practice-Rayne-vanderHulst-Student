
using System.Formats.Asn1;

public class Program
{
    public static void Main(string[] args)
    {
        FahrenheitToCelsius(68); // Test FahrenheitToCelsius Function with a random value

        // Test your functions by calling them below:
        CheckForPositiveNegativeZero(-1); // This should output: "Your number is negative"
        CheckForPositiveNegativeZero(0); // This should output: "Your number is zero"
        CheckForPositiveNegativeZero(1); // This should output: "Your number is positive"
        // ...
        // ...
        // DisplayDayOfWeek(0); // This should output: "Thursday"

    }
    public static void CheckForPositiveNegativeZero(int number)
    {
        if (number < 0)
        {
            Console.WriteLine(" your number is negative");


        }
        else if (number > 0)
        {
            Console.WriteLine("Your number is positive");
        }
        else if (number == 0)
        {
            Console.WriteLine("Your number is zero");
        }

    }
    public static void FahrenheitToCelsius(double fahrenheit)
    {
        double celsiusDegree = (fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit} degrees Fahrenheit is {celsiusDegree} degrees Celsius.");
    }

    // Define your functions below:

    public static void findmInimum(int num1, int num2, int num3)
    {
        if (num1 < num2 && num1 < num3)
        { Console.WriteLine("the minimum value is " + num1); }
        else if (num2 < num1 && num2 < num3)

        { Console.WriteLine("the minimum value is" + num2); }
        else if (num3 < num2 && num3 < num1)
        { Console.WriteLine("the minimum value is" + num3); }
    }
    public static void FineMaximum(int num1, int num2, int num3)
    {
        if (num1 > num2 && num1 > num3)
        { Console.WriteLine("the maximum value is " + num1); }
        else if (num2 > num1 && num2 > num3)

        { Console.WriteLine("the maximum value is" + num2); }
        else if (num3 > num2 && num3 > num1)
        { Console.WriteLine("the maxium value is" + num3); }
    }
    public static void IsDivisibleBy5(int number)
    {
        if (number % 5 == 0)
        {
            Console.WriteLine(number + "is divisble by ");
        }
    }
    public static void CheckEvenOrOdd(int number)
    {
        if (number % 2 == 0)
        { Console.WriteLine("number is even"); }
        else
        { Console.WriteLine("number is odd"); }

    }
    public static void CheckVowelOrConsonant(char letter)
    {
        letter = 'e';
        switch (letter)
        {
            case 'a':
            case 'A':
            case 'e':
            case 'E':
            case 'o':
            case 'O':
            case 'u':
            case 'U':

                Console.WriteLine("vowel");
                break;
            default:
                Console.WriteLine("Not a vowel");
                break;
        }


    }









}
