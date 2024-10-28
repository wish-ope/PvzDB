using PvZ.Components;
using System.Collections.Generic;
using System.Drawing;
using System;
using PvZ.NewEntities.AI;

namespace PvZ.NewEntities.Components
{
    class SunEntity : GameObject
    {
        CDrawable drawable;
        CMoveable moveable;

        public int EndingY;

        public SunEntity(int posX, int posY, int endingY)
        {
            Layer = 3;
            AI = new AISun(this);
            Tags.Add("Sun");

            this.posX = posX;
            this.posY = posY;
            this.EndingY = endingY;

            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            AddComponent(new CClickable());
            AddComponent(new CDisappear(500));

            moveable.InitialSpeed = new Point(0, -50);

            drawable.HitBox = new Size(55, 54);
            drawable.Sprites = new List<string> { "soleil" };
        }

    }
}
