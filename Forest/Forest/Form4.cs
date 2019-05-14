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
    public partial class Room2 : Form
    {
        public Room2()
        {
            InitializeComponent();
        }

        private int indexFamilyIssue = 0;
        

        private void FamilyIssues()
        {
            if (indexFamilyIssue < 7)
            {
                var issues = new[] {"Бабушка: Что за цвет? Ты бы еще в зеленый выкрасился!", "Мама: Яйца курицу не учат", "Отец: Меня достал этот твой юношеский максимализм!",
                "Дедушка: Посмотри на своего брата, бери с него пример!", "Мама: Я прочитала на твоей странице, что ты бисексуал. Что это значит?",
                    "Отец: Мы тебя кормим и даем крышу над головой. Не нравится, вали!", ""};
                familyBox.Text = issues[indexFamilyIssue];
                indexFamilyIssue++;

            }
            

        }

        public void WinnerOrLoser()
        {
            int m = familyProgressBar.Value;

            if (m > 70)
            {
                MessageBox.Show("Вы ушли из дома", "Скандал", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }

            if (m < 70 && m > 50)
            {
                MessageBox.Show("Вы разругались с семьёй", "Ссора", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }

            if (m < 50)
            {
                MessageBox.Show("Вас оскорбляет семья и вы молчит", "Обида", MessageBoxButtons.OK, MessageBoxIcon.None);
                this.Close();
            }
        }

        public void ButtonChange()
        {
            if (indexFamilyIssue == 1)
            {
                family1.Text = "Простите...";
                family2.Text = "Промолчать.";
                family3.Text = "Бабуль, это моя голова? Мне и решать.";

            }

            if (indexFamilyIssue == 2)
            {
                family1.Text = "Взгляд в стол и молчать";
                family2.Text = "У меня тоже есть мнение.";
                family3.Text = "Разве курица умеет говорить?";

            }

            if (indexFamilyIssue == 3)
            {
                family1.Text = "Уйти в другую комнату";
                family2.Text = "У меня не может быть своих мыслей?";
                family3.Text = "Может тебя просто не устраивает моё мнение?";

            }

            if (indexFamilyIssue == 4)
            {
                family1.Text = "Уйти от разговора";
                family2.Text = "Посмотреть на брата и кивнуть";
                family3.Text = "Хватит сравнивать меня с другими людьми!";

            }

            if (indexFamilyIssue == 5)
            {
                family1.Text = "Это люди которые любят бисер.";
                family2.Text = "Ты лазила в моём телефоне?";
                family3.Text = "Я люблю мальчиков и девочек. Не нравится такой сын? Очень жаль.";

            }

            if (indexFamilyIssue == 6)
            {
                family1.Text = "Попросить прощения";
                family2.Text = "Продолжить спор";
                family3.Text = "Уйти из дома";

            }

            if (indexFamilyIssue == 7)
            {
                WinnerOrLoser();
            }
        }
            
        private void family1_Click(object sender, EventArgs e)
        {
            FamilyIssues();
            ButtonChange();
            familyProgressBar.Increment(-10);
            
        }

        private void family2_Click(object sender, EventArgs e)
        {
            FamilyIssues();
            ButtonChange();
            familyProgressBar.Increment(5);
        }

        private void family3_Click(object sender, EventArgs e)
        {
            FamilyIssues();
            ButtonChange();
            familyProgressBar.Increment(15);
            
        }

    }
}
