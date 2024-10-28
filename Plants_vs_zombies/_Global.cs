using PvZ.NewEntities;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace PvZ
{
    class Global
    {

        static public SpriteManager Sprites;    // gestionnaire de sprites
        static public Graphics Ecran;           // utilisé pour les drawscreen
        static public int Height;               // hauteur de la zone d'affichage
        static public int dollar = 2000; // 2000;         // money du joueur
        static public int Round = 1;            // compteur de tour
        static public double DeltaTime;
        static public bool DrawHitBox { get; set; } // Dessiner la hitbox
        public static bool DisplayHP { get; set; }


        /////////////////////////////////////////////////////////////////////

        static public Creature Button;            // indique la creature selectionnée

        static public GameState stateofthegame;
        public enum GameState { Playing, Loose, Win }

        public enum Creature { Zombie, ZombieCone, ZombieSot, Tournesol, PistoPois,
            Mine, Noix, DoublePistoPois, PistoGel, Cerises, Canon, Shovel };


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


        static public List<GameObject> Entities = new List<GameObject>();

        static public Dictionary<Global.Creature, int> plantsCooldown = new Dictionary<Creature, int>();

        // retour un nombre aléatoire entre 0 et n-1
        static private Random randNum = new Random();

        public static int Random(int min, int max) { return randNum.Next(min , max + 1); }

    }
}
