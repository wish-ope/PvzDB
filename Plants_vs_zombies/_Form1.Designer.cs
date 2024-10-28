namespace PvZ
{
    partial class _Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.PistoPoisButton2 = new System.Windows.Forms.RadioButton();
            this.MineButton = new System.Windows.Forms.RadioButton();
            this.PistoPoisButton = new System.Windows.Forms.RadioButton();
            this.CerisesButton = new System.Windows.Forms.RadioButton();
            this.NoixButton = new System.Windows.Forms.RadioButton();
            this.PistoGelButton = new System.Windows.Forms.RadioButton();
            this.TournesolButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ZombieSautButton = new System.Windows.Forms.RadioButton();
            this.ZombieConeButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ZombieButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(887, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Temps :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(393, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Soleils :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(886, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tour";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.PistoPoisButton2);
            this.panel1.Controls.Add(this.MineButton);
            this.panel1.Controls.Add(this.PistoPoisButton);
            this.panel1.Controls.Add(this.CerisesButton);
            this.panel1.Controls.Add(this.NoixButton);
            this.panel1.Controls.Add(this.PistoGelButton);
            this.panel1.Controls.Add(this.TournesolButton);
            this.panel1.Location = new System.Drawing.Point(283, 610);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(601, 73);
            this.panel1.TabIndex = 22;
            // 
            // radioButton1
            // 
            this.radioButton1.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton1.BackgroundImage = global::PvZ.Properties.Resources.shovel;
            this.radioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.radioButton1.Location = new System.Drawing.Point(532, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(64, 64);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.Text = "        ";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // PistoPoisButton2
            // 
            this.PistoPoisButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.PistoPoisButton2.BackgroundImage = global::PvZ.Properties.Resources.icone_pois_double;
            this.PistoPoisButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PistoPoisButton2.Location = new System.Drawing.Point(76, 4);
            this.PistoPoisButton2.Name = "PistoPoisButton2";
            this.PistoPoisButton2.Size = new System.Drawing.Size(64, 64);
            this.PistoPoisButton2.TabIndex = 17;
            this.PistoPoisButton2.Text = "        ";
            this.PistoPoisButton2.UseVisualStyleBackColor = true;
            this.PistoPoisButton2.CheckedChanged += new System.EventHandler(this.PistoPoisButton2_CheckedChanged);
            // 
            // MineButton
            // 
            this.MineButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.MineButton.BackgroundImage = global::PvZ.Properties.Resources.icone_mine;
            this.MineButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MineButton.Location = new System.Drawing.Point(354, 3);
            this.MineButton.Name = "MineButton";
            this.MineButton.Size = new System.Drawing.Size(64, 64);
            this.MineButton.TabIndex = 14;
            this.MineButton.Text = "        ";
            this.MineButton.UseVisualStyleBackColor = true;
            this.MineButton.CheckedChanged += new System.EventHandler(this.MineButton_CheckedChanged);
            // 
            // PistoPoisButton
            // 
            this.PistoPoisButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PistoPoisButton.BackColor = System.Drawing.Color.Transparent;
            this.PistoPoisButton.BackgroundImage = global::PvZ.Properties.Resources.icone_pois;
            this.PistoPoisButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PistoPoisButton.Location = new System.Drawing.Point(6, 4);
            this.PistoPoisButton.Name = "PistoPoisButton";
            this.PistoPoisButton.Size = new System.Drawing.Size(64, 64);
            this.PistoPoisButton.TabIndex = 10;
            this.PistoPoisButton.Text = "        ";
            this.PistoPoisButton.UseVisualStyleBackColor = false;
            this.PistoPoisButton.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // CerisesButton
            // 
            this.CerisesButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.CerisesButton.BackgroundImage = global::PvZ.Properties.Resources.icone_cerises;
            this.CerisesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CerisesButton.Location = new System.Drawing.Point(424, 3);
            this.CerisesButton.Name = "CerisesButton";
            this.CerisesButton.Size = new System.Drawing.Size(64, 64);
            this.CerisesButton.TabIndex = 12;
            this.CerisesButton.Text = "        ";
            this.CerisesButton.UseVisualStyleBackColor = true;
            this.CerisesButton.CheckedChanged += new System.EventHandler(this.CerisesButton_CheckedChanged);
            // 
            // NoixButton
            // 
            this.NoixButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.NoixButton.BackgroundImage = global::PvZ.Properties.Resources.icone_noix;
            this.NoixButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoixButton.Location = new System.Drawing.Point(284, 3);
            this.NoixButton.Name = "NoixButton";
            this.NoixButton.Size = new System.Drawing.Size(64, 64);
            this.NoixButton.TabIndex = 11;
            this.NoixButton.Text = "        ";
            this.NoixButton.UseVisualStyleBackColor = true;
            this.NoixButton.CheckedChanged += new System.EventHandler(this.NoixButton_CheckedChanged);
            // 
            // PistoGelButton
            // 
            this.PistoGelButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.PistoGelButton.BackgroundImage = global::PvZ.Properties.Resources.icone_gel;
            this.PistoGelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PistoGelButton.Location = new System.Drawing.Point(144, 3);
            this.PistoGelButton.Name = "PistoGelButton";
            this.PistoGelButton.Size = new System.Drawing.Size(64, 64);
            this.PistoGelButton.TabIndex = 9;
            this.PistoGelButton.Text = "        ";
            this.PistoGelButton.UseVisualStyleBackColor = true;
            this.PistoGelButton.CheckedChanged += new System.EventHandler(this.PistoGelButton_CheckedChanged);
            // 
            // TournesolButton
            // 
            this.TournesolButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.TournesolButton.BackgroundImage = global::PvZ.Properties.Resources.icone_fleur;
            this.TournesolButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TournesolButton.Location = new System.Drawing.Point(214, 3);
            this.TournesolButton.Name = "TournesolButton";
            this.TournesolButton.Size = new System.Drawing.Size(64, 64);
            this.TournesolButton.TabIndex = 8;
            this.TournesolButton.Text = "        ";
            this.TournesolButton.UseVisualStyleBackColor = true;
            this.TournesolButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Cliquez dans";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 27;
            this.label7.Text = "le décors";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "HITBOX ON/OFF";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 20);
            this.button2.TabIndex = 29;
            this.button2.Text = "HP ON/OFF";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(245, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(41, 20);
            this.button3.TabIndex = 30;
            this.button3.Text = "♩";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 57);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 626);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this._Form1_MouseDown);
            // 
            // ZombieSautButton
            // 
            this.ZombieSautButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ZombieSautButton.BackgroundImage = global::PvZ.Properties.Resources.icone_zombie_sot;
            this.ZombieSautButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZombieSautButton.Enabled = false;
            this.ZombieSautButton.Location = new System.Drawing.Point(47, 404);
            this.ZombieSautButton.Name = "ZombieSautButton";
            this.ZombieSautButton.Size = new System.Drawing.Size(64, 64);
            this.ZombieSautButton.TabIndex = 19;
            this.ZombieSautButton.Text = "        ";
            this.ZombieSautButton.UseVisualStyleBackColor = true;
            this.ZombieSautButton.CheckedChanged += new System.EventHandler(this.ZombieSautButton_CheckedChanged);
            // 
            // ZombieConeButton
            // 
            this.ZombieConeButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ZombieConeButton.BackgroundImage = global::PvZ.Properties.Resources.zombie_cone;
            this.ZombieConeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZombieConeButton.Enabled = false;
            this.ZombieConeButton.Location = new System.Drawing.Point(47, 334);
            this.ZombieConeButton.Name = "ZombieConeButton";
            this.ZombieConeButton.Size = new System.Drawing.Size(64, 64);
            this.ZombieConeButton.TabIndex = 18;
            this.ZombieConeButton.Text = "        ";
            this.ZombieConeButton.UseVisualStyleBackColor = true;
            this.ZombieConeButton.CheckedChanged += new System.EventHandler(this.ZombieConeButton_CheckedChanged);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(580, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 33);
            this.label3.TabIndex = 16;
            // 
            // ZombieButton
            // 
            this.ZombieButton.Appearance = System.Windows.Forms.Appearance.Button;
            this.ZombieButton.BackgroundImage = global::PvZ.Properties.Resources.icone_zombie;
            this.ZombieButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ZombieButton.Checked = true;
            this.ZombieButton.Location = new System.Drawing.Point(47, 73);
            this.ZombieButton.Name = "ZombieButton";
            this.ZombieButton.Size = new System.Drawing.Size(64, 64);
            this.ZombieButton.TabIndex = 7;
            this.ZombieButton.TabStop = true;
            this.ZombieButton.Text = "        ";
            this.ZombieButton.UseVisualStyleBackColor = true;
            this.ZombieButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "fps";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(870, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 31);
            this.label8.TabIndex = 31;
            this.label8.Text = "fps";
            // 
            // _Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1038, 684);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ZombieSautButton);
            this.Controls.Add(this.ZombieConeButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ZombieButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_Form1";
            this.Text = "Plants vs Zombies";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton ZombieButton;
        private System.Windows.Forms.RadioButton TournesolButton;
        private System.Windows.Forms.RadioButton PistoGelButton;
        private System.Windows.Forms.RadioButton PistoPoisButton;
        private System.Windows.Forms.RadioButton NoixButton;
        private System.Windows.Forms.RadioButton CerisesButton;
        private System.Windows.Forms.RadioButton MineButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton PistoPoisButton2;
        private System.Windows.Forms.RadioButton ZombieConeButton;
        private System.Windows.Forms.RadioButton ZombieSautButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}

