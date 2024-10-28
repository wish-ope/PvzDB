using PvZ.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace PvZ.NewEntities
{
    /// <summary>
    /// Classe permettant de gérer le Debug
    /// </summary>
    public static class DebugMode
    {
        // Cập nhật chế độ debug
        public static void Update()
        {
            // Vẽ hitbox nếu tùy chọn được bật
            if (Global.DrawHitBox)
                DrawHitBox();

            // Hiển thị thanh sức khỏe nếu tùy chọn được bật
            if (Global.DisplayHP)
                DisplayHealthBar();
        }

        // Vẽ hitbox của các đối tượng
        public static void DrawHitBox()
        {
            // Lặp qua tất cả các đối tượng có component CDrawable
            foreach (GameObject go in Global.Entities.FindAll(x => x.GetComponent<CDrawable>() != null))
            {
                // Vẽ hình chữ nhật đại diện cho hitbox
                Global.Ecran.FillRectangle(new SolidBrush(Color.FromArgb(128, 255, 0, 0)),
                    go.posX + go.offsetX,
                    go.CorrectedY,
                    go.GetComponent<CDrawable>().HitBox.Width,
                    go.GetComponent<CDrawable>().HitBox.Height);
            }
        }

        // Hiển thị thanh sức khỏe của các đối tượng
        public static void DisplayHealthBar()
        {
            // Lặp qua tất cả các đối tượng
            foreach (GameObject go in Global.Entities)
            {
                CHealth health = go.GetComponent<CHealth>();
                // Nếu đối tượng có component CHealth
                if (health != null)
                {
                    // Vẽ nền cho thanh sức khỏe
                    Global.Ecran.FillRectangle(Brushes.Black, go.posX - 8, go.CorrectedY - 20, 100, 10);
                    // Vẽ thanh sức khỏe dựa trên tỉ lệ HP hiện tại và HP ban đầu
                    Global.Ecran.FillRectangle(Brushes.Blue, go.posX - 8, go.CorrectedY - 20, (health.HP / health.InitialHP) * 100, 10);
                    // Hiển thị thông tin sức khỏe trên thanh
                    Global.Ecran.DrawString(health.HP + "/" + health.InitialHP, SystemFonts.DefaultFont, Brushes.White, go.posX, go.CorrectedY - 22);
                }
            }
        }
    }
}
