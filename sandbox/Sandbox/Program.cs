using System;

class Program
{
    static void Main(string[] args)
    {
        BaldEagle joey = new BaldEagle("Joey", "Scree!");
        BaldEagle bob = new BaldEagle("Bob", "Rawr!");
        joey.MakeSound();
        bob.MakeSound();


    }
}