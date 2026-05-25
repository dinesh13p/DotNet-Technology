using System;

public delegate void MessageHandler();

public static class Program
{
    public static void ShowWelcome()
    {
        Console.WriteLine("Welcome!");
    }

    public static void ShowGoodbye()
    {
        Console.WriteLine("Goodbye!");
    }

    public static void Main()
    {
        // Single-cast delegate
        Console.WriteLine("Single-cast Delegate");
        MessageHandler? handler = ShowWelcome;
        handler?.Invoke();

        // Multi-cast delegate
        Console.WriteLine("Multi-cast Delegate");
        handler += ShowGoodbye;
        handler?.Invoke();

        // Remove a method
        Console.WriteLine("After Removing ShowWelcome");
        handler -= ShowWelcome;
        handler?.Invoke();
    }
}