using PvZ.NewEntities;
using System;

namespace PvZ.Components
{
    public class Component : ICloneable
    {
        public GameObject Parent { get; set; }

        public virtual void Update() { }  // met à jour les objets
        public object Clone()
        {
            return this.MemberwiseClone();
        }

    }
}
