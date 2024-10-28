using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CMoveable : Component
    {
        public bool HasStopped { get; set; } // Kiểm tra trạng thái dừng
        public Point Speed { get; set; } // Tốc độ di chuyển

        private Point _initialSpeed; // Tốc độ ban đầu
        public Point InitialSpeed
        {
            get { return _initialSpeed; }
            set
            {
                this._initialSpeed = value;
                Speed = value; // Cập nhật tốc độ khi thiết lập tốc độ ban đầu
            }
        }

        // Kiểm tra xem đối tượng có ra ngoài màn hình không
        public bool isOutBound
        {
            get
            {
                return Parent.posX > Coord.GetXBordDroitEcran(); // Trả về true nếu vượt ra ngoài biên phải
            }
        }

        // Phương thức cập nhật vị trí đối tượng
        public override void Update()
        {
            Move(Speed.X, Speed.Y); // Gọi phương thức di chuyển với tốc độ hiện tại
        }

        // Phương thức di chuyển đối tượng
        public void Move(float x, float y)
        {
            Parent.posX += (int)(x * Global.DeltaTime); // Cập nhật tọa độ X
            Parent.posY += (int)(y * Global.DeltaTime); // Cập nhật tọa độ Y
        }

        // Phương thức dừng đối tượng
        public void Stop()
        {
            HasStopped = true; // Đánh dấu là đã dừng
            Speed = new Point(0, 0); // Đặt tốc độ về 0
        }

        // Phương thức tiếp tục di chuyển đối tượng
        public void Resume()
        {
            if (HasStopped) // Nếu đang dừng
            {
                Speed = InitialSpeed; // Khôi phục tốc độ ban đầu
                HasStopped = false; // Đánh dấu là không còn dừng
            }
        }
    }
}
