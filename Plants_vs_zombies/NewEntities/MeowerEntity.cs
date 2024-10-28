using PvZ.Components;
using System.Collections.Generic;
using System.Drawing;
using System;
using PvZ.NewEntities.AI;

namespace PvZ.NewEntities
{
    class MeowerEntity : GameObject
    {
        CDrawable drawable;
        CMoveable moveable;

        public int EndingY;

        public MeowerEntity(int posX, int posY)
        {
            Layer = 4;
            AI = new AIMeower(this);
            Tags.Add("Meower");

            this.posX = posX;
            this.posY = posY;

            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;

            drawable.HitBox = new Size(55, 54);
            drawable.Sprites = new List<string> { "tondeuse" };
        }

    }
}
