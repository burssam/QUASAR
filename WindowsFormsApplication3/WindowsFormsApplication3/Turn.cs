﻿using System;
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
            int money =(int)player[1] ;
            int bet =(int)player[2];
            if (sum == 15)
            {
                player[1] = (int)((money)+(bet * 0.25));
                LBLstupid.Text = "It's better than losing it all?";
                LBLgains.Text = "You lost " + bet*.75;
            }
            else if (sum == 16)
            {
                player[1] = (int)((money) + (bet * 0.5));
                LBLstupid.Text = "I guess you're not a complete loser but that's still pretty bad.";
                LBLgains.Text = "You lost " + bet * .5;
            }
            else if (sum == 17)
            {
                player[1] = (int)((money) + (bet));
                LBLstupid.Text = "No prize money for you this time.";
                LBLgains.Text = "You broke even.";
            }
            else if (sum == 18)
            {
                player[1] = (int)((money) + (bet * 1.25));
                LBLstupid.Text = "Pocket change, but it's better than nothing.";
                LBLgains.Text = "You won " + bet * .25;
            }
            else if (sum == 19)
            {
                player[1] = (int)((money) + (bet * 1.5));
                LBLstupid.Text = "Think of all the things you can buy with these points!";
                LBLgains.Text = "You won " + bet * .5;
            }
            else if (sum == 20)
            {
                player[1] = (int)((money) + (bet * 2));
                LBLstupid.Text = "A perfect score? Amazing.";
                LBLgains.Text = "You won " + bet;
            }
            else if (sum > 20)
            {
                LBLstupid.Text = "You went over 20 and lost it all.";
            }
            if (players.Count >1) {
                LBLplayer.Text = ("It's " + player[0] + "'s Turn Number"+ player[3]);
                LBLbet.Text = "Your current bet is " + player[2];
            }
  
        }
    }
}
