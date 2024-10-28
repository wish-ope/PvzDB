using PvZ.Components;
using PvZ.NewEntities.Components;

namespace PvZ.NewEntities.AI
{
    class AISunflower : AIBase
    {
        int startRound; // Lưu trữ vòng chơi bắt đầu

        public AISunflower(GameObject go) : base(go)
        {
            startRound = Global.Round; // Gán vòng chơi hiện tại cho startRound
        }

        public override void DoIt()
        {
            // Nếu đã đến thời điểm tạo SunEntity (sau 80 vòng)
            if ((startRound + 80 <= Global.Round))
            {
                startRound = Global.Round; // Cập nhật vòng chơi bắt đầu
                // Tạo một SunEntity mới với tọa độ phù hợp
                SunEntity sun = new SunEntity((int)AssociatedGameObject.posX + 10, (int)AssociatedGameObject.posY + 40, (int)AssociatedGameObject.posY);
                Global.Entities.Add(sun); // Thêm SunEntity vào danh sách đối tượng
            }
        }
    }
}
