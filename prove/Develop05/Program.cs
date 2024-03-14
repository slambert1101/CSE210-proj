using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        int option = 0;
        
        while(option != 6)
        {
            option = game.Menu();
            
            if(option == 6)
            {
                break;
            }
            if(option == 1)
            {
                game.AddGoal();
            }
            if(option ==2)
            {
                game.DisplayAllGoals();
            }
            if(option == 5)
            {
                game.RecordEvent();
            }
           
        }

    }
}