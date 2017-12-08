using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    partial class Form1
    {
        Random rand = new Random();

        public int die18()
        {
            return rand.Next(1,9);
        }

        public int die47()
        {
            return rand.Next(4, 8);
        }
    }
}
