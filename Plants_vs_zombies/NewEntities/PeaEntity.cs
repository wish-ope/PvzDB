using PvZ.Components;
using PvZ.NewEntities.AI;

namespace PvZ.NewEntities
{
    class PeaEntity : GameObject
    {
        private CHealth health;
        private CMoveable moveable;
        private CDrawable drawable;

        public PeaEntity(float posX, float posY, double ShootSpeed, int shootDamage)
        {
            AI = new AIPea(this);
            Layer = 3;
            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            moveable.Speed = new System.Drawing.Point((int)ShootSpeed, 0);
            health.InitialHP = 1;

            this.posX = posX;
            this.posY = posY;

            drawable.HitBox = new System.Drawing.Size(20, 20);
        }
        
    }
}
