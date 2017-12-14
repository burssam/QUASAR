using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    partial class Form1
    {

    public object[] player(string name)
        {
            object[] playerInfo = new object[4];
            playerInfo[0] = name;
            playerInfo[1] = (int)500;
            playerInfo[0] = bet;
            playerInfo[0] = (int)5 ;
            return playerInfo;
        }
    }

   /* public object[] player(string name, int points, int bet, int turnsLeft)
        {
         object[] playerInfo = new object [4];
        playerInfo[0] = name;
        playerInfo[1] = points;
        playerInfo[0] = bet;
        playerInfo[0] = turnsLeft;
        return playerInfo;
        }
    }*/
}
