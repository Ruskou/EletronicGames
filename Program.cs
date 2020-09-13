using System;
using Games.Model;
using Games.Model.Base;

namespace Games
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
        Console.WriteLine("Choose the game you want: ");
        string choosenGame = Console.ReadLine();

        EletronicGames eletronicgames = null;
        if (choosenGame == "Fifa")
        eletronicgames = new Fifa();
        
        eletronicgames.Name = "Fifa";
        eletronicgames.Type = "Soccer";
        eletronicgames.ParentalRating = 12;
        eletronicgames.Memory = 10;
        eletronicgames.Objective = "Win";
                
        
        eletronicgames.Created();
        eletronicgames.Acquired();
        eletronicgames.Started();
        eletronicgames.Played();
        eletronicgames.TurnedOff();
       
            }

            catch(Exception)
            {
                Console.WriteLine("There is no game!");

                throw;
            }
        }
    }
    }

