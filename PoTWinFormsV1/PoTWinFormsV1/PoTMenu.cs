using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoTWinFormsV1
{
    public partial class PoTMenu : Form
    {
        //Object instance as global:
        Character p1 = new Character("01", "Bill gNant", 1, 1, true);

        //need to invoke lvlUp method to check points through extended Player class
       // public void lvlUp() { }

        public PoTMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //To test Game Interface with loadable Object on Play
        }

        private void pStats_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(lblPstats)
            //display stats to the label on form
            lblPstats.Text = p1.ToString(); 
        }

        private void btnLvlDown_Click(object sender, EventArgs e)
        {
            //call lvlUp function to lose points in this instance
            //how to invoke? hmm.

            int lvlDown;
            
                p1.points -= 1;

            lvlDown = p1.LvlUp();

            //p1.points - 1; <- throws exception

            Console.WriteLine("Player has " + lvlDown);

            lblStatClicker.Text = p1.points.ToString();            

        }

        private void btnLvlUp_Click(object sender, EventArgs e)
        {
            //call lvlUp function to gain points
            int gainPoints;

            p1.points += 10;

            gainPoints = p1.LvlUp();
          
            Console.WriteLine("Player has " + gainPoints);
            lblStatClicker.Text = p1.points.ToString();

        }

        private void lblPstats_Click(object sender, EventArgs e)
        {

        }

        //XP stat-checker to verify if points equate to levling up
        private void btnXpStat_Click(object sender, EventArgs e)
        {
            int xpUp;

            p1.XP += 1;

            xpUp = p1.LvlUp();

            Console.WriteLine("Player has leveled up! " + xpUp);

            lblXpCurrent.Text = p1.XP.ToString();

        }

        //Pseudo-test for Dead() Player killed method:
        private void btnDead_Click(object sender, EventArgs e)
        {
            string output = "unknown";
             p1.Alive = false;

            if (p1.Alive == false)
            {
                output = "Player Killed";
            }

             lblAliveTest.Text += output;         

            //Script interaction with an object like this button could
            // change the outcome of the Player-Alive-Status or Dead() method

        }
    }
}
