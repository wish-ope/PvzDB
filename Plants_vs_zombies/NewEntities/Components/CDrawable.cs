using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CDrawable : Component
    {
        // Liste des sprites.
        public List<String> Sprites { get; set; }
        public Size HitBox;      // HitBox
        public bool HitAnimation { get; set; }
        public bool Animated { get; set; }
        public string Accessory { get; set; }
        public string Effect { get; set; }

        private int num_aff;
        public int cycle;

        public override void Update()
        {
            num_aff++;
        }
        public virtual void Draw()
        {
            if (!string.IsNullOrEmpty(Effect))
            {
                Global.Sprites.Get(Effect).DrawToScreen((Parent.posX + 10), (Parent.posY - 8));
            }

            if (Animated)
            {
                // change de sprite tous les 20 affichages
                cycle = (num_aff / 10) % Sprites.Count;
            }

            if (Parent.GetComponent<CHealth>() != null && Parent.GetComponent<CHealth>().HasBeenHit && HitAnimation)
            {
                Global.Sprites.Get(Sprites[cycle] + "_touche").DrawToScreen((Parent.posX + Parent.offsetX), (Parent.posY + Parent.offsetY));
                //Parent.GetComponent<CHealth>().hasBeenHit
            }
            else
            {
                Global.Sprites.Get(Sprites[cycle]).DrawToScreen((Parent.posX + Parent.offsetX), (Parent.posY + Parent.offsetY));
            }


            if (!string.IsNullOrEmpty(Accessory))
            {
                Global.Sprites.Get(Accessory).DrawToScreen((Parent.posX + 2), (Parent.posY + 80 + ((cycle%2==0) ? 0 : 5)));
            }


        }
    }
}
