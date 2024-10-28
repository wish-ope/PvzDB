using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AIMine : AIBase
    {
        int begin;

        public AIMine(GameObject go) : base(go)
        {
            begin = Global.Round; // Ghi nhận vòng chơi bắt đầu
        }

        public override void DoIt()
        {
            // Kiểm tra thời gian kích hoạt mìn
            if (Global.Round == (begin + 250))
            {
                // Thay đổi hình ảnh và kích hoạt AIActiveMine
                AssociatedGameObject.GetComponent<CDrawable>().cycle = 1;
                AssociatedGameObject.GetComponent<CDrawable>().HitBox = new Size(24, 24);
                AssociatedGameObject.offsetX += 18; // Cập nhật vị trí mìn
                AssociatedGameObject.offsetY += 5;
                AssociatedGameObject.AI = new AIActiveMine(AssociatedGameObject); // Gán AI mới
            }
        }
    }
}