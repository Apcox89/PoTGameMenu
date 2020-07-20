using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoTWinFormsV1
{
    public class Character
    {
        //character properties:
        public string PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int XP { get; set; }
        public int points { get; set; }
        public bool Alive { get; set; }

        //default Constructor
        public Character() { }

        //non-default constructor
        public Character(string pID, string pName, int pXp, int pPts, bool pAlive)
        {
            PlayerID = pID;
            PlayerName = pName;
            XP = pXp;
            points = pPts;
            Alive = pAlive;
        }

        //method for gaining points:
        public int LvlUp()
        {
            if (points > 10)
            {
                return XP + 1;
            }

            if (points <= 10)
            {
                return XP;
            }
            else return points;

        }

        //polymorphism
        public override string ToString()
        {
            return "Id: " + PlayerID + " Name: " + PlayerName + " Xp: " + XP + " Points: " + points +
                        " Status: " + Alive;
        }

        public class Player : Character
        {

            //main protagonist object: 
            public Character BillGnant;           

            //simple method if player is killed: 
            public bool Dead()
            {
                return Alive != true;
            }

            public void printPropeties() { 
                //to return values or current stat of Player Object
                //to relate through game interface if needed as well.
            }

        }
        
        public abstract class Game : Player
        { 
            //potential interface call here inbetween Game/Player?
            //use BillGnant object with _billg annotation for iteration?

        }

        //'Game' Inheritance structure Character -> Player -> Game
        // Properties in seperate 'Game' class of Models folder.
    }
}
