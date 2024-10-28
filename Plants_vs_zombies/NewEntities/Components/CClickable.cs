using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CClickable : Component
    {
        public bool IsClicked { get; set; }
        
        public override void Update()
        {
            if (IsClicked)
                IsClicked = false;
        }
    }
}
