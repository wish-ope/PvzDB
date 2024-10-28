using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ.NewEntities.AI
{
    public class AIBase : ICloneable
    {
        public string AIState { get; protected set; }
        public GameObject AssociatedGameObject { get; private set; }

        public AIBase(GameObject go)
        {
            AIState = "None";
            this.AssociatedGameObject = go;
        }
        public virtual void DoIt() { }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
