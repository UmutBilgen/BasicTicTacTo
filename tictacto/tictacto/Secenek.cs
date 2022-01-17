using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictacto
{
 
    public partial class Secenek : Form
    {
        public int bilgisayar = 0;
        public Secenek()
        {
            InitializeComponent();
        }
     
        private void button1_Click(object sender, EventArgs e)
        {
            PlayerVComputer f2 = new PlayerVComputer();
            f2.Show(); this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerVPlayer f3 = new PlayerVPlayer();
            f3.Show(); this.Hide();
        }
    }
}
