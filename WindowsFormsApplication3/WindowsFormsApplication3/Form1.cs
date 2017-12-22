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
        int turnMulti=0;
        Boolean lastPlay;
        int screen = 0;
        int numPlayers = 1;
        int turnz = 0;
        int holdThis = 1;
        int middlePos = 350;
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

            if (numPlayers > 1)
            {
                betTurn(players[turn]);
                turn++;
                if (turn<players.Count) {
                    LBLplayer.Text = ("It's " + players[turn][0] + "'s turn to bet");
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
                    LBLplayer.Text = ("It's " + players[0][0] + "'s Turn Number " + holdThis);
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
                lastPlay = true;
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
                LBLplayer.Text = ("It's " + players[0][0] + "'s turn to bet");
                lastPlay = false;
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
                if ( lastPlay == true) {
                    BUTnext.Text = "See Results!";
                }
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
            if (lastPlay == true)
            {
                BUTnext.Text = "See Results!";
            }
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
                if (lastPlay == true)
                {
                    BUTnext.Text = "See Results!";
                }
                BUTnext.Visible = true;
            }
        }

        private void BUTnext_Click(object sender, EventArgs e)
        {

            if (turnz == ((players.Count) * 5)-1)
            {
                lastPlay = true;
            }
            if (players.Count >= 1)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    LBLbuggy.Text += (players[i][0] + "  turn" + players[i][3]+ " $$" + players[i][1]);
                }
                LBLbuggy.Text += ("\n"); 

            }
     
            if (numPlayers > 1)
                {
                   // turn++;
                    if (turn < players.Count)
                    {
                        LBLplayer.Text = ("It's turn number " + holdThis + " for " + players[turn][0]);
                        LBLbet.Text = "Your current bet is " + players[turn][2];
                    sum = 0;
                    LBLstupid.Visible = false;
                    LBLgains.Visible = false;
                    BUTstay.Visible = false;
                    BUTnext.Visible = false;
                    BUT47.Visible = true;
                    BUT18.Visible = true;
                    updatePlayer(players[turn], 3, turnMulti);
                    LBLplayer.Visible = true;
                }
              }
               else
                {
                sum = 0;
                LBLstupid.Visible = false;
                LBLgains.Visible = false;
                BUTstay.Visible = false;
                BUTnext.Visible = false;
                BUT47.Visible = true;
                BUT18.Visible = true;
                updatePlayer(players[0], 3, turn);
                LBLplayer.Text = ("It's turn number " + (holdThis));
                LBLplayer.Visible = true;
                //turn = 1;
                }

            if (holdThis == 6 && players.Count == 1)
            {

                LBLinst.Text = "Good job, " + players[0][0] + "\n Your end total was " + players[0][1] + " points";

                LBLinst.SetBounds(middlePos - 100, 200, 200, 100);
                screen = 4;
                state();
            }
            else if (players.Count > 1 && turnz==(players.Count)*5)
            {

                //
                List<object[]> playersSort = players.OrderByDescending(o => o[1]).ToList();
                LBLinst.Text = "Leaderboard:";
                for (int i = 0; i < players.Count; i++)
                {
                    LBLinst.Text += " \n\n" + playersSort[i][0] + ": " + playersSort[i][1] + " points";
                }
                //
                screen=4;
                state();

            }

            

        }

        private void LBLtitle_Click(object sender, EventArgs e)
        {

        }

        private void LBLplayer_Click(object sender, EventArgs e)
        {

        }

        private void LBLbet_Click(object sender, EventArgs e)
        {

        }

        private void LBLgains_Click(object sender, EventArgs e)
        {

        }

        private void LBLmulti_Click(object sender, EventArgs e)
        {

        }

        private void LBLsingle_Click(object sender, EventArgs e)
        {

        }

        private void LBLinst_Click(object sender, EventArgs e)
        {

        }

        private void LBLstupid_Click(object sender, EventArgs e)
        {

        }
    }
}
