using SimpleClassProject.Features;

// Simple console menu. Each feature lives in its own file in /Features
// so teammates can add features without editing the same lines (fewer merge conflicts).

bool running = true;

while (running)
{
    Console.WriteLine();
    Console.WriteLine("=== Simple Class Project ===");
    Console.WriteLine("1. Greeter");
    Console.WriteLine("2. Calculator");
    Console.WriteLine("3. Teammate 1 feature (TODO)");
    Console.WriteLine("4. Teammate 2 feature (TODO)");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");

    string? choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Greeter.Run();
            break;
        case "2":
            Calculator.Run();
            break;
        case "3":
            Teammate1Feature.Run();
            break;
        case "4":
            Teammate2Feature.Run();
            break;
        case "0":
            running = false;
            break;
        default:
            Console.WriteLine("Invalid option, try again.");
            break;
    }
}

Console.WriteLine("Goodbye!");
