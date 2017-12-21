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
        Boolean turn5 = false;
        int screen = 0;
        int numPlayers = 1;
        int finiTurn = 0;
        int holdThis = 1;
        Boolean clickStay = false;
        Boolean clickBet = false;
        List<object[]> players = new List<object[]>();
        public Form1()
        {
           InitializeComponent();
            state();
            //LBLinst.Text = "Leaderboard:" + " \n\n" + screen;
            LBLtitle.Visible = true;
            BUTstay.Visible = false;
            LBLstupid.Visible = false;
            LBLplayer.Visible = false;


        }
        private void button1_Click(object sender, EventArgs e)
        {
       
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
            NUDbet.Value = 50;
            if (turn==numPlayers)
            {
                if (players.Count > 1)
                {
                    LBLplayer.Text = ("It's " + players[0][0] + "'s Turn Number " + players[0][3]);
                }
                else
                {
                    LBLplayer.Text = ("It's turn number " + holdThis);
                }
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
                if (players.Count > 1)
                {
                    playTurn(players[turn]);
                }
                else
                {
                    playTurn(players[0]);
                }
                LBLstupid.Visible = true;
                LBLgains.Visible = true;
                BUTnext.Visible = true;
            }
        }

        private void BUTstay_Click(object sender, EventArgs e)
        {
            if (players.Count > 1)
            {
                playTurn(players[turn]);
            }
            else
            {
                playTurn(players[0]);
            }

            LBLstupid.Visible = true;
            LBLgains.Visible = true;
            BUTnext.Visible = true;
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
                if (players.Count > 1)
                {
                    playTurn(players[turn]);
                }
                else
                {
                    playTurn(players[0]);
                }
                LBLstupid.Visible = true;
                LBLgains.Visible = true;
                BUTnext.Visible = true;
            }
        }

        private void BUTnext_Click(object sender, EventArgs e)
        {
            holdThis = (int)players[0][3] + 1;
            if (players.Count >= 1)
            {
                LBLbuggy.Text += ( players[0][3]+ " monies" + players[0][1]);

            }
            //turn++;
            finiTurn = (int)players[players.Count - 1][3];
            if (finiTurn == 5)
            {
                turn5 = true;
            }
            if (numPlayers > 1)
                {
                    turn++;
                    if (turn < players.Count)
                    {
                        LBLplayer.Text = ("It's turn number " + players[turn][3] + " for " + players[turn][0]);
                        LBLbet.Text = "Your current bet is " + players[turn][2];
                    }
              }
               else
                {
                sum = 0;
                LBLstupid.Visible = false;
                LBLgains.Visible = false;
                BUTstay.Visible = false;
                BUTnext.Visible = false;
                updatePlayer(players[0], 3, turn);
                LBLplayer.Text = ("It's turn number " + holdThis);
                LBLplayer.Visible = true;
                //turn = 1;
                }
            if (turn == numPlayers && turn5 == true)
            {
                if (players.Count > 1)
                {
                    //
                    List<object[]> playersSort = players.OrderByDescending(o => o[1]).ToList();
                    LBLinst.Text = "Leaderboard:";
                    for (int i = 0; i < players.Count; i++)
                    {
                        LBLinst.Text += " \n\n" + playersSort[i][0] + ": " + playersSort[i][1] + " points";
                    }
                    //
                    LBLinst.Visible = true;
                }
                

            }
            else if (holdThis == 6)
            {
                LBLinst.Text = "Good Job, "+ players[0][0] +"\n Your end total was \n" + players[0][1];
                screen = 4;
                state();

            }

        }

        private void LBLtitle_Click(object sender, EventArgs e)
        {

        }
    }
}
