using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        
        
        while(game.GetChoice() != 6)
        {
            game.Menu();
            
            if(game.GetChoice() == 6)
            {
                break;
            }
            if(game.GetChoice() == 1)
            {
                game.AddGoal();
            }
            if(game.GetChoice() ==2)
            {
                game.DisplayAllGoals();
            }
            if(game.GetChoice() ==3)
            {
                game.SaveFile();
            }
            if(game.GetChoice() ==4)
            {
                game.LoadFile();
            }

            if(game.GetChoice() == 5)
            {
                game.RecordEvent();
            }
            else
            {
                Console.WriteLine("Please input valid option.");
            }
           
        }

    }
}