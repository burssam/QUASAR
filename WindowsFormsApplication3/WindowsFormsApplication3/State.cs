using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    partial class Form1
    {
        public void state()
        {
            LBLstupid.Visible = false;
            if (screen == 0)
            {//inst
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
            {//names
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
            else if (screen == 2)
            {//betting
             
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
    }
}
