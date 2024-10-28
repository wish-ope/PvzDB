using PvZ.NewEntities;
using PvZ.NewEntities.AI;
using System.Collections.Generic;
using System.Drawing;

namespace PvZ.Components
{
    class ZombieEntity : GameObject
    {
        CDrawable drawable; // Component hiển thị đồ họa
        CMoveable moveable; // Component điều khiển di chuyển
        CHealth health; // Component quản lý sức khỏe

        // Constructor mặc định
        public ZombieEntity() { }

        // Constructor để khởi tạo ZombieEntity với dòng và loại zombie
        public ZombieEntity(int row, Global.Creature zombieType)
        {
            Layer = 2; // Đặt lớp của đối tượng
            Tags.Add("Zombie"); // Gán tag cho đối tượng
            AI = new AIZombie(this); // Gán AI cho đối tượng

            // Thêm và khởi tạo các component cần thiết
            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            moveable.InitialSpeed = new Point(-20, 0); // Thiết lập tốc độ di chuyển sang trái

            // Thiết lập kích thước hitbox và hình ảnh
            drawable.HitBox = new Size(50, 94);
            drawable.Sprites = new List<string> { "zombie_1", "zombie_2", "zombie_3", "zombie_2" };
            drawable.Animated = true; // Kích hoạt animation
            drawable.HitAnimation = true; // Kích hoạt animation khi bị trúng

            // Thiết lập thông số cho từng loại zombie
            switch (zombieType)
            {
                case (Global.Creature.ZombieCone):
                    health.InitialHP = 250; // Sức khỏe cho ZombieCone
                    drawable.Accessory = "cone_1"; // Phụ kiện cho ZombieCone
                    break;
                case (Global.Creature.ZombieSot):
                    health.InitialHP = 500; // Sức khỏe cho ZombieSot
                    drawable.Accessory = "sot_1"; // Phụ kiện cho ZombieSot
                    break;
                default:
                    health.InitialHP = 150; // Sức khỏe mặc định cho zombie
                    break;
            }

            // Đặt tọa độ cho zombie
            posX = Coord.GetXBordDroitEcran(); // Lấy tọa độ X bên phải màn hình
            posY = Coord.RowToY(row); // Tính tọa độ Y dựa trên dòng
        }

        // Phương thức tạo zombie ngẫu nhiên
        public static Global.Creature RandomZombie()
        {
            switch (Global.Random(0, 2)) // Tạo số ngẫu nhiên từ 0 đến 2
            {
                case 1:
                    return Global.Creature.ZombieSot; // Trả về ZombieSot
                case 2:
                    return Global.Creature.ZombieCone; // Trả về ZombieCone
                default:
                    return Global.Creature.Zombie; // Trả về zombie mặc định
            }
        }
    }
}
