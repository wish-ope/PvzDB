using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace PvZ
{
    class _Sprite
    {
        float _zoom = 1;        // Tỉ lệ phóng đại của sprite
        Bitmap _Bitmap;         // Hình ảnh bitmap của sprite

        // Constructor nhận vào bitmap và tỉ lệ phóng đại
        public _Sprite(Bitmap B, float zoom)
        {
            _Bitmap = B;                         // Gán bitmap
            _zoom = zoom;                        // Gán tỉ lệ phóng đại
            // Mỗi pixel đen sẽ trở thành trong suốt
            _Bitmap.MakeTransparent(Color.FromArgb(0, 0, 0));
        }

        // Phương thức để vẽ sprite lên màn hình
        public void DrawToScreen(float x, float y)
        {
            int xx = (int)x;                       // Chuyển đổi x sang int
            int yy = (int)(Global.Height - y - _Bitmap.Height); // Tính toán vị trí y

            int H = (int)(_Bitmap.Height * _zoom); // Tính chiều cao sau khi phóng đại
            int L = (int)(_Bitmap.Width * _zoom);  // Tính chiều rộng sau khi phóng đại

            // Vẽ hình ảnh lên màn hình
            Global.Ecran.DrawImage(_Bitmap, xx, yy, L, H);
        }

        // Phương thức để lấy vị trí y sau khi tính toán
        public float GetY(float y)
        {
            return (int)(Global.Height - y - _Bitmap.Height);
        }
    }
}
