﻿using PvZ.NewEntities;
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

        static TimeMeasure Timer; // gestionnaire de temps
        static SoundPlayer MusicPlayer;
       
        public _Form1()
        {
            InitializeComponent();

        }

        Bitmap B;
        System.Windows.Forms.Timer timer1;

        private void Form1_Load(object sender, EventArgs e)
        {
            B = new Bitmap(1024,640, PixelFormat.Format24bppRgb);
            pictureBox1.Image = B;
            Global.Ecran = Graphics.FromImage(B);

            // paramètres importants pour eviter le flickering dans la fenêtre
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // double buffer

            // mise en place des divers services utilisés par le jeu

            Timer   = new TimeMeasure();
            Global.Sprites = new SpriteManager();


            /// timer
            // lance la boucle de callback
            timer1 = new Timer();
            timer1.Tick += new EventHandler(GameLoop);
            timer1.Interval = 50;   // demande l'appel toutes les 30ms
            timer1.Enabled = true; // 
            timer1.Start();
            
            // pour la conversion en cartésien
            Global.Height = pictureBox1.Height; // pour tenir compte epaisseur du bandeau

            // Ajoute le spawner de soleil
            Global.Entities.Add(new SpawnerEntity());

            //Global.Entities.Add(new MeowerEntity(200, 470));
            //Global.Entities.Add(new MeowerEntity(200, 370));
            //Global.Entities.Add(new MeowerEntity(200, 275));
            //Global.Entities.Add(new MeowerEntity(200, 175));
            //Global.Entities.Add(new MeowerEntity(200, 75));


            // Musique
            MusicPlayer = new System.Media.SoundPlayer(Properties.Resources.grasswalk);
            MusicPlayer.Play();
        }

        // fonction appellée par le choronomètre toutes les xxx ms
        
        void GameLoop(Object myObject, EventArgs myEventArgs)
        {
            if (Global.stateofthegame != Global.GameState.Loose)
            {
                // boucle sur l'IA
                Global.DeltaTime = Timer.GetDeltaTime() / 1000;
                MainLoop.DoIt();
                Draw();
                Global.Round++;
                pictureBox1.Invalidate();
                pictureBox1.Update();       // demande l'affichage
            }
            else
            {
                Global.Sprites.Get("zombiesWon").DrawToScreen(300, 500);
                pictureBox1.Invalidate();
                pictureBox1.Update();       // demande l'affichage
            }
        }



        // Lorsque le système est prêt à afficher, il appelle cette fonction 

        private void Draw()
        {
            // affichage des personnages

            Global.Sprites.Get("decor").DrawToScreen(0, 0);

            MainLoop.Affichage();

            label1.Text = Timer.GetStringTime();
            label8.Text = Timer.GetFPS() + " FPS";
            Global.Ecran.DrawString("Tour : " + Global.Round, new Font(FontFamily.GenericSansSerif, 19, FontStyle.Bold), Brushes.Black, Coord.GetXBordDroitEcran() - 198, 21);
            Global.Ecran.DrawString("Tour : " + Global.Round, new Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular), Brushes.White, Coord.GetXBordDroitEcran() - 195, 20);

            label2.Text = "" + Global.dollar;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Timer.PaintFinished();
        }

        private void _Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // passage en coord cartérsienne
            int y = Global.Height - e.Y;
            PvZ.MouseClic.Event(e.X, y);
        }

        #region Buttons
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Zombie;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Tournesol;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.PistoPois;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Canon;
        }

        private void MineButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Mine;
        }

        private void ZombieConeButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.ZombieCone;
        }

        private void ZombieSautButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.ZombieSot;
        }

        private void NoixButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Noix;
        }

        private void PistoPoisButton2_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.DoublePistoPois;
        }

        private void PistoGelButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.PistoGel;
        }

        private void CerisesButton_CheckedChanged(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Cerises;
        }
        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Global.Button = Global.Creature.Shovel;
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Global.DrawHitBox = !Global.DrawHitBox;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Global.DisplayHP = !Global.DisplayHP;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusicPlayer.Stop();
        }


    }
}
