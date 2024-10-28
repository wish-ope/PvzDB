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
        public AIBase AI;  // AI điều khiển đối tượng
        public List<Component> Components = new List<Component>(); // Danh sách các component của đối tượng
        public List<String> Tags = new List<string>(); // Danh sách các tag để phân loại đối tượng
        public int Layer = 0; // Lớp của đối tượng trong hệ thống
        public bool Inactive; // Trạng thái hoạt động của đối tượng
        public float posX, posY, offsetX, offsetY; // Vị trí của đối tượng

        // Tính toán tọa độ Y đã chỉnh sửa dựa trên chiều cao của hitbox
        public float CorrectedY
        {
            get { return (Global.Height - posY - GetComponent<CDrawable>().HitBox.Height) - offsetY; }
        }

        // Cập nhật đối tượng
        public void Update()
        {
            // Thực hiện hành động AI nếu có
            if (AI != null)
                AI.DoIt();

            // Cập nhật tất cả các component
            foreach (Component component in Components)
            {
                component.Update();
            }
        }

        // Thêm một component mới vào đối tượng
        public Component AddComponent(Component c)
        {
            c.Parent = this; // Thiết lập cha cho component
            Components.Add(c); // Thêm vào danh sách components
            return c; // Trả về component đã thêm
        }

        // Lấy component theo kiểu cụ thể
        public T GetComponent<T>()
        {
            if (Components.OfType<T>().Any())
            {
                return Components.OfType<T>().ToArray()[0]; // Trả về component đầu tiên tìm thấy
            }
            return default(T); // Trả về giá trị mặc định nếu không tìm thấy
        }

        /// <summary>
        /// Duplicates this instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public T Duplicate<T>() where T : GameObject, new()
        {
            T result = new T(); // Tạo một đối tượng mới

            result.AI = AI.Clone() as AIBase; // Nhân bản AI
            result.posX = posX; // Nhân bản tọa độ X
            result.posY = posY; // Nhân bản tọa độ Y
            result.offsetX = offsetX; // Nhân bản offset X
            result.offsetY = offsetY; // Nhân bản offset Y

            // Nhân bản tất cả các component
            foreach (Component c in Components)
            {
                result.AddComponent(c.Clone() as Component); // Nhân bản từng component và thêm vào đối tượng mới
            }

            return result; // Trả về đối tượng đã nhân bản
        }
    }
}
