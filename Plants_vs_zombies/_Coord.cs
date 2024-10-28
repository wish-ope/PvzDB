using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PvZ.NewEntities;

namespace PvZ
{
    class Coord
    {
        ///////////////////////////////////////////////////////////////////////////////////////
        //
        //      Phép chuyển đổi (x,y) từ tọa độ Cartesian của chuột sang số cột / hàng

        // Các ô trong trò chơi có chiều cao 100 pixel và chiều rộng 80 pixel.
        // Bảng 5x9 ô

        static int yRaw = 60;   // Chiều cao của hàng dưới cùng
        static int xStart = 250;  // Vị trí của cột đầu tiên bên trái
        static int xBordDroitEcran = 1024; // Độ rộng màn hình
        static int yBordHautEcran = 624;    // Chiều cao màn hình
        static int largeur_case = 80;        // Chiều rộng của ô
        static int hauteur_case = 100;       // Chiều cao của ô

        // Phương thức chuyển đổi tọa độ Y sang hàng
        public static int YtoRow(int y)
        {
            // Có 5 lối đi với chiều cao 100 pixels

            // Kiểm tra xem y có nằm ngoài phạm vi hàng không
            if ((y < yRaw) && (y >= yRaw + 5 * hauteur_case))
                return -1; // Trả về -1 nếu không hợp lệ

            // Các hàng có chiều cao 100 pixels
            return (y - yRaw) / hauteur_case; // Tính số hàng tương ứng
        }

        // Phương thức chuyển đổi tọa độ X sang cột
        public static int XtoColumn(int x)
        {
            // Có 9 cột với chiều rộng 80 pixels
            if ((x < xStart) || (x >= xStart + largeur_case * 9)) return -1; // Kiểm tra hợp lệ

            return (x - xStart) / largeur_case; // Tính số cột tương ứng
        }

        // Phương thức chuyển đổi số hàng sang tọa độ Y
        public static int RowToY(int row) { return row * hauteur_case + yRaw; }

        // Phương thức chuyển đổi số cột sang tọa độ X
        public static int ColToX(int col) { return col * largeur_case + xStart; }

        // Phương thức trả về tọa độ X bên phải màn hình
        public static int GetXBordDroitEcran() { return xBordDroitEcran; }

        // Phương thức trả về tọa độ Y phía trên màn hình
        public static int GetYBordHautEcran() { return yBordHautEcran; }

        // Phương thức kiểm tra va chạm (chưa triển khai)
        public static bool CheckCollisions(GameObject go)
        {
            return true; // Chưa thực hiện kiểm tra va chạm
        }
    }
}
