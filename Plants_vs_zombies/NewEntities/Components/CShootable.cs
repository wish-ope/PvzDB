using PvZ.NewEntities;
using System.Collections.Generic;

namespace PvZ.Components
{
    class CShootable : Component
    {
        // Vitesse de tir.
        public int ShootSpeed { get; set; } // Tốc độ bắn
        // Dégats par tir.
        public int ShootDamage { get; set; } // Sát thương mỗi lần bắn
        // Double tir ?
        public bool DoubleShoot { get; set; } // Kiểm tra bắn đôi

        public string PeaType { get; set; } // Loại đậu

        public override void Update()
        {
            // Kiểm tra trạng thái AI và thực hiện bắn
            if (Parent.AI.AIState == "Shooting")
            {
                // Thực hiện bắn mỗi 20 vòng
                if (Global.Round % 20 == 0)
                {
                    Shoot();
                }
                // Thực hiện bắn đôi nếu đủ điều kiện
                if (Global.Round % 20 == 3 && DoubleShoot)
                {
                    Shoot();
                }
            }
        }

        public void Shoot()
        {
            int offsetX = 48; // Độ dịch chuyển theo trục X
            int offsetY; // Độ dịch chuyển theo trục Y
            PeaEntity sp; // Đối tượng bắn ra

            // Kiểm tra loại đậu để quyết định hành động
            if (Parent.Tags.Contains("SnowPea"))
            {
                offsetY = 65; // Đối với SnowPea
                sp = new PeaEntity(Parent.posX + offsetX, Parent.posY + offsetY, ShootSpeed, ShootDamage);
                sp.Tags.Add("SnowPea"); // Gán tag cho SnowPea
                sp.GetComponent<CDrawable>().Sprites = new List<string> { "tir_gel" }; // Thiết lập sprite cho SnowPea
            }
            else
            {
                offsetY = 51; // Đối với loại đậu khác
                sp = new PeaEntity(Parent.posX + offsetX, Parent.posY + offsetY, ShootSpeed, ShootDamage);
                sp.GetComponent<CDrawable>().Sprites = new List<string> { "tir_pois" }; // Thiết lập sprite cho loại đậu khác
            }

            Global.Entities.Add(sp); // Thêm đạn vào danh sách đối tượng
        }
    }
}
