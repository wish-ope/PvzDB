using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace PvZ
{
    class TimeMeasure
    {
        private Stopwatch Watch;  // Đồng hồ bấm giờ dùng để đo thời gian

        public TimeMeasure()
        {
            Watch = new Stopwatch(); // Khởi tạo đồng hồ
            Watch.Start();           // Bắt đầu đồng hồ
            TimeStampStart = Watch.ElapsedMilliseconds; // Lưu timestamp bắt đầu
        }

        private long LastTick;      // Thời gian đánh dấu
        private long TimeStampStart; // Timestamp khởi đầu

        private long secfps;        // Giây hiện tại để đếm FPS
        private int last_fps = 0;  // Ước lượng FPS
        private int countfps = 0;  // Đếm số lần hiển thị trong giây hiện tại
        private float dt;           // Delta time từ lần tính toán cuối
        private long lastTime = 0;  // Thời gian của lần cập nhật cuối

        // Lấy số FPS hiện tại
        public int GetFPS() { return last_fps; }

        // Ghi lại thời gian hoàn thành vẽ
        public void PaintFinished()
        {
            // Tính toán FPS
            long T = Watch.ElapsedMilliseconds;

            if (T / 1000 == secfps)
                countfps++;  // Đếm số khung hình trong giây
            else
            {
                last_fps = countfps; // Cập nhật số FPS cuối
                countfps = 1;        // Đặt lại bộ đếm cho giây mới
                secfps++;            // Chuyển sang giây tiếp theo
            }
        }

        // Lấy thời gian đã trôi qua kể từ khi bắt đầu trò chơi (định dạng chuỗi)
        public String GetStringTime()
        {
            TimeSpan ts = Watch.Elapsed;
            return String.Format("TIME : {0:00}:{1:00}:{2:000}", ts.Minutes, ts.Seconds, ts.Milliseconds);
        }

        // Lấy thời gian đã trôi qua kể từ khi bắt đầu trò chơi (định dạng số thực)
        public float GetTime()
        {
            long T = Watch.ElapsedMilliseconds;
            long Delta = T - TimeStampStart;
            return Delta * 0.001f; // Chuyển đổi từ mili giây sang giây
        }

        // Lấy delta time từ lần cập nhật trước
        public double GetDeltaTime()
        {
            // Nhận thời gian với độ chính xác mili giây
            long nt = Watch.ElapsedMilliseconds;

            // Tính toán thời gian đã trôi qua từ lần gọi cập nhật trước
            double deltaT = (nt - lastTime);

            // Ghi nhớ thời gian của lần cập nhật này
            lastTime = nt;

            return deltaT; // Trả về delta time
        }
    }
}
