using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities.Components;
using PvZ.Components;

namespace PvZ.NewEntities.AI
{
    class AICherry : AIBase
    {
        int startRound; // Biến lưu trữ số vòng chơi bắt đầu

        // Hàm khởi tạo cho lớp AICherry, nhận một đối tượng GameObject
        public AICherry(GameObject go) : base(go)
        {
            startRound = Global.Round; // Gán số vòng chơi hiện tại cho biến startRound
        }

        // Phương thức thực hiện hành động AI
        public override void DoIt()
        {
            // Kiểm tra xem số vòng chơi hiện tại đã vượt quá số vòng bắt đầu + 80 chưa
            if (Global.Round >= (startRound + 80))
            {
                Explode(); // Nếu đã vượt quá, gọi phương thức Explode
            }
        }

        // Phương thức để xử lý sự kiện nổ
        public void Explode()
        {
            // Lấy cột và hàng của đối tượng liên kết
            int col = Coord.XtoColumn((int)AssociatedGameObject.posX);
            int row = Coord.YtoRow((int)AssociatedGameObject.posY);

            // Tìm tất cả các Zombie trong vùng ảnh hưởng của Cherry
            Global.Entities.FindAll(x => x.GetComponent<CHealth>() != null && x.Tags.Contains("Zombie")
            && Coord.XtoColumn((int)x.posX) >= col - 1 && Coord.XtoColumn((int)x.posX) <= col + 1
            && Coord.YtoRow((int)x.posY) >= row - 1 && Coord.YtoRow((int)x.posY) <= row + 1)
            .ForEach(x => x.GetComponent<CHealth>().Die()); // Gọi phương thức Die để tiêu diệt Zombie

            AssociatedGameObject.Inactive = true; // Đánh dấu đối tượng Cherry là không hoạt động
        }
    }
}
