using PvZ.Components;
using PvZ.NewEntities.Components;

namespace PvZ.NewEntities.AI
{
    class AISunflower : AIBase
    {
        int startRound;
        public AISunflower(GameObject go) : base(go)
        {
            startRound = Global.Round;
        }

        public override void DoIt()
        {
            if ((startRound + 80 <= Global.Round))
            {
                startRound = Global.Round;
                SunEntity sun = new SunEntity((int)AssociatedGameObject.posX + 10, (int)AssociatedGameObject.posY + 40, (int)AssociatedGameObject.posY);
                Global.Entities.Add(sun);
            }
        }
    }
}
