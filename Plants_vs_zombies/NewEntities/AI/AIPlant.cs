using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AIPlant : AIBase
    {
        public AIPlant(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            AIState = "None";
            if (Global.Entities.Find(x => x.GetType() == typeof(ZombieEntity) && Coord.YtoRow((int)x.CorrectedY) == Coord.YtoRow((int)AssociatedGameObject.CorrectedY)) != null)
            {
                AIState = "Shooting";
            }
        }
    }
}
