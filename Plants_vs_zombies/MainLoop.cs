using PvZ.Components;  // Thư viện cho các thành phần của game
using PvZ.NewEntities; // Thư viện cho các thực thể mới
using System.Linq;     // Để sử dụng LINQ cho việc truy vấn danh sách

namespace PvZ
{
    class MainLoop
    {
        // Phương thức chính để cập nhật trạng thái của game
        public static void DoIt()
        {
            // Xóa các GameObject đã chết (không hoạt động)
            Global.Entities.RemoveAll(x => x.Inactive);

            // Cập nhật tất cả các GameObject còn sống
            for (int i = 0; i < Global.Entities.ToArray().Length; i++)
            {
                Global.Entities[i].Update();
            }
        }

        // Phương thức để hiển thị các đối tượng trên màn hình
        public static void Affichage()
        {
            // Sắp xếp các GameObject theo Layer và vẽ chúng
            foreach (GameObject go in Global.Entities.OrderBy(x => x.Layer))
            {
                CDrawable drawable = go.GetComponent<CDrawable>(); // Lấy thành phần có thể vẽ
                if (drawable != null) // Nếu có thành phần vẽ
                {
                    drawable.Draw(); // Gọi phương thức Draw để vẽ
                }
            }

            DebugMode.Update(); // Cập nhật chế độ gỡ lỗi (nếu có)
        }
    }
}
