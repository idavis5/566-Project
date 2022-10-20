using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bShifts_Click(object sender, EventArgs e)
        {

            int option;
            Console.WriteLine("Hello Employee! \nPlease Select an a time below: \n1.Shift 12:30 \n2.Shift 2:30 \n3.Shift 4:30");
            string opt = Console.ReadLine();
            option = Convert.ToInt32(opt);
            if (option == 1)
            {
                string times = "12:30";
                Console.WriteLine("You have select the shift time of {0}", times);
            }
        }

        private void bDrop_Click(object sender, EventArgs e)
        {
            Console.WriteLine("The shifts open for dropping are \n1. 12:30 \n2. 3:30");

        }
    }
}
