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

            if (players.Count > 1)
            {
                LBLplayer.Text = ("It's " + player[0] + "'s Turn to Bet");
                LBLplayer.Visible = true;
            }
            player[2] = NUDbet.Value;
        }
        public void playTurn(object [] player)
        {
            if (players.Count >1) {
                LBLplayer.Text = ("It's " + player[0] + "'s Turn Number"+ player[3]);
                LBLbet.Text = "Your current bet is " + player[2];
            }
  
        }
    }
}
