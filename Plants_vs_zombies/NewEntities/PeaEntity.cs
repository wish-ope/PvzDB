using PvZ.Components;
using PvZ.NewEntities.AI;

namespace PvZ.NewEntities
{
    class PeaEntity : GameObject
    {
        private CHealth health; // Component quản lý sức khỏe
        private CMoveable moveable; // Component điều khiển di chuyển
        private CDrawable drawable; // Component hiển thị đồ họa

        // Constructor để khởi tạo PeaEntity với tọa độ, tốc độ bắn và sát thương
        public PeaEntity(float posX, float posY, double ShootSpeed, int shootDamage)
        {
            AI = new AIPea(this); // Gán AI cho đối tượng
            Layer = 3; // Đặt lớp của đối tượng

            // Thêm và khởi tạo các component cần thiết
            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            // Thiết lập tốc độ di chuyển và sức khỏe ban đầu
            moveable.Speed = new System.Drawing.Point((int)ShootSpeed, 0); // Tốc độ bắn
            health.InitialHP = 1; // Đặt sức khỏe ban đầu

            this.posX = posX; // Đặt tọa độ X
            this.posY = posY; // Đặt tọa độ Y

            // Thiết lập kích thước hitbox cho drawable
            drawable.HitBox = new System.Drawing.Size(20, 20); // Kích thước hitbox
        }
    }
}
