using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.Components
{
    class CDisappear : Component
    {
        public int StartRound; // Vòng chơi bắt đầu
        public int Delay; // Thời gian trễ trước khi biến mất

        // Hàm khởi tạo với tham số thời gian trễ
        public CDisappear(int delay)
        {
            StartRound = Global.Round; // Ghi lại vòng chơi bắt đầu
            Delay = delay; // Gán thời gian trễ
        }

        // Phương thức cập nhật trạng thái của component
        public override void Update()
        {
            // Nếu vòng chơi hiện tại bằng vòng chơi bắt đầu cộng với thời gian trễ
            if (Global.Round == StartRound + Delay)
            {
                Parent.Inactive = true; // Đặt trạng thái của đối tượng thành không hoạt động
            }
        }
    }
}
