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
        int turn = 0;
        int turn5 = 0;
        int screen = 0;
        int numPlayers = 1;
        Boolean clickStay = false;
        Boolean clickBet = false;
        List<object[]> players = new List<object[]>();
        public Form1()
        {
           InitializeComponent();
            state();
            LBLtitle.Visible = true;
            BUTstay.Visible = false;
            LBLstupid.Visible = false;
            LBLplayer.Visible = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void BUT47_Click(object sender, EventArgs e)
        {
            int roll = die47();
            TB47.Text = roll.ToString();
            sum += roll;
            TBsum.Text = sum.ToString();
            if (sum > 20)
            {
                LBLstupid.Text = "ahahahahahahahhahaha";
            }
        }

        private void BUTbet_Click(object sender, EventArgs e)
        {
            updatePlayer(players[0], 2, (int)(NUDbet.Value));
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

            clickBet = true;
            if (numPlayers > 1)
            {
                betTurn(players[turn]);
                turn++;
                if (turn<players.Count) {
                    LBLplayer.Text = ("It's " + players[turn][0] + "'s Turn to Bet");
                }
            }
            else
            {
                betTurn(players[0]);
                turn=1;
            }
  
            if (turn==numPlayers)
            {
                LBLplayer.Text = ("It's " + players[0][0] + "'s Turn Number " + players[0][3]);
                LBLbet.Text = ("Your current bet is "+ players[0][2]);
                turn = 0;
                screen = 3;
                state();
               
            }
            

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
                players.Add(newPlayer(TBsingle.Text));
                screen = 2;
                state();
            } 
            else if (TBmulti.Text!="")
            {
                for (int i = 0; i < TBmulti.Lines.Length; i++)
                {
                   players.Add(newPlayer(TBmulti.Lines[i]));
                }
                numPlayers = TBmulti.Lines.Length;
                LBLplayer.Text = ("It's " + players[0][0] + "'s Turn to Bet");
                screen = 2;
                state();
                LBLplayer.Visible = true;

            }
            else
            {
                LBLstupid.Visible = true;
            }
      
        }

        private void BUT18_Click(object sender, EventArgs e)
        {
            int roll = die18();
            TB18.Text = roll.ToString();
            sum += roll;
            TBsum.Text = sum.ToString();
            if (sum >= 15)
            {
                BUTstay.Visible = true;
            }
            if (sum > 20)
            {
                playTurn(players[turn]);
                LBLstupid.Visible = true;
                LBLgains.Visible = true;
                BUTnext.Visible = true;

            }
        }

        private void BUTstay_Click(object sender, EventArgs e)
        {
            playTurn(players[turn]);
        }

        private void BUT47_Click_1(object sender, EventArgs e)
        {
            int roll = die47();
            TB47.Text = roll.ToString();
            sum += roll;
            TBsum.Text = sum.ToString();
            if (sum >= 15)
            {
                BUTstay.Visible = true;
            }
           if (sum > 20)
            {
                playTurn(players[turn]);
                LBLstupid.Visible = true;
                LBLgains.Visible = true;
                BUTnext.Visible = true;
            }
        }

        private void BUTnext_Click(object sender, EventArgs e)
        {
            //players[bet][3]--;
            while (turn5 < 6) {
                if (numPlayers > 1)
                {
                    LBLtitle.Text += (players[turn][0] + "'sbmonsy" + players[turn][1]);
                    turn++;
                    if (turn < players.Count)
                    {
                        LBLplayer.Text = ("It's " + players[turn][0] + "'s Turn Number" + players[turn][3]);
                        LBLbet.Text = "Your current bet is " + players[turn][2];
                    }
                }
                else
                {
                    playTurn(players[0]);
                    turn = 1;
                }
                turn5++;
            }
            if (turn == numPlayers && turn5 == 5)
            {
                LBLplayer.Text = ("It's " + players[0][0] + "'s Turn Number " + players[0][3]);
                LBLbet.Text = ("Your current bet is " + players[0][2]);
                screen = 3;
                state();

            }

        }
    }
}
