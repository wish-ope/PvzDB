using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AIMine : AIBase
    {
        int begin;

        public AIMine(GameObject go) : base(go)
        {
            begin = Global.Round;
        }

        public override void DoIt()
        {
            if (Global.Round == (begin + 250))
            {
                AssociatedGameObject.GetComponent<CDrawable>().cycle = 1;
                AssociatedGameObject.GetComponent<CDrawable>().HitBox = new Size(24,24);

                AssociatedGameObject.offsetX += 18;
                AssociatedGameObject.offsetY += 5;
                AssociatedGameObject.AI = new AIActiveMine(AssociatedGameObject);
            }
        }
    }
}