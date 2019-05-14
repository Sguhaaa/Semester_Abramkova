using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forest
{
    public partial class Room1 : Form
    {
        public Room1()
        {
            InitializeComponent();
        }

        private int food = 70;
        private int power = 90;
        private int smile = 50;

        Random random = new Random();

        private void pictureBox1_Click(object sender, EventArgs e)
        {           
           
        }

        private void AllState()
        {
            if (food > 100)
            {
                timerState.Enabled = false;
                MessageBox.Show("Котёнок умер от переедания", "Смерть", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                this.Close();
            }

            if (food <= 0)
            {
                food = 0;
                timerState.Enabled = false;
                MessageBox.Show("Котёнок умер от голода", "Смерть", MessageBoxButtons.OK, MessageBoxIcon.None);
               
                this.Close();
            }

            if (power > 100)
            {
                timerState.Enabled = false;
                MessageBox.Show("Котёнок впал в кому", "Смерть", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                this.Close();
            }

            if (power <= 0)
            {
                power = 0;
                timerState.Enabled = false;
                MessageBox.Show("Котёнок упал без сил", "Смерть", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                this.Close();
            }

            if (smile > 100)
            {
                smile = 100;
            }

            if (smile <= 0)
            {
                smile = 0;
                timerState.Enabled = false;
                MessageBox.Show("Котёнок умер, вы его затискали", "Смерть", MessageBoxButtons.OK, MessageBoxIcon.None);
                
                this.Close();
            }


            eatState.Text = food + " / 100";
            sleepState.Text = power + " / 100";
            funnyState.Text = smile + " / 100";

        }

        private void eat_Click(object sender, EventArgs e)
        {
            if (food < 100)
            {
                int plusFood = random.Next(20);
                food += plusFood;

                catState.Text = "Котёнок поел и мурчит";
                AllState();

            }
            else
            {
                AllState();                
               
            }


        }

        private void sleep_Click(object sender, EventArgs e)
        {
            if(power < 100)
            {
                int plusPower = random.Next(10);
                power += plusPower;

                catState.Text = "Забавно дрыгает лапками во сне";
                AllState();
            }
            else
            {
                AllState();                
                
            }
        }

        private void funny_Click(object sender, EventArgs e)
        {
            if (smile < 100)
            {
                int plusSmile = random.Next(10);
                smile += plusSmile;

                catState.Text = "Котёнок играет с вами";
                AllState();
            }
            else
            {
                AllState();
                
            }
        }

        private void timerState_Tick(object sender, EventArgs e)
        {            
            food -= 1;
            power -= 2;
            smile -= 1;

            AllState();
        }

    }
}
