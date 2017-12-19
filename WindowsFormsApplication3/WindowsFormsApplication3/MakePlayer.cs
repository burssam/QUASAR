using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    partial class Form1
    {

    public object[] newPlayer(string name)
        {
            object[] playerInfo = new object[4];
            playerInfo[0] = name;
            playerInfo[1] = (int)500;
            playerInfo[2] = bet;
            playerInfo[3] = (int)1 ;
            return playerInfo;
        }
    

    public object[] updatePlayer(object [] player, int operation, int val)
        {
            // 1 = money, 2 = bet, 3 = turns
            player[operation] = val;

            return player;
        }
    }
}
