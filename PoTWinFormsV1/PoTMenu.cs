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

        public PoTMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Character p1 = new Character("01", "Bill gNant", 1, 1, true);
        }

        private void pStats_Click(object sender, EventArgs e)
        {
            // Console.WriteLine(lblPstats)
            //display stats to the label on form
            lblPstats.Text = p1.ToString(); 
        }
    }
}
