using System;

public delegate void ContentPublishedHandler(string title);

public class Website
{
    public event ContentPublishedHandler? OnContentPublished;

    public void PublishedContent(string title)
    {
        OnContentPublished?.Invoke(title);
    }
}

public class Subscriber
{
    public string Name { get; }

    public Subscriber(string name)
    {
        Name = name;
    }

    public void Notify(string title)
    {
        Console.WriteLine($"{Name} received notification: New content published - {title}");
    }
}

public static class Program
{
    public static void Main()
    {
        var website = new Website();

        var subscriber1 = new Subscriber("Bishal");
        var subscriber2 = new Subscriber("Roshni");
        var subscriber3 = new Subscriber("Shyam");

        website.OnContentPublished += subscriber1.Notify;
        website.OnContentPublished += subscriber2.Notify;
        website.OnContentPublished += subscriber3.Notify;

        website.PublishedContent("C# Event Basics");
        website.PublishedContent("Website Notification Demo");
    }
} 