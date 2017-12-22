using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    partial class Form1
    {
        public void betTurn(object [] player)
        {
            int money = (int)player[1];
            money -= (int)NUDbet.Value;
            player[2] =(int) NUDbet.Value;
            player[1] = money;
        }
        public void playTurn(object [] player)
        {
            int t = (int)player[3];
            t++;
           // LBLbugsp.Text += "\n\n" + player[1] +"start";
            player[3]= t;
            int bet =(int)player[2];
            int money = ((int)player[1] - bet) ;
            BUT47.Visible = false;
            BUT18.Visible = false;
            BUTstay.Visible = false;
            if (sum == 15)
            {
                player[1] = (int)((money)+(bet * 0.25)) + bet ;
                LBLstupid.Text = "It's better than losing it all?";
                LBLgains.Text = "You lost " + (int)(bet* .75) + " points";
            }
            else if (sum == 16)
            {
                player[1] = (int)((money) + (bet * 0.5)) + bet;
                LBLstupid.Text = "I guess you're not a complete loser but that's still pretty bad.";
                LBLgains.Text = "You lost " + (int)(bet * .5) + " points";
            }
            else if (sum == 17)
            {
                player[1] = (int)((money) + (bet)) + bet;
                LBLstupid.Text = "No prize money for you this time.";
                LBLgains.Text = "You broke even.";
            }
            else if (sum == 18)
            {
                player[1] = (int)((money) + (bet * 1.25)) + bet;
                LBLstupid.Text = "Pocket change, but it's better than nothing.";
                LBLgains.Text = "You won " + (int)(bet * .25) + " points";
            }
            else if (sum == 19)
            {
                player[1] = (int)((money) + (bet * 1.5)) + bet;
                LBLstupid.Text = "Think of all the things you can buy with these points!";
                LBLgains.Text = "You won " + bet * .5 + " points";
            }
            else if (sum == 20)
            {
                player[1] = (int)((money) + (bet * 2)) + bet;
                LBLstupid.Text = "A perfect score? Amazing.";
                LBLgains.Text = "You won " + bet + " points";
            }
            else if (sum > 20)
            {
                LBLstupid.Text = "You went over 20 and lost it all.";
                LBLgains.Text = "You lost " + bet + " points";
            }
            if (players.Count >1) {
                LBLplayer.Text = ("It's turn number " + holdThis + " for "+ player[0]);
                LBLbet.Text = "Your current bet is " + player[2];
                turn++;
                turnz++;
                
                if (player == players[players.Count - 1])
                {
                    turnMulti++;
                    turn = 0;
                    holdThis = (int)player[3] + 1;
                }

            }
            else
            {
                //LBLplayer.Text = ("It's turn number " + players[0][3] + " for " + players[0][0]);
                LBLplayer.Visible = true;
                turn++;
                turnz++;
            }

           
         
   
  
        }
    }
}
