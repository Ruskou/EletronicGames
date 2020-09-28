using System;


namespace Games.Model.Base {

    //Geralmente a gente não nomeia no plural essas classes que representam objetos. 
    //Sendo ssim, acho que ficaria melhor chamar essa classe de "EletronicGame". 
    public abstract class EletronicGames {

        #region Properties

        public string Name {get;set; } // Name of game
        public string Type {get; set; } // Type of game
        public int ParentalRating {get; set; } // Parental Rating of game
        public int Memory {get; set; } // Size occupied in memory
        public string Objective {get; set; } // Objective of game

        #endregion


        #region Behaviors

        //Lembra que métodos costumam ser nomeados no infinitivo. Portanto, esse método seria 
        //Create, o outro Acquire, o outro Start, e assim por diante.
        public void Created(){    
        Console.WriteLine($"The game {Name} of type {Type} is created with {Memory} Gigs!");  // The game name, type and memory
        } 
        public void Acquired(){  
        Console.WriteLine($"The {Name} game indicative rating of {ParentalRating} with is acquired for client!");  // The game is acquired for client with Parental Rating
        }
        public void Started(){    
        Console.WriteLine($"The game {Name} Started with the aim of {Objective}!");  // The game Started with objective
        }

        /**Muita atenção na indentação, sem ela seu código fica pouco legível. Esse método, por exemplo, ficaria:
        public void Played()
        {     
            Console.WriteLine($"The game {Name} is played by someone!");
        }

        Isso se aplica aos demais métodos e a boa parte do código.
        **/

        public void Played(){     // The game is played by someone
        Console.WriteLine($"The game {Name} is played by someone!");
        }
        
        public void TurnedOff(){
        Console.WriteLine($"After playing according to the rules of the game it is turned off. "); 
        }
         
        
        #endregion
    }
}

