namespace SimpleClassProject.Features;

public static class Teammate2Feature
{
    public static void Run()
    {
        Console.Write("Enter a word or phrase: ");
        string? input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("You didn't type anything.");
            return;
        }

        // Keep only letters and digits, and ignore upper/lower case
        string cleaned = new string(input.Where(char.IsLetterOrDigit).ToArray()).ToLower();
        string reversed = new string(cleaned.Reverse().ToArray());

        if (cleaned == reversed)
        {
            Console.WriteLine($"\"{input}\" is a palindrome!");
        }
        else
        {
            Console.WriteLine($"\"{input}\" is not a palindrome.");
        }
    }
}
