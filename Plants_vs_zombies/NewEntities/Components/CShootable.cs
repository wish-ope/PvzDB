using PvZ.NewEntities;
using System.Collections.Generic;

namespace PvZ.Components
{
    class CShootable :  Component
    {
        // Vitesse de tir.
        public int ShootSpeed { get; set; }
        // Dégats par tir.
        public int ShootDamage { get; set; }
        // Double tir ?
        public bool DoubleShoot { get; set; }

        public string PeaType { get; set; }

        public override void Update()
        {
            if (Parent.AI.AIState == "Shooting")
            {
                if (Global.Round % 20 == 0)
                {
                    Shoot();
                }
                if (Global.Round % 20 == 3 && DoubleShoot)
                {
                    Shoot();
                }
            }
        }
        public void Shoot()
        {
            int offsetX = 48;
            int offsetY;
            PeaEntity sp;
            
            if (Parent.Tags.Contains("SnowPea"))
            { 
                
                offsetY = 65;
                sp = new PeaEntity(Parent.posX + offsetX, Parent.posY + offsetY, ShootSpeed, ShootDamage);
                sp.Tags.Add("SnowPea");
                sp.GetComponent<CDrawable>().Sprites = new List<string> { "tir_gel" };
            }
            else
            {
                offsetY = 51;
                sp = new PeaEntity(Parent.posX + offsetX, Parent.posY + offsetY, ShootSpeed, ShootDamage);
                sp.GetComponent<CDrawable>().Sprites = new List<string> { "tir_pois" };
            }

            Global.Entities.Add(sp);
        }
    }
}
