using PvZ.Components;
using PvZ.NewEntities;
using System.Linq;

namespace PvZ
{
    class MainLoop
    {
        public static void DoIt()
        {
            // Enlève les gameobject mort :(
            Global.Entities.RemoveAll(x=> x.Inactive);

            for (int i = 0; i < Global.Entities.ToArray().Length; i++)
            {
                Global.Entities[i].Update();
            }
        }

        public static void Affichage()
        {
            foreach (GameObject go in Global.Entities.OrderBy(x => x.Layer))
            {
                CDrawable drawable = go.GetComponent<CDrawable>();
                if (drawable != null)
                {
                    drawable.Draw();
                }
            }

            DebugMode.Update();

        }
    }
}
