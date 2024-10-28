using PvZ.Components;
using PvZ.NewEntities.AI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.NewEntities
{
    public class GameObject
    {
        public AIBase AI;
        public List<Component> Components = new List<Component>();
        public List<String> Tags = new List<string>();
        public int Layer = 0;
        public bool Inactive;
        public float posX, posY, offsetX, offsetY;     // position

        public float CorrectedY
        {
            get { return (Global.Height - posY - GetComponent<CDrawable>().HitBox.Height) - offsetY; }
        }
        
        public void Update()
        {
            if (AI != null)
                AI.DoIt();

            foreach (Component component in Components)
            {
                component.Update();
            }
        }
        public Component AddComponent(Component c)
        {
            c.Parent = this;
            Components.Add(c);
            return c;
        }
        public T GetComponent<T>()
        {
            if (Components.OfType<T>().Any())
            {
                return Components.OfType<T>().ToArray()[0];
            }
            return default(T);
        }


        /// <summary>
        /// Duplicates this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Duplicate<T>() where T : GameObject, new()
        {
            T result = new T();

            result.AI = AI.Clone() as AIBase;
            result.posX = posX;
            result.posY = posY;
            result.offsetX = offsetX;
            result.offsetY = offsetY;

            foreach (Component c in Components)
            {
                result.AddComponent(c.Clone() as Component);
            }

            return result;
        }
    }
}
