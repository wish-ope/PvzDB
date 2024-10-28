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
        public static void Update()
        {
            if (Global.DrawHitBox)
                DrawHitBox();

            if (Global.DisplayHP)
                DisplayHealthBar();
        }
        public static void DrawHitBox()
        {
            foreach (GameObject go in Global.Entities.FindAll(x=>x.GetComponent<CDrawable>() != null))
            {
                Global.Ecran.FillRectangle(new SolidBrush(Color.FromArgb(128, 255, 0, 0)),
                    go.posX + go.offsetX,
                    go.CorrectedY,
                    go.GetComponent<CDrawable>().HitBox.Width, go.GetComponent<CDrawable>().HitBox.Height);
            }

        }
        public static void DisplayHealthBar()
        {
            foreach (GameObject go in Global.Entities)
            {
                CHealth health = go.GetComponent<CHealth>();
                if (health != null)
                {
                    Global.Ecran.FillRectangle(Brushes.Black, go.posX - 8, go.CorrectedY - 20, 100, 10);
                    Global.Ecran.FillRectangle(Brushes.Blue, go.posX - 8, go.CorrectedY - 20, (health.HP / health.InitialHP) * 100, 10);
                    Global.Ecran.DrawString(health.HP + "/" + health.InitialHP, SystemFonts.DefaultFont, Brushes.White, go.posX, go.CorrectedY - 22);
                }
            }
        }
                    

    }
}
