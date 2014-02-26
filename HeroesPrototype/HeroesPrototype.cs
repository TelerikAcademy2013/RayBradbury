﻿using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace HeroesPrototype
{
    public partial class HeroesPrototype : Form
    {
        private MainScene scene;
        public System.Media.SoundPlayer Sounds = new System.Media.SoundPlayer(@"..\..\WAVs\06-stronghold-towns.wav");
        // Sounds.PlayLooping();
            //Sounds.Play();
        
        public HeroesPrototype()
        {
            this.InitializeComponent();
            Sounds.PlayLooping();
            this.scene = new MainScene(this.Scene.CreateGraphics(), new Geometry.Size2D(this.Scene.Width, this.Scene.Height));
            this.MainLoop.RunWorkerAsync();
        }

        private void Draw(object sender, RunWorkerCompletedEventArgs e)
        {
            this.scene.Draw();
            this.MainLoop.RunWorkerAsync();
        }

        private void Update(object sender, DoWorkEventArgs e)
        {
            this.scene.GameLoop();

            Day.Text = "Day: " + scene.Calend.WeekDay;
            Week.Text = "Week: " + scene.Calend.Week;
            Month.Text = "Month: " + scene.Calend.Month;

            Attack.Text = "Attack: " + scene.MainCharacter.Attack;
            Defence.Text = "Defence: " + scene.MainCharacter.Defense;
            ExperienceLbl.Text = "XP: " + scene.MainCharacter.Experience;

            Gold.Text = "Gold: " + scene.MainCharacter.Gold;
            Ore.Text = "Ore: " + scene.MainCharacter.Ore;
            Wood.Text = "Wood: " + scene.MainCharacter.Wood;

            MovesLbl.Text = "Moves: " + scene.MainCharacter.Moves + "/" + scene.MainCharacter.MaxMoves;

            Thread.Sleep(50);

        }

        private void HandleMouse(object sender, MouseEventArgs e)
        {
            
        }

        private void HandleKeyboard(object sender, KeyEventArgs e)
        {
            this.scene.KeyboardAction(e.KeyCode);
        }

        private void MouseAction(object sender, MouseEventArgs e)
        {
            this.scene.MouseAction(e.X, e.Y, e.Button);
        }

        private void Scene_Paint(object sender, PaintEventArgs e)
        {
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void EndDay_Click(object sender, EventArgs e)
        {
            this.scene.Calend.Day++;
            this.scene.MainCharacter.Moves = scene.MainCharacter.MaxMoves;
            if (scene.Calend.Day % 28 == 0)
            {
                MessageBox.Show("The sun rises, a new month begins and new population is born! You receive +25% of your gold! ");
                scene.MainCharacter.Gold += scene.MainCharacter.Gold * 25 / 100;
            }
            else if (scene.Calend.Day % 7 == 0)
            {
                MessageBox.Show("The sun rises, a new week begins and new population is born! You receive +15% of your gold! ");
                scene.MainCharacter.Gold += scene.MainCharacter.Gold * 15 / 100;
            }
            else
            {
                MessageBox.Show("The sun rises and a new day begins!");
            }
        }

        private void BackgroundMusicSwitch_Click(object sender, EventArgs e)
        {
            if (BackgroundMusicSwitch.Text == "Background music Off")
            {
                Sounds.Stop();
                BackgroundMusicSwitch.Text = "Background music On";
            }
            else
            {
                Sounds.PlayLooping();
                BackgroundMusicSwitch.Text = "Background music Off";
            }
            
        }

        public void menuItemRunTrainer_Click(object sender, EventArgs e)
        {
            Trainer trainer = new Trainer(this.scene);
            trainer.Visible = true;
            trainer.Activate();
        }

        
    }
}