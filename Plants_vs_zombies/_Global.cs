using PvZ.NewEntities;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PvZ
{
    class Global
    {
        static public SpriteManager Sprites;    // Quản lý sprites trong game
        static public Graphics Ecran;           // Đối tượng Graphics dùng để vẽ lên màn hình
        static public int Height;               // Chiều cao của vùng hiển thị
        static public int dollar = 2000;        // Số tiền của người chơi
        static public int Round = 1;            // Đếm số vòng
        static public double DeltaTime;          // Thời gian trôi qua giữa các khung hình
        static public bool DrawHitBox { get; set; } // Có vẽ hitbox không
        public static bool DisplayHP { get; set; } // Có hiển thị HP không

        // Biến để lưu creature đã chọn
        static public Creature Button;            // Creature được chọn

        // Trạng thái của trò chơi
        static public GameState stateofthegame;
        public enum GameState { Playing, Loose, Win } // Các trạng thái của trò chơi

        // Các loại creature có thể chọn
        public enum Creature
        {
            Zombie, ZombieCone, ZombieSot, Tournesol, PistoPois,
            Mine, Noix, DoublePistoPois, PistoGel, Cerises, Canon, Shovel
        };

        // Chi phí của mỗi loại plant
        static public Dictionary<Creature, int> SunCosts = new Dictionary<Creature, int>()
        {
            { Creature.PistoPois, 100 },
            { Creature.PistoGel, 175 },
            { Creature.DoublePistoPois, 200 },
            { Creature.Tournesol, 50 },
            { Creature.Noix, 50 },
            { Creature.Mine, 25 },
            { Creature.Cerises, 150 }
        };

        // Thời gian cooldown cho mỗi loại plant
        static public Dictionary<Creature, int> CoolDown = new Dictionary<Creature, int>()
        {
            { Creature.PistoPois, 40 },
            { Creature.PistoGel, 40 },
            { Creature.DoublePistoPois, 40 },
            { Creature.Tournesol, 40 },
            { Creature.Noix, 40 },
            { Creature.Mine, 40 },
            { Creature.Cerises, 300 }
        };

        static public List<GameObject> Entities = new List<GameObject>(); // Danh sách các đối tượng trong game

        static public Dictionary<Global.Creature, int> plantsCooldown = new Dictionary<Creature, int>(); // Thời gian cooldown cho các plant

        // Khởi tạo đối tượng Random để sinh số ngẫu nhiên
        static private Random randNum = new Random();

        // Phương thức trả về số ngẫu nhiên trong khoảng từ min đến max
        public static int Random(int min, int max) { return randNum.Next(min, max + 1); }
    }
}
