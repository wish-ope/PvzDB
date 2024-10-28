using System.Windows.Forms.VisualStyles; // Thư viện cho giao diện người dùng
using PvZ.Components; // Thư viện chứa các thành phần của trò chơi
using PvZ.NewEntities.Components; // Thư viện chứa các thành phần mới cho các thực thể trong trò chơi

namespace PvZ.NewEntities.AI
{
    class AIMeower : AIBase // Lớp AIMeower kế thừa từ lớp AIBase
    {
        // Hàm khởi tạo cho lớp AIMeower, nhận một đối tượng GameObject
        public AIMeower(GameObject go) : base(go)
        {

        }

        // Phương thức thực hiện hành động AI
        public override void DoIt()
        {
            // Tìm một Zombie trong danh sách các thực thể
            GameObject foundZombie = Global.Entities.FindAll(x => x.Tags.Contains("Zombie")).Find(zombie =>
                // Kiểm tra xem Zombie có nằm trong vùng ảnh hưởng của Meower không
                AssociatedGameObject.posX <= zombie.posX + zombie.GetComponent<CDrawable>().HitBox.Width &&
                AssociatedGameObject.posX + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Width >= zombie.posX &&
                AssociatedGameObject.CorrectedY <= zombie.CorrectedY + zombie.GetComponent<CDrawable>().HitBox.Height &&
                AssociatedGameObject.CorrectedY + AssociatedGameObject.GetComponent<CDrawable>().HitBox.Height >= zombie.CorrectedY);

            // Nếu tìm thấy Zombie
            if (foundZombie != null)
            {
                foundZombie.GetComponent<CHealth>().Die(); // Tiêu diệt Zombie
                AssociatedGameObject.GetComponent<CMoveable>().Speed = new System.Drawing.Point(180, 0); // Đặt tốc độ của Meower
            }
        }

    }
}
