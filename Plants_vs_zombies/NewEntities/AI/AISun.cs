using PvZ.Components;
using PvZ.NewEntities.Components;

namespace PvZ.NewEntities.AI
{
    class AISun : AIBase
    {
        public AISun(GameObject go) : base(go)
        {
        }

        public override void DoIt()
        {
            SunEntity sunEntity = AssociatedGameObject as SunEntity; // Chuyển đổi đối tượng thành SunEntity

            // Dừng lại nếu vị trí Y của SunEntity nhỏ hơn hoặc bằng vị trí Y kết thúc
            if (AssociatedGameObject.posY <= sunEntity.EndingY)
            {
                AssociatedGameObject.GetComponent<CMoveable>().Stop(); // Dừng di chuyển
            }

            // Nếu SunEntity được nhấp chuột
            if (AssociatedGameObject.GetComponent<CClickable>().IsClicked)
            {
                AssociatedGameObject.Inactive = true; // Đánh dấu SunEntity là không hoạt động
                Global.dollar += 50; // Tăng số tiền lên 50
            }
        }
    }
}
