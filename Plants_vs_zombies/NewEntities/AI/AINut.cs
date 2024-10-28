using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AINut : AIBase
    {
        public AINut(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            CHealth health = AssociatedGameObject.GetComponent<CHealth>();
            CDrawable nutDraw = AssociatedGameObject.GetComponent<CDrawable>();

            if (health.HP > 1333)
                nutDraw.cycle = 0;
            else if (health.HP < 1332 && health.HP > 666)
                nutDraw.cycle = 1;
            else
                nutDraw.cycle = 2;
        }
    }
}