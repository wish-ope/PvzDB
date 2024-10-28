using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AICherry : AIBase
    {
        int startRound;

        public AICherry(GameObject go) : base(go)
        {
            startRound = Global.Round;
        }

        public override void DoIt()
        {
            if (Global.Round >= (startRound + 80))
            {
                Explode();
            }
        }

        public void Explode()
        {
            int col = Coord.XtoColumn((int)AssociatedGameObject.posX);
            int row = Coord.YtoRow((int)AssociatedGameObject.posY);

            Global.Entities.FindAll(x => x.GetComponent<CHealth>() != null && x.Tags.Contains("Zombie")
            && Coord.XtoColumn((int)x.posX) >= col - 1 && Coord.XtoColumn((int)x.posX) <= col + 1
            && Coord.YtoRow((int)x.posY) >= row - 1 && Coord.YtoRow((int)x.posY) <= row + 1)
            .ForEach(x => x.GetComponent<CHealth>().Die());

            AssociatedGameObject.Inactive = true;
        }
    }
}