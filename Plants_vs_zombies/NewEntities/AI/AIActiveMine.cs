using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AIActiveMine : AIBase
    {
        public AIActiveMine(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            // Tìm kiếm tất cả các Zombie trong danh sách đối tượng
            GameObject foundZombie = Global.Entities.FindAll(x => x.Tags.Contains("Zombie")).Find(zombie =>
                AssociatedGameObject.posX <= zombie.posX + zombie.GetComponent<CDrawable>().HitBox.Width &&
                AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= zombie.posX &&
                AssociatedGameObject.CorrectedY <= zombie.CorrectedY + zombie.GetComponent<CDrawable>().HitBox.Height &&
                AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= zombie.CorrectedY);

            // Nếu tìm thấy Zombie
            if (foundZombie != null)
            {
                // Xử lý Zombie bị tiêu diệt
                foundZombie.GetComponent<CHealth>().Die();
                // Xử lý mìn cũng bị tiêu diệt
                AssociatedGameObject.GetComponent<CHealth>().Die();
            }
        }
    }
}
