using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Form1 : Form
    {
        private Bitmap[] Tiles = new Bitmap[]
        {
            Resource1.EmptyTile,
            Resource1.BlueTile,
            Resource1.CyanTile,
            Resource1.GreenTile,
            Resource1.OrangeTile,
            Resource1.PurpleTile,
            Resource1.RedTile,
            Resource1.YellowTile
        };

        private Bitmap[] Blocks = new Bitmap[]
        {
            Resource1.EmptyBlock,
            Resource1.IBlock,
            Resource1.JBlock,
            Resource1.LBlock,
            Resource1.OBlock,
            Resource1.SBlock,
            Resource1.TBlock,
            Resource1.ZBlock
        };

        private Keys[] controler = new Keys[]
        {
            Keys.A,
            Keys.Left,
            Keys.D,
            Keys.Right,
            Keys.S,
            Keys.Down,
            Keys.E,
            Keys.Apps,
            Keys.Q,
            Keys.Apps,
            Keys.Space,
            Keys.Apps,
            Keys.ShiftKey,
            Keys.Apps
        };

        private void ClearSettings(Keys key)
        {
            for (int i = 0; i < controler.Length; i++)
            {
                if(controler[i]==key)
                {
                    controler[i] = Keys.Apps;
                }
            }
        }

        private void FillingSettings()
        {
            foreach (Control item in settings.Controls)
            {
                if (item.GetType() == textBox1.GetType())
                {
                    if(controler[int.Parse(item.Tag.ToString())].ToString() != Keys.Apps.ToString())
                    {
                        ((TextBox)item).Text = controler[int.Parse(item.Tag.ToString())].ToString();
                    }
                    else
                    {
                        ((TextBox)item).Text = string.Empty;
                    }
                }
            }
        }

        private GameState FirstPlayer;

        private int maxDelay = 1000;
        private int minDelay = 75;
        private int delayDecrease = 10; 

        private async Task GameLoop()
        {
            while (!FirstPlayer.GameOver)
            {
                int delay = Math.Max(minDelay, maxDelay - (delayDecrease * FirstPlayer.Stats.Lines));
                await Task.Delay(delay);
                if (FirstPlayer == null)
                {
                    return;
                }
                FirstPlayer.MoveBlockDown();
                gameGrid.Refresh();
            }
        }

        private void Movement(object sender, KeyEventArgs e)
        {
            if (FirstPlayer == null || FirstPlayer.GameOver)
            {
                return;
            }

            if(controler[0] == e.KeyCode || controler[1] == e.KeyCode)
            {
                FirstPlayer.MoveBlockLeft();
            }
            else if (controler[2] == e.KeyCode || controler[3] == e.KeyCode)
            {
                FirstPlayer.MoveBlockRight();
            }
            else if (controler[4] == e.KeyCode || controler[5] == e.KeyCode)
            {
                FirstPlayer.MoveBlockDown();
            }
            else if (controler[6] == e.KeyCode || controler[7] == e.KeyCode)
            {
                FirstPlayer.RotateBlockCW();
            }
            else if (controler[8] == e.KeyCode || controler[9] == e.KeyCode)
            {
                FirstPlayer.RotateBlockCCW();
            }
            else if (controler[10] == e.KeyCode || controler[11] == e.KeyCode)
            {
                FirstPlayer.DropBlock();
            }
            else if (controler[12] == e.KeyCode || controler[13] == e.KeyCode)
            {
                FirstPlayer.HoldBlock();
            }

            gameGrid.Refresh();
        }

        private void DrawGrid(int TileSize, Graphics graphics)
        {
            for (int x = 2; x < FirstPlayer.GameGrid.Rows; x++)
            {
                for (int y = 0; y < FirstPlayer.GameGrid.Columns; y++)
                {
                    Rectangle rectangle = new Rectangle(y * TileSize, (x - 2) * TileSize, TileSize, TileSize);
                    graphics.DrawImage(Tiles[FirstPlayer.GameGrid[x, y]], rectangle);
                }
            }
        }

        private void DrawBlock(int TileSize, Graphics graphics)
        {
            foreach (Position p in FirstPlayer.CurrentBlock.TilePositions())
            {
                if (p.Row > 1)
                {
                    Rectangle rectangle = new Rectangle(p.Column * TileSize, (p.Row - 2) * TileSize, TileSize, TileSize);
                    graphics.DrawImage(Tiles[FirstPlayer.CurrentBlock.Id], rectangle);
                }
            }
        }

        private void DrawGhostBlock(int TileSize, Graphics graphics)
        {
            int distance = FirstPlayer.BlockDropDistance();
            foreach (Position p in FirstPlayer.CurrentBlock.TilePositions())
            {
                Rectangle rectangle = new Rectangle(p.Column * TileSize, (p.Row - 2 + distance) * TileSize, TileSize, TileSize);
                graphics.DrawImage(Resource1.GhostBlueTile, rectangle);
            }
        }

        private void DrawNextBlock(PictureBox pictureBox)
        {
            pictureBox.Image = Blocks[FirstPlayer.BlockQueue.NextBlock.Id];
        }

        private void DrawHeldBlock(PictureBox pictureBox)
        {
            if (FirstPlayer.HeldBlock == null)
            {
                pictureBox.Image = Blocks[0];
            }
            else
            {
                pictureBox.Image = Blocks[FirstPlayer.HeldBlock.Id];
            }
        }

        private void DrawStats()
        {
            score.Text = $"Score\n{FirstPlayer.Stats.Score}";
            lines.Text = $"Lines\n{FirstPlayer.Stats.Lines}";
            if (FirstPlayer.Stats.Burned == 0 && FirstPlayer.Stats.Lines != 0)
                trt.Text = $"TRT:\n{Math.Round(FirstPlayer.Stats.PercentOfTetris(), 2)}%";
            else
                trt.Text = $"BRN:\n{FirstPlayer.Stats.Burned}";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            mainMenu.Visible = false;
            game.Visible = true;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            mainMenu.Visible = false;
            settings.Visible = true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCloseGame_Click(object sender, EventArgs e)
        {
            mainMenu.Visible = true;
            game.Visible = false;
        }

        private void gameGrid_Paint(object sender, PaintEventArgs e)
        {
            int TileSize = gameGrid.Height / 20;

            Graphics graphics = e.Graphics;

            DrawGrid(TileSize, graphics);
            DrawGhostBlock(TileSize, graphics);
            DrawBlock(TileSize, graphics);
            DrawNextBlock(nextBlock);
            DrawHeldBlock(heldBlock);
            DrawStats();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            mainMenu.Visible = true;
            settings.Visible = false;
        }

        private void KeySettings(object sender, KeyEventArgs e)
        {
            ClearSettings(e.KeyCode);
            controler[int.Parse(((TextBox)sender).Tag.ToString())] = e.KeyCode;
            FillingSettings();
        }

        private void mainMenu_VisibleChanged(object sender, EventArgs e)
        {
            if (!mainMenu.Visible)
            {
                return;
            }

            CancelButton = btnExit;
        }

        private async void game_VisibleChanged(object sender, EventArgs e)
        {
            if (!game.Visible)
            {
                FirstPlayer = null;
                return;
            }

            CancelButton = btnCloseGame;
            FirstPlayer = new GameState();
            await GameLoop();
        }

        private void settings_VisibleChanged(object sender, EventArgs e)
        {
            if(!settings.Visible)
            {
                return;
            }

            FillingSettings();
            CancelButton = btnBack;
        }
    }
}