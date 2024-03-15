using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Game game = new Game();
        
        
        while(game.GetChoice() != 7)
        {
            game.Menu();
            
            if(game.GetChoice() == 7)
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


            if(game.GetChoice() == 5)
            {
                game.RecordEvent();
            }
           
        }

    }
}