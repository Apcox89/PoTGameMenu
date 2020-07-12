using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoTWinFormsV1
{
    class Character
    {
        //character properties:
        public string PlayerID;
        public string PlayerName;
        public int XP;
        public int points;
        public bool Alive;

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

        //simple method if player is killed: 
        public bool Dead()
        {
            return Alive != true;
        }

        public override string ToString()
        {
            return "Id: " + PlayerID + " Name: " + PlayerName + " Xp: " + XP + " Points: " + points +
                        " Status: " + Alive;
        }
    }
}
