using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CClickable : Component
    {
        // Biến để kiểm tra xem đối tượng đã được click hay chưa
        public bool IsClicked { get; set; }

        // Phương thức cập nhật trạng thái của component
        public override void Update()
        {
            if (IsClicked) // Nếu đối tượng đã được click
                IsClicked = false; // Đặt lại trạng thái click về false
        }
    }
}
