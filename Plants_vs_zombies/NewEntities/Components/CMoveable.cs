using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CMoveable : Component
    {

        public bool HasStopped { get; set; }
        public Point Speed { get; set; }

        private Point _initialSpeed;
        public Point InitialSpeed { get { return _initialSpeed; }
                                    set { this._initialSpeed = value; Speed = value; } }
        public bool isOutBound
        {
            get
            {
                return Parent.posX > Coord.GetXBordDroitEcran() ? true : false;
            }
        }
        public override void Update()
        {
            Move(Speed.X, Speed.Y);
        }

        public void Move(float x, float y)
        {
            Parent.posX += (int)(x * Global.DeltaTime);
            Parent.posY += (int)(y * Global.DeltaTime);
        }

        public void Stop()
        {
            HasStopped = true;
            Speed = new Point(0,0);
        }

        public void Resume()
        {
            if (HasStopped)
            {
                Speed = InitialSpeed;
                HasStopped = false;
            }
            
        }

    }
}
