using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities;
using PvZ.NewEntities.AI;

namespace PvZ.Components
{
    class PlantEntity : GameObject
    {
        CDrawable drawable; // Component hiển thị đồ họa
        CMoveable moveable; // Component điều khiển di chuyển
        CHealth health; // Component quản lý sức khỏe

        // Constructor để khởi tạo PlantEntity với tọa độ, loại cây
        public PlantEntity(int col, int row, Global.Creature plantType)
        {
            Layer = 1; // Đặt lớp của đối tượng
            Tags.Add("Plant"); // Gán tag cho đối tượng
            AI = new AIPlant(this); // Gán AI cho đối tượng

            // Thêm và khởi tạo các component cần thiết
            drawable = AddComponent(new CDrawable()) as CDrawable;
            moveable = AddComponent(new CMoveable()) as CMoveable;
            health = AddComponent(new CHealth()) as CHealth;

            drawable.HitBox = new System.Drawing.Size(56, 55); // Kích thước hitbox
            posX = Coord.ColToX(col); // Đặt tọa độ X dựa trên cột
            posY = Coord.RowToY(row); // Đặt tọa độ Y dựa trên hàng

            // Xử lý loại cây và thiết lập các thuộc tính tương ứng
            switch (plantType)
            {
                case Global.Creature.Tournesol: // Cây hướng dương
                    AI = new AISunflower(this);
                    health.InitialHP = 100; // Sức khỏe
                    drawable.Sprites = new List<string> { "plante_soleil" }; // Hình ảnh
                    break;

                case Global.Creature.PistoPois: // Cây bắn đậu
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "plante_pois" };
                    AddComponent(new CShootable()); // Thêm khả năng bắn
                    GetComponent<CShootable>().ShootSpeed = 300; // Tốc độ bắn
                    GetComponent<CShootable>().ShootDamage = 15; // Sát thương
                    break;

                case Global.Creature.Mine: // Mìn
                    health.InitialHP = 100;
                    AI = new AIMine(this);
                    drawable.Sprites = new List<string> { "mine_2", "mine_1" };
                    break;

                case Global.Creature.Noix: // Quả óc chó
                    AI = new AINut(this);
                    drawable.Sprites = new List<string> { "noix_1", "noix_2", "noix_3" };
                    health.InitialHP = 2000; // Sức khỏe cao
                    break;

                case Global.Creature.DoublePistoPois: // Cây bắn đậu đôi
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "plante_pois_double" };
                    AddComponent(new CShootable()); // Thêm khả năng bắn
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDamage = 15;
                    GetComponent<CShootable>().DoubleShoot = true; // Bắn đôi
                    break;

                case Global.Creature.PistoGel: // Cây bắn đậu đông lạnh
                    Tags.Add("SnowPea"); // Thêm tag
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "plante_gel" };
                    AddComponent(new CShootable()); // Thêm khả năng bắn
                    GetComponent<CShootable>().ShootSpeed = 300;
                    GetComponent<CShootable>().ShootDamage = 15;
                    break;

                case Global.Creature.Cerises: // Cây anh đào
                    AI = new AICherry(this);
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "cerises" };
                    break;

                case Global.Creature.Canon: // Cây súng đại bác
                    health.InitialHP = 100;
                    drawable.Sprites = new List<string> { "canon" };
                    break;
            }

            // Thiết lập offset cho hiển thị
            offsetX = 15;
            offsetY = 25;
        }
    }
}
