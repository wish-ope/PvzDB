using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CHealth : Component
    {
        // Points de vie.
        private int initialHP;
        public int HP { get; set; }

        public override void Update()
        {
            if (!isAlive)
                Parent.Inactive = true;

            if (HasBeenHit)
                HasBeenHit = false;
        }
        public int InitialHP
        {
            get
            {
                return initialHP;
            }
            set
            {
                HP = value;
                initialHP = value;
            }
        }
        public void Die() { HP = 0; }

        public bool isAlive {
            get {
                if (HP <= 0)
                    return false;
                else return true;
            }
        }

        public bool HasBeenHit { get; internal set; }

        public void GetDamage(int damage)
        {
            HP -= damage;
            HasBeenHit = true;
        }


    }
}
