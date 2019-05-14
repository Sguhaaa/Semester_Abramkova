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
    public partial class Room0 : Form
    {
       
        public Room0()
        {
            InitializeComponent();
        }

        private void Text_Timer_Tick(object sender, EventArgs e)
        {
            EndText();
        }

        private void EndText()
        {
            if (Global.Cat == 1 && Global.Dinner == 0)
            {
                textBox1.Text = ("Кто я такой? " +
                    "\nКакое - то странное место, здесь много комнат. Две из них открыты. " +
                    "\nНужно зайти и посмотреть. " +
                    "\nА еще здесь есть две кнопки, такие надписи меня пугают. " +
                    "\nСначала комнаты. " +
                    "\nЯ что, убил кошку? " + "\nКажется начинаю вспоминать. ");

            }
            if (Global.Cat == 0 & Global.Dinner == 1)
            {
                textBox1.Text = ("\nНовые воспоминания. Меня зовут ** и я не люблю свою семью. " + 
                    "\nТак гадко на душе, неужели я оказался здесь, потому что сбежал от них?");
            }

            if (Global.Cat == 1 && Global.Dinner == 1)
            {
                textBox1.Text = ("Меня зовут ** и я устал. " + "\nЭто были воспоминания о моей жизни. Семья гнобит и не принимает " +
                    "\nПроблемы в школе. " + "\nСмерть нашей кошки свалили на меня. " + "\nХочу ли я вернуться туда? К ним? " + "\nПора нажать на кнопку");
            }
        }

        private void end1_Click(object sender, EventArgs e)
        {
            Global.Dinner += 1;
            Global.Cat += 1;
            End newForm6 = new End();
            newForm6.Show();
            this.Close();
            
        }

        private void end2_Click(object sender, EventArgs e)
        {
            End newForm6 = new End();
            newForm6.Show();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main newForm2 = new Main();
            newForm2.Show();
            this.Close();
        }
    }
}
