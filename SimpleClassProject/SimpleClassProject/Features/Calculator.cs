namespace SimpleClassProject.Features;

public static class Calculator
{
    public static void Run()
    {
        Console.Write("Enter first number: ");
        if (!double.TryParse(Console.ReadLine(), out double a))
        {
            Console.WriteLine("That's not a valid number.");
            return;
        }

        Console.Write("Enter second number: ");
        if (!double.TryParse(Console.ReadLine(), out double b))
        {
            Console.WriteLine("That's not a valid number.");
            return;
        }

        Console.WriteLine($"{a} + {b} = {Add(a, b)}");
    }

    public static double Add(double a, double b) => a + b;
}
