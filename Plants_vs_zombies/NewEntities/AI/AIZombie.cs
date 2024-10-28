using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AIZombie : AIBase
    {
        public AIZombie(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            GameObject foundPlant = Global.Entities.FindAll(x => x.Tags.Contains("Plant")).Find(plant => 
            AssociatedGameObject.posX <= plant.posX + plant.GetComponent<CDrawable>().HitBox.Width &&
            AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= plant.posX && 
            AssociatedGameObject.CorrectedY <= plant.CorrectedY + plant.GetComponent<CDrawable>().HitBox.Height &&
            AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= plant.CorrectedY);

            if (foundPlant != null)
            {
                AssociatedGameObject.GetComponent<CMoveable>().Stop();
                foundPlant.GetComponent<CHealth>().GetDamage(2);
            }
            else
            {
                AssociatedGameObject.GetComponent<CMoveable>().Resume();
            }

            if (AssociatedGameObject.posX <= 120 + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width)
            {
                Global.Entities.Clear();
                Global.stateofthegame = Global.GameState.Loose;
            }
        }
    }
}
