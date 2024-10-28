using PvZ.Components;
using System.Collections.Generic;
using System.Drawing;
using System;
using PvZ.NewEntities.AI;

namespace PvZ.NewEntities.Components
{
    class SunEntity : GameObject
    {
        CDrawable drawable; // Component hiển thị đồ họa
        CMoveable moveable; // Component điều khiển di chuyển

        public int EndingY; // Tọa độ Y kết thúc để xác định khi nào mặt trời sẽ biến mất

        // Constructor để khởi tạo SunEntity với tọa độ và tọa độ Y kết thúc
        public SunEntity(int posX, int posY, int endingY)
        {
            Layer = 3; // Đặt lớp của đối tượng
            AI = new AISun(this); // Gán AI cho đối tượng
            Tags.Add("Sun"); // Gán tag cho đối tượng

            // Đặt tọa độ ban đầu
            this.posX = posX;
            this.posY = posY;
            this.EndingY = endingY; // Thiết lập tọa độ Y kết thúc

            // Thêm và khởi tạo các component cần thiết
            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            AddComponent(new CClickable()); // Thêm khả năng click
            AddComponent(new CDisappear(500)); // Thêm khả năng biến mất sau 500 ms

            moveable.InitialSpeed = new Point(0, -50); // Thiết lập tốc độ di chuyển lên trên

            // Thiết lập kích thước hitbox và hình ảnh
            drawable.HitBox = new Size(55, 54);
            drawable.Sprites = new List<string> { "soleil" }; // Hình ảnh của mặt trời
        }
    }
}
