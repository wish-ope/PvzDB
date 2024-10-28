using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities;
using PvZ.NewEntities.AI;

namespace PvZ.Components
{
    class PlantEntity : GameObject
    {
        CDrawable drawable;
        CMoveable moveable;
        CHealth health;

        public PlantEntity(int col, int row,  Global.Creature plantType)
        {
            Layer = 1;
            Tags.Add("Plant");
            AI = new AIPlant(this);
            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            drawable.HitBox = new System.Drawing.Size(56, 55);
            posX = Coord.ColToX(col);
            posY = Coord.RowToY(row);

            switch (plantType)
            {
                case Global.Creature.Tournesol:
                    AI = new AISunflower(this);
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "plante_soleil" };
                    break;
                case Global.Creature.PistoPois:
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "plante_pois" };
                    AddComponent(new CShootable());
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDamage = 15;
                    break;
                case Global.Creature.Mine:
                    health.InitialHP = 100;
                    AI = new AIMine(this);
                    drawable.Sprites = new List<string> { "mine_2", "mine_1" };
                    break;
                case Global.Creature.Noix:
                    AI = new AINut(this);
                    drawable.Sprites = new List<string> { "noix_1", "noix_2", "noix_3" };
                    health.InitialHP = 2000;
                    break;
                case Global.Creature.DoublePistoPois:
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "plante_pois_double" };
                    AddComponent(new CShootable());
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDamage = 15;
                    GetComponent<CShootable>().DoubleShoot = true;
                    break;
                case Global.Creature.PistoGel:
                    Tags.Add("SnowPea");
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "plante_gel" };
                    AddComponent(new CShootable());
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDamage = 15;
                    break;
                case Global.Creature.Cerises:
                    AI = new AICherry(this);
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "cerises" };
                    break;
                case Global.Creature.Canon:
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "canon" };
                    break;
            }


            offsetX = 15;
            offsetY = 25;
        }

        
    }
}
