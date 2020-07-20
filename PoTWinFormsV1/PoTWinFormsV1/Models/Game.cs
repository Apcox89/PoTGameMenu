using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoTWinFormsV1.Models
{
    public class Game
    {
        public bool Inplay { get; set; }
        public bool ResetScene { get; set; }
        public String SaveGame { get; set; }
        public String LoadGame { get; set; }

        public void getStatus()
        {
            //relay String(s) for Save/Load game to int
            //expliciit conversion to an array of saved data 
            //array allows multiple values to be stored.
            //foreach loop with a file/script call?
            if (Inplay == false && ResetScene == true)
            {
                Console.WriteLine("Load from most recent Save? Y/N");
                if (LoadGame == "Y")
                {
                    Console.WriteLine("Return Load Game Status");
                    //void method maybe change to int
                    // status ints (like server status)
                        // 1 - SaveGame
                        // 2 - LoadGame
                        // 3 - Reset lvl?
                        // 4 - Exit to Main Menu
                }

            }
            
        }

        public class SceneInteract : Game
        {
            public Game ActiveStatus; 
            //Game object to interact through scene-status

            public bool Live { get; set; }
            public int Health { get; set; }
            //Time marker for runtime/debugging
            public DateTime CurrentRun { get; set; }
        }

        //to act as Game-obect interaction
        // and also to inherit through Player
        // then from  Character class

        //test to see which method of class-hierarchy
        // works better for a pseudo-game object
        // like a button that has an output. 

        //potentially game is interface class between character/player

        //Player stats need to function with methods in the 'Character' class first
        //then code an interface to go with the Game Model Class
    }
}
