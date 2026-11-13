# Simple Class Project

A small C# console app (.NET 8) used for a class assignment on GitHub forks.

## Run it

1. Install the [.NET 8 SDK](https://dotnet.microsoft.com/download).
2. In a terminal, from this folder:

```
dotnet run
```

## Project layout

```
Program.cs                    # menu
Features/Greeter.cs           # example feature
Features/Calculator.cs        # example feature
Features/Teammate1Feature.cs  # Teammate 1 edits this file in their fork
Features/Teammate2Feature.cs  # Teammate 2 edits this file in their fork
```

## Class instructions: forks

1. **Owner** uploads this project to a new GitHub repository.
2. **Teammate 1 and Teammate 2** each click **Fork** on the repo page.
3. Each teammate clones their own fork, e.g.
   `git clone https://github.com/<your-username>/SimpleClassProject.git`
4. Each teammate edits only their own file (`Teammate1Feature.cs` or `Teammate2Feature.cs`), then:

```
git add .
git commit -m "Add my feature"
git push
```

5. (Optional) Open a **Pull Request** from your fork back to the original repo.
