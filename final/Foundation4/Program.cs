using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity>();
        Running running = new Running("Jan 1, 2024", 30, 3);
        activities.Add(running);
        Cycling cycling = new Cycling("Jan 2, 2024", 73, 33);
        activities.Add(cycling);
        Swimming swimming = new Swimming("Jan 3, 2024", 45, 6);
        activities.Add(swimming);

        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}