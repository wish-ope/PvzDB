using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PvZ.NewEntities.AI
{
    public class AIBase : ICloneable
    {
        // Trạng thái AI, có thể là "None" hoặc các giá trị khác trong tương lai
        public string AIState { get; protected set; }
        // Đối tượng GameObject liên kết với AI
        public GameObject AssociatedGameObject { get; private set; }

        // Hàm khởi tạo cho lớp AIBase, nhận một đối tượng GameObject
        public AIBase(GameObject go)
        {
            AIState = "None"; // Khởi tạo trạng thái AI là "None"
            this.AssociatedGameObject = go; // Gán đối tượng GameObject cho AI
        }

        // Phương thức virtual để thực hiện hành động AI, có thể được ghi đè trong lớp con
        public virtual void DoIt() { }

        // Phương thức Clone để tạo bản sao của đối tượng AIBase
        public object Clone()
        {
            return this.MemberwiseClone(); // Tạo bản sao nông (shallow copy) của đối tượng
        }
    }
}
