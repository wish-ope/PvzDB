using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CDisappear : Component
    {
        public int StartRound;
        public int Delay;

        public CDisappear(int delay)
        {
            StartRound = Global.Round;
            Delay = delay;
        }
        public override void Update()
        {
            if (Global.Round == StartRound + Delay)
            {
                Parent.Inactive = true;
            }
        }
    }
}
