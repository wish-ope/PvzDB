using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CDrawable : Component
    {
        // Danh sách các sprite
        public List<String> Sprites { get; set; }
        public Size HitBox;      // HitBox để xác định vùng va chạm
        public bool HitAnimation { get; set; } // Biến xác định có hoạt ảnh khi bị va chạm hay không
        public bool Animated { get; set; } // Biến xác định có hoạt ảnh hay không
        public string Accessory { get; set; } // Phụ kiện của đối tượng
        public string Effect { get; set; } // Hiệu ứng của đối tượng

        private int num_aff; // Biến đếm số lần cập nhật
        public int cycle; // Chỉ số của sprite hiện tại

        // Phương thức cập nhật trạng thái của component
        public override void Update()
        {
            num_aff++; // Tăng số lần cập nhật
        }

        // Phương thức vẽ đối tượng lên màn hình
        public virtual void Draw()
        {
            // Vẽ hiệu ứng nếu có
            if (!string.IsNullOrEmpty(Effect))
            {
                Global.Sprites.Get(Effect).DrawToScreen((Parent.posX + 10), (Parent.posY - 8));
            }

            // Nếu đối tượng có hoạt ảnh
            if (Animated)
            {
                // Thay đổi sprite mỗi 20 lần vẽ
                cycle = (num_aff / 10) % Sprites.Count;
            }

            // Nếu đối tượng bị va chạm và có hoạt ảnh va chạm
            if (Parent.GetComponent<CHealth>() != null && Parent.GetComponent<CHealth>().HasBeenHit && HitAnimation)
            {
                Global.Sprites.Get(Sprites[cycle] + "_touche").DrawToScreen((Parent.posX + Parent.offsetX), (Parent.posY + Parent.offsetY));
            }
            else
            {
                // Vẽ sprite hiện tại
                Global.Sprites.Get(Sprites[cycle]).DrawToScreen((Parent.posX + Parent.offsetX), (Parent.posY + Parent.offsetY));
            }

            // Vẽ phụ kiện nếu có
            if (!string.IsNullOrEmpty(Accessory))
            {
                Global.Sprites.Get(Accessory).DrawToScreen((Parent.posX + 2), (Parent.posY + 80 + ((cycle % 2 == 0) ? 0 : 5)));
            }
        }
    }
}
