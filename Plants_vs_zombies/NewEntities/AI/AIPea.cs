using PvZ.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.NewEntities.AI
{
    class AIPea : AIBase
    {
        public AIPea(GameObject go) : base(go) // Khởi tạo đối tượng AIPea
        {
        }

        public override void DoIt()
        {
            // Tìm zombie trong phạm vi tấn công của cây đậu
            GameObject foundZombie = Global.Entities.FindAll(x => x.Tags.Contains("Zombie")).Find(zombie =>
            AssociatedGameObject.posX <= zombie.posX + zombie.GetComponent<CDrawable>().HitBox.Width &&
            AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= zombie.posX &&
            AssociatedGameObject.CorrectedY <= zombie.CorrectedY + zombie.GetComponent<CDrawable>().HitBox.Height &&
            AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= zombie.CorrectedY);

            if (foundZombie != null) // Nếu tìm thấy zombie
            {
                AssociatedGameObject.GetComponent<CHealth>().GetDamage(1); // Gây sát thương cho cây đậu

                CMoveable zombieMove = foundZombie.GetComponent<CMoveable>(); // Lấy thành phần di chuyển của zombie
                // Nếu là Snow Pea và zombie chưa bị giảm tốc độ
                if (AssociatedGameObject.Tags.Contains("SnowPea") && zombieMove.Speed == zombieMove.InitialSpeed)
                {
                    foundZombie.GetComponent<CDrawable>().Effect = "gel"; // Áp dụng hiệu ứng "đông lạnh"

                    zombieMove.Speed = new Point(-5, 0); // Giảm tốc độ di chuyển của zombie
                }
                foundZombie.GetComponent<CHealth>().GetDamage(15); // Gây sát thương cho zombie
            }
        }
    }
}

