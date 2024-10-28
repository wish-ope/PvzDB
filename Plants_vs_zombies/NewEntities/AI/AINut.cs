using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AINut : AIBase
    {
        public AINut(GameObject go) : base(go) // Khởi tạo đối tượng AINut
        {
        }

        public override void DoIt()
        {
            CHealth health = AssociatedGameObject.GetComponent<CHealth>(); // Lấy thành phần sức khỏe của đối tượng
            CDrawable nutDraw = AssociatedGameObject.GetComponent<CDrawable>(); // Lấy thành phần hình ảnh của đối tượng

            // Thay đổi chu kỳ hình ảnh dựa trên HP hiện tại
            if (health.HP > 1333)
                nutDraw.cycle = 0; // Hình ảnh khi HP > 1333
            else if (health.HP < 1332 && health.HP > 666)
                nutDraw.cycle = 1; // Hình ảnh khi HP trong khoảng (666, 1332)
            else
                nutDraw.cycle = 2; // Hình ảnh khi HP ≤ 666
        }
    }
}