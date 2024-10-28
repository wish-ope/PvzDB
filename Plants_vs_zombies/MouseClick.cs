using PvZ.Components;
using PvZ.NewEntities;
using System;
using System.Collections.Generic;

namespace PvZ
{
    class MouseClic
    {
        ///////////////////////////////////////////////////////////////////////////////////////////
        // fonction d'entrée du clic SOURIS
        // les coordonnées sont cartésiennes

        static public void Event(int x, int y)
        {
            int rangee = Coord.YtoRow(y);
            int col = Coord.XtoColumn(x);

            List<GameObject> se = Global.Entities.FindAll(s => s.GetComponent<CClickable>() != null && x <= s.posX + s.GetComponent<CDrawable>().HitBox.Width && x >= s.posX
                                                  && y <= s.posY + s.GetComponent<CDrawable>().HitBox.Height && y >= s.posY);
            se.ForEach(sunClicked => sunClicked.GetComponent<CClickable>().IsClicked = true);

            if (se.Count != 0)
            {
            }
            else if (Global.Button == Global.Creature.Zombie)
            {
                ZombieEntity ze = new ZombieEntity(rangee, Global.Creature.ZombieCone);

                if (rangee >= 0 && rangee < 5)
                    Global.Entities.Add(ze);
            }
            else
            {
                if (rangee >= 0 && col >= 0 && rangee < 5 && col < 9)
                {
                    GameObject FoundPlant = Global.Entities.FindAll(p => p.Tags.Contains("Plant")).Find(p => Coord.YtoRow((int)p.posY) == rangee && Coord.XtoColumn((int)p.posX) == col);
                    if (Global.Button == Global.Creature.Shovel && FoundPlant != null)
                    {
                        FoundPlant.Inactive = true;
                    }

                    else if (FoundPlant == null && Global.SunCosts[Global.Button] <= Global.dollar) //&& Global.PlantsCooldown[Global.Button] + Global.Round <= Global.Round)
                    {

                        PlantEntity pe = new PlantEntity(col, rangee, Global.Button);
                        Global.Entities.Add(pe);
                        Global.dollar -= Global.SunCosts[Global.Button];
                        //Global.PlantsCooldown[Global.Button] =  Global.Round;
                    }

                }
            }
        }
    }
}