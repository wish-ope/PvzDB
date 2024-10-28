using PvZ.Components;
using System.Collections.Generic;
using System.Drawing;
using System;
using PvZ.NewEntities.AI;

namespace PvZ.NewEntities
{
    class MeowerEntity : GameObject
    {
        CDrawable drawable; // Component hiển thị đồ họa
        CMoveable moveable; // Component điều khiển di chuyển

        public int EndingY; // Tọa độ Y mà MeowerEntity sẽ kết thúc di chuyển

        // Constructor để khởi tạo MeowerEntity với tọa độ cụ thể
        public MeowerEntity(int posX, int posY)
        {
            Layer = 4; // Đặt lớp của đối tượng
            AI = new AIMeower(this); // Gán AI cho đối tượng
            Tags.Add("Meower"); // Thêm tag "Meower"

            this.posX = posX; // Đặt tọa độ X
            this.posY = posY; // Đặt tọa độ Y

            // Thêm và khởi tạo các component cần thiết
            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;

            // Thiết lập hitbox và sprite cho drawable
            drawable.HitBox = new Size(55, 54); // Đặt kích thước hitbox
            drawable.Sprites = new List<string> { "tondeuse" }; // Gán sprite cho drawable
        }
    }
}
