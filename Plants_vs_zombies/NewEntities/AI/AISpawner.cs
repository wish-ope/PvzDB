using PvZ.Components;
using PvZ.NewEntities.Components;

namespace PvZ.NewEntities.AI
{
    class AISpawner : AIBase
    {
        public AISpawner(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            if (Global.Round % 80 == 0)
            {
                SunEntity sun = new SunEntity(Global.Random(300, 900), Coord.GetYBordHautEcran(), Global.Random(200, 500));
                Global.Entities.Add(sun);
            }
            if(Global.Round % 120 == 0)
            {
                ZombieEntity ze = new ZombieEntity(Global.Random(0, 4), ZombieEntity.RandomZombie());
                Global.Entities.Add(ze);
            }
        }
    }
}
