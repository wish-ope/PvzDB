using PvZ.NewEntities;
using PvZ.NewEntities.AI;
using System.Collections.Generic;
using System.Drawing;

namespace PvZ.Components
{
    class ZombieEntity : GameObject
    {
        CDrawable drawable;
        CMoveable moveable;
        CHealth health;

        public ZombieEntity() { }
        public ZombieEntity(int row, Global.Creature zombieType)
        {
            Layer = 2;
            Tags.Add("Zombie");
            AI = new AIZombie(this);

            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            moveable.InitialSpeed = new Point(-20,0);

            drawable.HitBox = new Size(50, 94);
            drawable.Sprites = new List<string> { "zombie_1", "zombie_2", "zombie_3", "zombie_2" };
            drawable.Animated = true;
            drawable.HitAnimation = true;
            switch(zombieType)
            {
                case (Global.Creature.ZombieCone):
                    health.InitialHP = 250;
                    drawable.Accessory = "cone_1";
                    break;
                case (Global.Creature.ZombieSot):
                    health.InitialHP = 500;
                    drawable.Accessory = "sot_1";
                    break;
                default:
                    health.InitialHP = 150;
                    break;
            }

            posX = Coord.GetXBordDroitEcran();
            posY = Coord.RowToY(row);
        }

        public static Global.Creature RandomZombie()
        {
            switch (Global.Random(0, 2))
            {
                case 1:
                    return Global.Creature.ZombieSot;
                case 2:
                    return Global.Creature.ZombieCone;
                default:
                    return Global.Creature.Zombie;
            }
        }
    }
}
