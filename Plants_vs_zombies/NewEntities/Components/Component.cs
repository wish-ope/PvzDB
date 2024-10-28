using PvZ.NewEntities;
using System;

namespace PvZ.Components
{
    public class Component : ICloneable
    {
        public GameObject Parent { get; set; } // Đối tượng cha của component

        // Phương thức cập nhật đối tượng, có thể được ghi đè
        public virtual void Update() { }

        // Phương thức sao chép đối tượng
        public object Clone()
        {
            return this.MemberwiseClone(); // Thực hiện sao chép nông
        }
    }
}
