using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AIZombie : AIBase
    {
        public AIZombie(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            // Tìm một cây trồng trong danh sách các đối tượng
            GameObject foundPlant = Global.Entities.FindAll(x => x.Tags.Contains("Plant")).Find(plant =>
            AssociatedGameObject.posX <= plant.posX + plant.GetComponent<CDrawable>().HitBox.Width &&
            AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= plant.posX &&
            AssociatedGameObject.CorrectedY <= plant.CorrectedY + plant.GetComponent<CDrawable>().HitBox.Height &&
            AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= plant.CorrectedY);

            if (foundPlant != null) // Nếu tìm thấy cây trồng
            {
                AssociatedGameObject.GetComponent<CMoveable>().Stop(); // Dừng lại
                foundPlant.GetComponent<CHealth>().GetDamage(2); // Gây 2 sát thương cho cây trồng
            }
            else
            {
                AssociatedGameObject.GetComponent<CMoveable>().Resume(); // Nếu không tìm thấy, tiếp tục di chuyển
            }

            // Kiểm tra nếu zombie đã vượt qua một ngưỡng nhất định
            if (AssociatedGameObject.posX <= 120 + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width)
            {
                Global.Entities.Clear(); // Xóa tất cả các đối tượng
                Global.stateofthegame = Global.GameState.Loose; // Thay đổi trạng thái trò chơi thành "thua"
            }
        }
    }
}
