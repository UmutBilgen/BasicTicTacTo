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
    public partial class PlayerVPlayer : Form
    {
        Boolean bitti = false;
        Boolean oyuncu = true;

        Boolean berabere = false;
        int[] sanalsıra1 = { 0, 0, 0 };
        int[] sanalsıra2 = { 0, 0, 0 };
        int[] sanalsıra3 = { 0, 0, 0 };

        int satir1, satir2, satir3, sutun1, sutun2, sutun3, capraz1, capraz2;

        int sıra = 0;
        void kontrol()
        {
            satir1 = sanalsıra1[0] + sanalsıra1[1] + sanalsıra1[2]; // satır 1

            satir2 = sanalsıra2[0] + sanalsıra2[1] + sanalsıra2[2]; // satır 2   

            satir3 = sanalsıra3[0] + sanalsıra3[1] + sanalsıra3[2]; // satır 3

            sutun1 = sanalsıra1[0] + sanalsıra2[0] + sanalsıra3[0]; //sutun1 

            sutun2 = sanalsıra1[1] + sanalsıra2[1] + sanalsıra3[1]; // sutun2 

            sutun3 = sanalsıra1[2] + sanalsıra2[2] + sanalsıra3[2]; // sutun3

            capraz1 = sanalsıra1[0] + sanalsıra2[1] + sanalsıra3[2]; // capraz 1

            capraz2 = sanalsıra1[2] + sanalsıra2[1] + sanalsıra3[0]; // capraz 2
            if (sutun1 == 9 || sutun2 == 9 || sutun3 == 9 || satir1 == 9 || satir2 == 9 || satir3 == 9 || capraz1 == 9 || capraz2 == 9) // X'ler 3 puan 
            {
                bitti = true;
                MessageBox.Show("1. Oyuncu Kazandı");
                Kare1.Enabled = false;
                Kare2.Enabled = false;
                Kare3.Enabled = false;
                Kare4.Enabled = false;
                Kare5.Enabled = false;
                Kare6.Enabled = false;
                Kare7.Enabled = false;
                Kare8.Enabled = false;
                Kare9.Enabled = false;

            }
            else if (sutun1 == 15 || sutun2 == 15 || sutun3 == 15 || satir1 == 15 || satir2 == 15 || satir3 == 15 || capraz1 == 15 || capraz2 == 15) // O'lar 5 puan
            {
                bitti = true;
                MessageBox.Show("2. Oyuncu Kazandı");
                Kare1.Enabled = false;
                Kare2.Enabled = false;
                Kare3.Enabled = false;
                Kare4.Enabled = false;
                Kare5.Enabled = false;
                Kare6.Enabled = false;
                Kare7.Enabled = false;
                Kare8.Enabled = false;
                Kare9.Enabled = false;
            }
            else if (satir1 + satir2 + satir3 == 35)
            {
                berabere = true;
                MessageBox.Show("Oyun Berabere Bitti");
                Kare1.Enabled = false;
                Kare2.Enabled = false;
                Kare3.Enabled = false;
                Kare4.Enabled = false;
                Kare5.Enabled = false;
                Kare6.Enabled = false;
                Kare7.Enabled = false;
                Kare8.Enabled = false;
                Kare9.Enabled = false;
            }

        }
        public PlayerVPlayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sıra%2==0)
            {
                Kare1.Text = "X";
                sanalsıra1[0]= 3;
                Kare1.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare1.Text = "O";
                sanalsıra1[0] = 5;
                Kare1.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
            kontrol();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Oyuncu1.ForeColor = Color.Red;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare2.Text = "X"; sanalsıra1[1] = 3;
                Kare2.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare2.Text = "O"; sanalsıra1[1] = 5;
                Kare2.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            satir1 = 0;
            satir2 = 0;
            satir3 = 3;
            sutun3 = 0;
            sutun2 = 0;
            sutun1 = 0;
            capraz1 = 0;
            capraz2 = 0;
            Kare1.Text = "";
            Kare1.Enabled = true;

            Kare2.Text = "";
            Kare2.Enabled = true;

            Kare3.Text = "";
            Kare3.Enabled = true;

            Kare9.Text = "";
            Kare9.Enabled = true;
            Kare8.Text = "";
            Kare8.Enabled = true;
            Kare7.Text = "";
            Kare7.Enabled = true;
            Kare6.Text = "";
            Kare6.Enabled = true;
            Kare5.Text = "";
            Kare5.Enabled = true;
            Kare4.Text = "";
            Kare4.Enabled = true;
            for (int i = 0; i < 3; i++)
            {
                sanalsıra1[i] = 0;

                sanalsıra2[i] = 0;

                sanalsıra3[i] = 0;
            }
            bitti = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Secenek f1 = new Secenek();
            f1.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare3.Text = "X"; sanalsıra1[2] = 3;
                Kare3.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare3.Text = "O"; sanalsıra1[2] = 5;
                Kare3.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare4.Text = "X"; sanalsıra2[0] = 3;
                Kare4.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                sanalsıra2[0] = 5;
                Kare4.Text = "O";
                Kare4.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare5.Text = "X"; sanalsıra2[1] = 3;
                Kare5.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare5.Text = "O"; sanalsıra2[1] = 5;
                Kare5.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare6.Text = "X"; sanalsıra2[2] = 3;
                Kare6.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare6.Text = "O"; sanalsıra2[2] = 5;
                Kare6.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare7.Text = "X"; sanalsıra3[0] = 3;
                Kare7.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare7.Text = "O"; sanalsıra3[0] = 5;
                Kare7.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare8.Text = "X"; 
                sanalsıra3[1] = 3;
                Kare8.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare8.Text = "O"; sanalsıra3[1] = 5;
                Kare8.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (sıra % 2 == 0)
            {
                Kare9.Text = "X"; 
                sanalsıra3[2] = 3;
                Kare9.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu1.ForeColor = Color.Black;
                Oyuncu2.ForeColor = Color.Red;
            }
            else
            {
                Kare9.Text = "O"; sanalsıra3[2] = 5;
                Kare9.Enabled = false;
                kontrol();
                sıra++;
                Oyuncu2.ForeColor = Color.Black;
                Oyuncu1.ForeColor = Color.Red;
            }
        }
    }
}
