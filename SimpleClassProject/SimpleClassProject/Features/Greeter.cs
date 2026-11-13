namespace SimpleClassProject.Features;

public static class Greeter
{
    public static void Run()
    {
        Console.Write("What's your name? ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            name = "friend";
        }

        Console.WriteLine($"Hello, {name}! Welcome to the project.");
    }
}
