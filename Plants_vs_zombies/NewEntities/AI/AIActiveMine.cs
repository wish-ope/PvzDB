using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AIActiveMine : AIBase
    {
        public AIActiveMine(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            GameObject foundZombie = Global.Entities.FindAll(x => x.Tags.Contains("Zombie")).Find(zombie =>
                AssociatedGameObject.posX <= zombie.posX + zombie.GetComponent<CDrawable>().HitBox.Width &&
                AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= zombie.posX &&
                AssociatedGameObject.CorrectedY <= zombie.CorrectedY + zombie.GetComponent<CDrawable>().HitBox.Height &&
                AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= zombie.CorrectedY);

            if (foundZombie != null)
            {
                foundZombie.GetComponent<CHealth>().Die();
                AssociatedGameObject.GetComponent<CHealth>().Die();
            }
        }
    }
}