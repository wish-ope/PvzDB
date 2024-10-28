using PvZ.Components; // Thư viện cho các thành phần của game
using PvZ.NewEntities; // Thư viện cho các thực thể mới
using System; // Thư viện cơ bản
using System.Collections.Generic; // Thư viện cho danh sách

namespace PvZ
{
    class MouseClic
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        // Hàm xử lý sự kiện nhấp chuột
        // Các tọa độ được sử dụng là tọa độ Cartesian

        static public void Event(int x, int y)
        {
            // Chuyển đổi tọa độ Y thành hàng và tọa độ X thành cột
            int rangee = Coord.YtoRow(y);
            int col = Coord.XtoColumn(x);

            // Tìm tất cả GameObject có thể nhấp chuột trong vùng được nhấp
            List<GameObject> se = Global.Entities.FindAll(s => s.GetComponent<CClickable>() != null &&
                x <= s.posX + s.GetComponent<CDrawable>().HitBox.Width &&
                x >= s.posX &&
                y <= s.posY + s.GetComponent<CDrawable>().HitBox.Height &&
                y >= s.posY);

            // Đánh dấu các GameObject được nhấp
            se.ForEach(sunClicked => sunClicked.GetComponent<CClickable>().IsClicked = true);

            // Nếu có GameObject được nhấp
            if (se.Count != 0)
            {
                // Có thể thêm logic xử lý ở đây nếu cần
            }
            // Nếu không có GameObject nào được nhấp và người chơi đã chọn Zombie
            else if (Global.Button == Global.Creature.Zombie)
            {
                ZombieEntity ze = new ZombieEntity(rangee, Global.Creature.ZombieCone);

                // Nếu hàng trong khoảng cho phép, thêm Zombie vào danh sách
                if (rangee >= 0 && rangee < 5)
                    Global.Entities.Add(ze);
            }
            else
            {
                // Kiểm tra nếu nhấp vào khu vực hợp lệ cho cây trồng
                if (rangee >= 0 && col >= 0 && rangee < 5 && col < 9)
                {
                    // Tìm cây đã tồn tại trong hàng và cột tương ứng
                    GameObject FoundPlant = Global.Entities.FindAll(p => p.Tags.Contains("Plant"))
                        .Find(p => Coord.YtoRow((int)p.posY) == rangee && Coord.XtoColumn((int)p.posX) == col);

                    // Nếu người chơi đã chọn cái xẻng và tìm thấy cây, xóa cây
                    if (Global.Button == Global.Creature.Shovel && FoundPlant != null)
                    {
                        FoundPlant.Inactive = true; // Đánh dấu cây là không hoạt động
                    }
                    // Nếu không tìm thấy cây và đủ tiền để trồng cây mới
                    else if (FoundPlant == null && Global.SunCosts[Global.Button] <= Global.dollar)
                    {
                        PlantEntity pe = new PlantEntity(col, rangee, Global.Button); // Tạo cây mới
                        Global.Entities.Add(pe); // Thêm cây vào danh sách
                        Global.dollar -= Global.SunCosts[Global.Button]; // Trừ tiền
                        // Có thể thêm logic cooldown ở đây nếu cần
                    }
                }
            }
        }
    }
}
