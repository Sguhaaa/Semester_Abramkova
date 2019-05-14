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
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1Change();
        }
        
        private void textBox1Change()
        {
            if (Global.Cat == 2)
            {
                textBox1.Text = "Главный герой покончил жизнь самоубийством. " +
                    " Это было его посмертие, где вы могли наблюдать причины его решения уйти из жизни." +
                    " У вас была возможность дать ему еще один шанс жить или дать умереть.";
            }
        }
    }
}
