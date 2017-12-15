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
                LBLplayer.Text = ("It's " + player[0] + "'s Turn");
            }
            if (clickBet == true)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    playTurn(players[i]);
                }
            }
        }
        public void playTurn(object [] player)
        {
            if (players.Count >1) {
                LBLplayer.Text = ("It's " + player[0] + "'s Turn");
            }
            if (clickStay == true)
            {
                for (int i = 0; i < players.Count; i++)
                {
                    playTurn(players[i]);
                }
            }
        }
    }
}
