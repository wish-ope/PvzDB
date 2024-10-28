using System.Windows.Forms.VisualStyles;
using PvZ.Components;
using PvZ.NewEntities.Components;

namespace PvZ.NewEntities.AI
{
    class AIMeower : AIBase
    {
        public AIMeower(GameObject go) : base(go)
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
                AssociatedGameObject.GetComponent<CMoveable>().Speed = new  System.Drawing.Point(180,0);
            }
        }

    }
}
