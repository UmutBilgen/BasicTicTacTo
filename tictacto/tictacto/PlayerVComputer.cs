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
    public partial class PlayerVComputer : Form
    {
        Boolean bitti = false;
        Boolean oyuncu = true;
     
        Boolean berabere = false;
        int[] sanalsıra1 = {0,0,0};
        int[] sanalsıra2 = { 0, 0, 0 };
        int[] sanalsıra3 = { 0, 0, 0 };
        int satir1, satir2, satir3, sutun1,sutun2,sutun3,capraz1, capraz2;
       
        private void button2_Click(object sender, EventArgs e)
        {
            if(bitti==false)
            {
                Boolean bilgisayar;
                sanalsıra1[1] = 3;
                Kare2.Text = "X";
                bilgisayar = true;
                kontrol();
                yapayzeka(bilgisayar);
                kontrol();
                Kare2.Enabled = false;
            }
           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (bitti == false)
            {
            Boolean bilgisayar;
            sanalsıra1[2] = 3;
            Kare3.Text = "X";
            bilgisayar = true;
            kontrol();
            yapayzeka(bilgisayar);
            kontrol();
            Kare3.Enabled = false;
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (bitti == false)
            {
                Boolean bilgisayar;
                sanalsıra2[0] = 3;
            
                Kare4.Text = "X";
                bilgisayar = true;
                kontrol();
                yapayzeka(bilgisayar);
                kontrol();
                Kare4.Enabled = false;
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (bitti == false)
            {
                        Boolean bilgisayar;
                        sanalsıra2[1] =3;
                        Kare5.Text = "X";
                        bilgisayar = true;
                        kontrol();
                        yapayzeka(bilgisayar);
                        kontrol();
                        Kare5.Enabled = false;
            }
           
        }
       

        private void button7_Click(object sender, EventArgs e)
        {
            if (bitti == false)
            {
                         Boolean bilgisayar;
                        sanalsıra3[0] = 3;
                        Kare7.Text = "X";
                        bilgisayar = true;
                        kontrol();
                        yapayzeka(bilgisayar);
                        kontrol();
                        Kare7.Enabled = false;
            }
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (bitti == false)
            {
                Boolean bilgisayar;
                sanalsıra3[1] = 3;
                Kare8.Text = "X";
                bilgisayar = true;
                kontrol();

                yapayzeka(bilgisayar);
                kontrol();
                Kare8.Enabled = false;
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (bitti == false)
            {   Boolean bilgisayar;
                sanalsıra3[2] = 3;
                Kare9.Text = "X";
                bilgisayar = true;
                kontrol();
                yapayzeka(bilgisayar);
                kontrol();
                Kare9.Enabled = false;
            }
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (bitti == false)
            {
                Boolean bilgisayar;
                sanalsıra2[2] = 3;
                Kare6.Text = "X";
                bilgisayar = true;
                kontrol();
                yapayzeka(bilgisayar);
                kontrol();
                Kare6.Enabled = false;
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
            for (int i=0;i<3;i++)
            {
                sanalsıra1[i] = 0;

                sanalsıra2[i] = 0;

                sanalsıra3[i] = 0;
            }
            bitti = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Secenek f1 = new Secenek();
            f1.Show();
            this.Hide();
        }

        Random rast = new Random();
        int rassat,rassut;
        public PlayerVComputer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean bilgisayar;
            sanalsıra1[0] = 3;
            Kare1.Text = "X";
            bilgisayar = true;
            kontrol();
            yapayzeka(bilgisayar);
            Kare1.Enabled = false;
            kontrol();
        }

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
            if (sutun1 == 9 || sutun2 == 9 || sutun3 == 9 || satir1 == 9 || satir2 == 9 || satir3 == 9 || capraz1 == 9 || capraz2 == 9 ) // X'ler 3 puan 
               {
                bitti = true;
                MessageBox.Show("Tebrikler Kazandınız");
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
                MessageBox.Show("Üzgünüm Kaybettiniz");
                Kare1.Enabled = false;
                Kare2.Enabled = false;
                Kare3.Enabled = false;
                Kare4.Enabled = false;
                Kare5.Enabled = false;
                Kare6.Enabled = false;
                Kare7.Enabled = false;
                Kare8.Enabled = false;
                Kare9.Enabled = false;
            } // o lar 5 puan
            else if(satir1+satir2+satir3==35)
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
        void yapayzeka(Boolean zbilgisayar)
        {
            if(bitti==false)
            {
                if(zbilgisayar == true)
                {
                    
                    // saldırı 
                    if (satir1 == 10)
                    {
                        if (sanalsıra1[0] == 0)
                        {
                            sanalsıra1[0] = 5;
                            Kare1.Text = "O";
                            Kare1.Enabled = false;
                        }
                        else if (sanalsıra1[1] == 0)
                        {
                            sanalsıra1[1] = 5;
                            Kare2.Text = "O";
                            Kare2.Enabled = false;
                        }
                        else if (sanalsıra1[2] == 0)
                        {
                            sanalsıra1[2] = 5;
                            Kare3.Text = "O";
                            Kare3.Enabled = false;
                        }
                    }
                    else if (satir2 == 10)
                    {
                        if (sanalsıra2[0] == 0)
                        {
                            sanalsıra2[0] = 5;
                            Kare4.Text = "O";
                            Kare4.Enabled = false;

                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare5.Text = "O";

                            Kare5.Enabled = false;
                        }
                        else if (sanalsıra2[2] == 0)
                        {
                            sanalsıra2[2] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                    }

                    else if (satir3 == 10)
                    {
                        if (sanalsıra3[0] == 0)
                        {
                            sanalsıra3[0] = 5;
                            Kare7.Text = "O";

                            Kare7.Enabled = false;
                        }
                        else if (sanalsıra3[1] == 0)
                        {
                            sanalsıra3[1] = 5;
                            Kare8.Text = "O";

                            Kare8.Enabled = false;
                        }
                        else if (sanalsıra3[2] == 0)
                        {
                            sanalsıra3[2] = 5;
                            Kare9.Text = "O";

                            Kare9.Enabled = false;
                        }
                    }
                    else if (sutun1 == 10)
                    {
                        if (sanalsıra1[0] == 0)
                        {
                            sanalsıra1[0] = 5;
                            Kare1.Text = "O";

                            Kare1.Enabled = false;
                        }
                        else if (sanalsıra2[0] == 0)
                        {
                            sanalsıra2[0] = 5;
                            Kare4.Text = "O";

                            Kare4.Enabled = false;
                        }
                        else if (sanalsıra3[0] == 0)
                        {
                            sanalsıra3[0] = 5;
                            Kare7.Text = "O";

                            Kare7.Enabled = false;
                        }
                    }
                    else if (sutun2 == 10)
                    {
                        if (sanalsıra1[1] == 0)
                        {
                            sanalsıra1[1] = 5;
                            Kare2.Text = "O";

                            Kare2.Enabled = false;
                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare5.Text = "O";

                            Kare5.Enabled = false;
                        }
                        else if (sanalsıra3[1] == 0)
                        {
                            sanalsıra3[1] = 5;
                            Kare8.Text = "O";

                            Kare8.Enabled = false;
                        }
                    }
                    else if (sutun3 == 10)
                    {
                        if (sanalsıra1[2] == 0)
                        {
                            sanalsıra1[2] = 5;
                            Kare3.Text = "O";

                            Kare3.Enabled = false;
                        }
                        else if (sanalsıra2[2] == 0)
                        {
                            sanalsıra2[2] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                        else if (sanalsıra3[2] == 0)
                        {
                            sanalsıra3[2] = 5;
                            Kare9.Text = "O";
                            Kare9.Enabled = false;
                        }
                    }
                    else if (capraz1 == 10)
                    {
                        if (sanalsıra1[0] == 0)
                        {
                            sanalsıra1[0] = 5;
                            Kare3.Text = "O";

                            Kare3.Enabled = false;
                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                        else if (sanalsıra3[2] == 0)
                        {
                            sanalsıra3[2] = 5;
                            Kare9.Text = "O";
                            Kare9.Enabled = false;
                        }
                    }
                    else if (capraz2 == 10)
                    {

                        if (sanalsıra1[2] == 0)
                        {
                            sanalsıra1[2] = 5;
                            Kare3.Text = "O";

                            Kare3.Enabled = false;
                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                        else if (sanalsıra3[0] == 0)
                        {
                            sanalsıra3[0] = 5;
                            Kare7.Text = "O";
                            Kare7.Enabled = false;
                        }
                    }
                    // savunma
                    if (satir1 == 6)
                    {
                        if (sanalsıra1[0] == 0)
                        {
                            sanalsıra1[0] = 5;
                            Kare1.Text = "O";
                            Kare1.Enabled = false;
                        }
                        else if (sanalsıra1[1] == 0)
                        {
                            sanalsıra1[1] = 5;
                            Kare2.Text = "O";
                            Kare2.Enabled = false;
                        }
                        else if (sanalsıra1[2] == 0)
                        {
                            sanalsıra1[2] = 5;
                            Kare3.Text = "O";
                            Kare3.Enabled = false;
                        }
                    }
                    else if (satir2 == 6)
                    {
                        if (sanalsıra2[0] == 0)
                        {
                            sanalsıra2[0] = 5;
                            Kare4.Text = "O";
                            Kare4.Enabled = false;

                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare5.Text = "O";

                            Kare5.Enabled = false;
                        }
                        else if (sanalsıra2[2] == 0)
                        {
                            sanalsıra2[2] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                    }

                    else if (satir3 == 6)
                    {
                        if (sanalsıra3[0] == 0)
                        {
                            sanalsıra3[0] = 5;
                            Kare7.Text = "O";

                            Kare7.Enabled = false;
                        }
                        else if (sanalsıra3[1] == 0)
                        {
                            sanalsıra3[1] = 5;
                            Kare8.Text = "O";

                            Kare8.Enabled = false;
                        }
                        else if (sanalsıra3[2] == 0)
                        {
                            sanalsıra3[2] = 5;
                            Kare9.Text = "O";

                            Kare9.Enabled = false;
                        }
                    }
                    else if (sutun1 == 6)
                    {
                        if (sanalsıra1[0] == 0)
                        {
                            sanalsıra1[0] = 5;
                            Kare1.Text = "O";

                            Kare1.Enabled = false;
                        }
                        else if (sanalsıra2[0] == 0)
                        {
                            sanalsıra2[0] = 5;
                            Kare4.Text = "O";

                            Kare4.Enabled = false;
                        }
                        else if (sanalsıra3[0] == 0)
                        {
                            sanalsıra3[0] = 5;
                            Kare7.Text = "O";

                            Kare7.Enabled = false;
                        }
                    }
                    else if (sutun2 == 6)
                    {
                        if (sanalsıra1[1] == 0)
                        {
                            sanalsıra1[1] = 5;
                            Kare2.Text = "O";

                            Kare2.Enabled = false;
                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare5.Text = "O";

                            Kare5.Enabled = false;
                        }
                        else if (sanalsıra3[1] == 0)
                        {
                            sanalsıra3[1] = 5;
                            Kare8.Text = "O";

                            Kare8.Enabled = false;
                        }
                    }
                    else if (sutun3 == 6)
                    {
                        if (sanalsıra1[2] == 0)
                        {
                            sanalsıra1[2] = 5;
                            Kare3.Text = "O";

                            Kare3.Enabled = false;
                        }
                        else if (sanalsıra2[2] == 0)
                        {
                            sanalsıra2[2] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                        else if (sanalsıra3[2] == 0)
                        {
                            sanalsıra3[2] = 5;
                            Kare9.Text = "O";
                            Kare9.Enabled = false;
                        }
                    }
                    else if (capraz1 == 6)
                    {
                        if (sanalsıra1[0] == 0)
                        {
                            sanalsıra1[0] = 5;
                            Kare3.Text = "O";

                            Kare3.Enabled = false;
                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                        else if (sanalsıra3[2] == 0)
                        {
                            sanalsıra3[2] = 5;
                            Kare9.Text = "O";
                            Kare9.Enabled = false;
                        }
                    }
                    else if (capraz2 == 6)
                    {
                        if (sanalsıra1[2] == 0)
                        {
                            sanalsıra1[2] = 5;
                            Kare3.Text = "O";

                            Kare3.Enabled = false;
                        }
                        else if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare6.Text = "O";

                            Kare6.Enabled = false;
                        }
                        else if (sanalsıra3[0] == 0)
                        {
                            sanalsıra3[0] = 5;
                            Kare9.Text = "O";
                            Kare9.Enabled = false;
                        }
                    }
                    else
                    {
                        if (sanalsıra2[1] == 0)
                        {
                            sanalsıra2[1] = 5;
                            Kare5.Text = "O";
                            Kare5.Enabled = false;
                        }
                        else
                        {
                            rassat = rast.Next(0,3);
                            if (rassat == 0)
                            {
                                if (sanalsıra1[0] == 0)
                                {
                                    sanalsıra1[0] = 5;
                                    Kare1.Text = "O";
                                    Kare1.Enabled = false;

                                }
                                else if (sanalsıra2[0] == 0)
                                {
                                    sanalsıra2[0] = 5;
                                    Kare4.Text = "O";
                                    Kare4.Enabled = false;
                                }
                                else if (sanalsıra3[0] == 0)
                                {
                                    sanalsıra3[0] = 5;
                                    Kare7.Text = "O";
                                    Kare7.Enabled = false;
                                }
                            }
                            else if (rassat == 1)
                            {
                                if (sanalsıra1[1] == 0)
                                {
                                    sanalsıra1[1] = 5;
                                    Kare2.Text = "O";
                                    Kare2.Enabled = false;

                                }
                                else if (sanalsıra2[1] == 0)
                                {
                                    sanalsıra2[1] = 5;
                                    Kare5.Text = "O";
                                    Kare5.Enabled = false;
                                }
                                else if (sanalsıra3[1] == 0)
                                {
                                    sanalsıra3[1] = 5;
                                    Kare8.Text = "O";
                                    Kare8.Enabled = false;
                                }
                            }

                            else if (rassat == 2)
                            {
                                if (sanalsıra1[2] == 0)
                                {
                                    sanalsıra1[2] = 5;
                                    Kare3.Text = "O";
                                    Kare3.Enabled = false;

                                }
                                else if (sanalsıra2[2] == 0)
                                {
                                    sanalsıra2[2] = 5;
                                    Kare6.Text = "O";
                                    Kare6.Enabled = false;
                                }
                                else if (sanalsıra3[2] == 0)
                                {
                                    sanalsıra3[2] = 5;
                                    Kare9.Text = "O";
                                    Kare9.Enabled = false;
                                }
                            }
                        }
                    }
                }
               

            }
        }
        
        private void form2_Load(object sender, EventArgs e)
        {

        }
    }
}
