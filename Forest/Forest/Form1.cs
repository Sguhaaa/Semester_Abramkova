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
    public partial class Hello : Form
    {
        public Hello()
        {
            InitializeComponent();
        }

        private int indexStart = 0;

        private void StartGame()
        {
            if (indexStart < 12)
            {
                var start = new[] {"Отлично. Ты здесь не впервые?","Оно и видно, тебя знатно потрепало. Устал?", "Мы можем отдохнуть, но позже, хорошо?",
                "Отлично. Тогда идём дальше.", "Хах, а ты знаешь слова кроме «да»?", "Возможно, тебя смутили две кнопки ДА.",
                    "Так вот, знакомься, это иллюзия выбора. Вся наша жизнь такая же иллюзия.","Но сейчас это не главное.",
                    "Тебя уже заждались на той стороне, всё как обычно, помнишь?",
                "В этот раз ты накопил много комнат. Не забудь зайти в каждую, хорошо?", "Тогда удачи, вперёд.", ""};
                helloBox.Text = start[indexStart];
                indexStart++;
                
            }
            if (indexStart == 12)
            {
                
                Main newForm2 = new Main();
                newForm2.Show();
                this.Hide();
                
            }

            
        }

        private void yes1_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void yes2_Click(object sender, EventArgs e)
        {
            StartGame();
        }

    }
}
