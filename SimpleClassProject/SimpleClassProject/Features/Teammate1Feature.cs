namespace SimpleClassProject.Features;

public static class Teammate1Feature
{
    public static void Run()
    {
        Random random = new Random();
        int secret = random.Next(1, 101);
        int tries = 0;

        Console.WriteLine("I'm thinking of a number between 1 and 100.");

        while (true)
        {
            Console.Write("Your guess: ");
            if (!int.TryParse(Console.ReadLine(), out int guess))
            {
                Console.WriteLine("Please enter a whole number.");
                continue;
            }

            tries++;

            if (guess < secret)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > secret)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine($"Correct! You got it in {tries} tries.");
                break;
            }
        }
    }
}
