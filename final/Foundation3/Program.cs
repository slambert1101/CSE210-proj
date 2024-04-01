using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("123 Maple st", "Rexburg", "Id");
        Lecture lecture = new Lecture("Devotional", "Listen to an uplifting message", "04/02", "11:30am", address1, "John Doe", 80000);
        lecture.StandardDetails();
        lecture.FullDetails();
        lecture.ShortDescription();

        Console.WriteLine("----------------");
        Address address2 = new Address("999 West 999 South", "Richmond", "VA");
        Reception reception = new Reception("Bob and Jane's wedding reception", "Please join us for dancing and refreshments", "01/01", "3:00pm", address2, "janesemail@email.com");
        reception.StandardDetails();
        reception.FullDetails();
        reception.ShortDescription();

        Console.WriteLine("----------------");
        Address address3 = new Address("45 Drymill rd", "St George", "UT");
        OutdoorEvent outdoorEvent = new OutdoorEvent("Picnic", "Games, barbecue, and fireworks", "07/04", "5:30pm", address3, "Sunny");
        outdoorEvent.StandardDetails();
        outdoorEvent.FullDetails();
        outdoorEvent.ShortDescription();
    }
}