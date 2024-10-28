using PvZ.NewEntities.AI;

namespace PvZ.NewEntities
{
    class SpawnerEntity : GameObject
    {
        public SpawnerEntity()
        {
            AI = new AISpawner(this);
        }
    }
}
