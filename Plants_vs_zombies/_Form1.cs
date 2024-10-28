using PvZ.NewEntities;
using PvZ.NewEntities.Components;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Media;
using System.Windows.Forms;

namespace PvZ
{
    public partial class _Form1 : Form
    {
        static TimeMeasure Timer; // Quản lý thời gian
        static SoundPlayer MusicPlayer; // Trình phát nhạc

        public _Form1()
        {
            InitializeComponent(); // Khởi tạo các thành phần của Form
        }

        Bitmap B; // Bitmap cho hình ảnh
        System.Windows.Forms.Timer timer1; // Timer cho vòng lặp game

        private void Form1_Load(object sender, EventArgs e)
        {
            // Khởi tạo Bitmap và Graphics cho hiển thị
            B = new Bitmap(1024, 640, PixelFormat.Format24bppRgb);
            pictureBox1.Image = B;
            Global.Ecran = Graphics.FromImage(B);

            // Thiết lập để tránh hiện tượng flickering trong cửa sổ
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // Sử dụng double buffer

            // Thiết lập các dịch vụ cho trò chơi
            Timer = new TimeMeasure();
            Global.Sprites = new SpriteManager();

            // Thiết lập Timer để gọi vòng lặp game
            timer1 = new Timer();
            timer1.Tick += new EventHandler(GameLoop);
            timer1.Interval = 50; // Gọi lại sau mỗi 50ms
            timer1.Enabled = true;
            timer1.Start();

            // Để tính toán trong hệ tọa độ Cartesian
            Global.Height = pictureBox1.Height; // Cập nhật chiều cao

            // Thêm spawner cho mặt trời
            Global.Entities.Add(new SpawnerEntity());

            // Chạy nhạc nền
            MusicPlayer = new System.Media.SoundPlayer(Properties.Resources.grasswalk);
            MusicPlayer.Play();
        }

        // Hàm được gọi bởi Timer định kỳ
        void GameLoop(Object myObject, EventArgs myEventArgs)
        {
            if (Global.stateofthegame != Global.GameState.Loose)
            {
                // Vòng lặp xử lý logic game
                Global.DeltaTime = Timer.GetDeltaTime() / 1000; // Tính thời gian delta
                MainLoop.DoIt(); // Gọi vòng lặp chính
                Draw(); // Vẽ lại màn hình
                Global.Round++; // Tăng số vòng
                pictureBox1.Invalidate(); // Yêu cầu vẽ lại
                pictureBox1.Update(); // Cập nhật giao diện
            }
            else
            {
                // Nếu trò chơi kết thúc, hiển thị thông báo
                Global.Sprites.Get("zombiesWon").DrawToScreen(300, 500);
                pictureBox1.Invalidate();
                pictureBox1.Update();
            }
        }

        // Hàm vẽ khi hệ thống sẵn sàng
        private void Draw()
        {
            // Vẽ các đối tượng trên màn hình
            Global.Sprites.Get("decor").DrawToScreen(0, 0); // Vẽ nền

            MainLoop.Affichage(); // Vẽ các đối tượng game

            // Cập nhật các thông tin hiển thị
            label1.Text = Timer.GetStringTime(); // Hiển thị thời gian
            label8.Text = Timer.GetFPS() + " FPS"; // Hiển thị FPS
            Global.Ecran.DrawString("Tour : " + Global.Round, new Font(FontFamily.GenericSansSerif, 19, FontStyle.Bold), Brushes.Black, Coord.GetXBordDroitEcran() - 198, 21);
            Global.Ecran.DrawString("Tour : " + Global.Round, new Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular), Brushes.White, Coord.GetXBordDroitEcran() - 195, 20);
            label2.Text = "" + Global.dollar; // Hiển thị số tiền
        }

        // Hàm xử lý sự kiện vẽ
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Timer.PaintFinished(); // Kết thúc việc vẽ
        }

        // Hàm xử lý sự kiện nhấn chuột
        private void _Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Chuyển đổi tọa độ sang hệ Cartesian
            int y = Global.Height - e.Y;
            PvZ.MouseClic.Event(e.X, y); // Gọi sự kiện nhấn chuột
        }

        #region Buttons
        // Các phương thức xử lý sự kiện cho các nút radio
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Zombie; // Chọn Zombie
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Tournesol; // Chọn mặt trời
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.PistoPois; // Chọn súng đậu
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Canon; // Chọn đại bác
        }

        private void MineButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Mine; // Chọn mìn
        }

        private void ZombieConeButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.ZombieCone; // Chọn Zombie Cone
        }

        private void ZombieSautButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.ZombieSot; // Chọn Zombie Saut
        }

        private void NoixButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Noix; // Chọn hạt
        }

        private void PistoPoisButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.DoublePistoPois; // Chọn súng đậu đôi
        }

        private void PistoGelButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.PistoGel; // Chọn súng đông lạnh
        }

        private void CerisesButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Cerises; // Chọn anh đào
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Shovel; // Chọn xẻng
        }
        #endregion

        // Hàm xử lý sự kiện cho nút ẩn hiện hitbox
        private void button1_Click(object sender, EventArgs e)
        {
            Global.DrawHitBox = !Global.DrawHitBox; // Bật/tắt hiển thị hitbox
        }

        // Hàm xử lý sự kiện cho nút ẩn hiện HP
        private void button2_Click(object sender, EventArgs e)
        {
            Global.DisplayHP = !Global.DisplayHP; // Bật/tắt hiển thị HP
        }

        // Hàm xử lý sự kiện cho nút dừng nhạc
        private void button3_Click(object sender, EventArgs e)
        {
            MusicPlayer.Stop(); // Dừng nhạc
        }
    }
}
