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
    static class Global
    {
        public static int Cat = 0;
        public static int Dinner = 0;
        public static int Depression = 0;
    }

    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
                
        private void RoomsOpen()
        {
            if (rooms.SelectedItem == null)
            {
                MessageBox.Show("Так и будем стоять?", "Выбери комнату", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
            if (rooms.SelectedIndex == 0)
            {
                Room1 newForm3 = new Room1();
                newForm3.Show();
                Global.Cat += 1;               

                mainBox.Text = "Ты действительно убил котёнка? Вот уж не знаю, специально ли, но такое могло ударить по психике.";
            }
            if (rooms.SelectedIndex == 1)
            {
                Room2 newForm4 = new Room2();
                newForm4.Show();
                Global.Dinner += 1;

                mainBox.Text = "Вот это семейка... Жаль, что тебе пришлось снова отвечать на эти вопросы. Но, такая уж процедура.";
            }

            if (rooms.SelectedIndex == 2)
            {
                Room3 newForm7 = new Room3();
                newForm7.Show();
                Global.Depression += 1;
                mainBox.Text = "Кажется эта комната еще не готова.";
            }
        }

        private void okeyMain_Click(object sender, EventArgs e)
        {
            RoomsOpen();
        }

        private void who_Click(object sender, EventArgs e)
        {
            Room0 newForm5 = new Room0();
            newForm5.Show();
            this.Close();
        }
    }
}
