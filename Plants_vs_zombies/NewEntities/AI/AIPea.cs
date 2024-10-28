using PvZ.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.NewEntities.AI
{
    class AIPea : AIBase
    {
        public AIPea(GameObject go) : base(go)
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
                AssociatedGameObject.GetComponent<CHealth>().GetDamage(1);

                CMoveable zombieMove = foundZombie.GetComponent<CMoveable>();
                if (AssociatedGameObject.Tags.Contains("SnowPea") && zombieMove.Speed == zombieMove.InitialSpeed)
                {
                    foundZombie.GetComponent<CDrawable>().Effect = "gel";

                    zombieMove.Speed = new Point(-5, 0);
                }
                foundZombie.GetComponent<CHealth>().GetDamage(15);
            }
        }

    }
}
