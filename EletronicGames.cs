using System;


namespace Games.Model.Base {

    public abstract class EletronicGames {

        #region Properties

        public string Name {get;set; } // Name of game
        public string Type {get; set; } // Type of game
        public int ParentalRating {get; set; } // Parental Rating of game
        public int Memory {get; set; } // Size occupied in memory
        public string Objective {get; set; } // Objective of game

        #endregion


        #region Behaviors

        public void Created(){    
        Console.WriteLine($"The game {Name} of type {Type} is created with {Memory} Gigs!");  // The game name, type and memory
        } 
        public void Acquired(){  
        Console.WriteLine($"The {Name} game indicative rating of {ParentalRating} with is acquired for client!");  // The game is acquired for client with Parental Rating
        }
        public void Started(){    
        Console.WriteLine($"The game {Name} Started with the aim of {Objective}!");  // The game Started with objective
        }

        public void Played(){     // The game is played by someone
        Console.WriteLine($"The game {Name} is played by someone!");
        }
        
        public void TurnedOff(){
        Console.WriteLine($"After playing according to the rules of the game it is turned off. "); 
        }
         
        
        #endregion



    }
}

