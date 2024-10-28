using PvZ.Components;
using PvZ.NewEntities.Components;

namespace PvZ.NewEntities.AI
{
    class AISun : AIBase
    {
        public AISun(GameObject go) : base(go)
        {
            
        }

        public override void DoIt()
        {
            SunEntity sunEntity = AssociatedGameObject as SunEntity;
            if (AssociatedGameObject.posY <= sunEntity.EndingY)
            {
                AssociatedGameObject.GetComponent<CMoveable>().Stop();
            }
            if (AssociatedGameObject.GetComponent<CClickable>().IsClicked)
            {
                AssociatedGameObject.Inactive = true;
                Global.dollar += 50;       
            }
        }

    }
}
