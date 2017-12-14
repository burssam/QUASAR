using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public int sum = 0;
        int bet = 0;
        int screen = 0;
        int numPlayers = 1;
        public Form1()
        {
           InitializeComponent();
            state();
            LBLtitle.Visible = true;
            BUTstay.Visible = false;
            LBLstupid.Visible = false;


        }

        public void state()
        {
            if (screen == 0)
            {
                //screen0
                LBLinst.Visible = true;
                BUTstart.Visible = true;
                //screen1
                LBLmulti.Visible = false;
                LBLsingle.Visible = false;
                TBsingle.Visible = false;
                TBmulti.Visible = false;
                BUTnumplay.Visible = false;
                //screen2
                NUDbet.Visible = false;
                BUTbet.Visible = false;
                //screen3
                BUT18.Visible = false;
                BUT47.Visible = false;
                TBsum.Visible = false;
                TB18.Visible = false;
                TB47.Visible = false;
               
            }
            else if (screen == 1)
            {
                //screen0
                LBLinst.Visible = false;
                BUTstart.Visible = false;
                //screen1
                LBLmulti.Visible = true;
                LBLsingle.Visible = true;
                TBsingle.Visible = true;
                TBmulti.Visible = true;
                BUTnumplay.Visible = true;
                //screen2
                NUDbet.Visible = false;
                BUTbet.Visible = false;
                //screen3
                BUT18.Visible = false;
                BUT47.Visible = false;
                TBsum.Visible = false;
                TB18.Visible = false;
                TB47.Visible = false;

            }
            else if (screen ==2 )
            {
                //screen0
                LBLinst.Visible = false;
                BUTstart.Visible = false;
                //screen1
                LBLmulti.Visible = false;
                LBLsingle.Visible = false;
                TBsingle.Visible = false;
                TBmulti.Visible = false;
                BUTnumplay.Visible = false;
                //screen2
                NUDbet.Visible = true;
                BUTbet.Visible = true;
                //screen3
                BUT18.Visible = false;
                BUT47.Visible = false;
                TBsum.Visible = false;
                TB18.Visible = false;
                TB47.Visible = false;

            }
            else if (screen == 3)
            {

                //screen0
                LBLinst.Visible = false;
                BUTstart.Visible = false;
                //screen1
                NUDbet.Visible = false;
                BUTbet.Visible = false;
                //screen2
                BUT18.Visible = true;
                BUT47.Visible = true;
                TBsum.Visible = true;
                TB18.Visible = true;
                TB47.Visible = true;
                //screen3

            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int roll = die18();
            TB18.Text = roll.ToString();
            sum += roll;
            TBsum.Text = sum.ToString();
        }

        private void BUT47_Click(object sender, EventArgs e)
        {
            int roll = die47();
            TB47.Text = roll.ToString();
            sum += roll;
            TBsum.Text = sum.ToString();
        }

        private void BUTbet_Click(object sender, EventArgs e)
        {
            bet = (int)NUDbet.Value;
            LBLtitle.Visible = false;
            screen = 2;
            state();
        }

        private void BUTstart_Click(object sender, EventArgs e)
        {
            
            screen = 1;
            state();
        }

        private void BUTbet_Click_1(object sender, EventArgs e)
        {
            bet = (int)NUDbet.Value;
            screen = 2;
            state();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BUTnumplay_Click(object sender, EventArgs e)
        {
            if (TBsingle.Text!="")
            {
                player((string)TBsingle.Text);
                screen = 2;
                state();
            } 
            else if (TBmulti.Text!="")
            {
                for (int i = 0; i < TBmulti.Lines.Length; i++)
                {
                    player(TBmulti.Lines[i]);
                }
                numPlayers = TBmulti.Lines.Length;
                screen = 2;
                state();
            }
            else
            {
                LBLstupid.Visible = true;
            }
        }
    }
}
