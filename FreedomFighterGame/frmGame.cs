using EZInput;
using FreedomFighterGame.Framework;
using FreedomFighterGame.GameDL;
using FreedomFighterGame.GameGL;
using FreedomFighterGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FreedomFighterGame
{
    public partial class frmGame : Form
    {
        Label lbl = new Label();
        GameAtlas player;
        List<Bullet> bullets = new List<Bullet>();
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            createLabel();
            GameGrid grid = new GameGrid("maze.txt");
            GameCell startCell = new GameCell(7, 22, grid);
            GameCell startEnemyCell = new GameCell(0, 3, grid);
            GameCell startEnemyCellRed = new GameCell(1, 16, grid);
            player = new GameAtlas(Resources.player_ship, startCell);
            Enemy E1 = new VEnemy(Resources.alien_red, startEnemyCellRed, GameDirection.Up, 100);
            Enemy E2 = new HEnemy(Resources.alien_blue, startEnemyCell, GameDirection.Left,100);
            Enemy E3 = new REnemy(Resources.alien_green, startEnemyCell,100);
            //Enemy E4 = new SEnemy(Resources.alien_red, startEnemyCell, player, 100);
            EnemyDL.AddEnemy(E1);
            EnemyDL.AddEnemy(E2);
            EnemyDL.AddEnemy(E3);
            //EnemyDL.AddEnemy(E4);
            startCell.setGameObject(player);
            foreach (Enemy enemy in EnemyDL.enemies)
            {
                startEnemyCell.setGameObject(enemy);
                printCharacter(enemy);
            }
            MakeProgressBars();
            printMaze(grid);
            printCharacter(player);

        }
        
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateProgressBar();
            showLabel();
            
            //Player Movement
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                player.move(GameDirection.Left);
            }
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                player.move(GameDirection.Right);
            }
            if (Keyboard.IsKeyPressed(Key.UpArrow))
            {
                player.move(GameDirection.Up);
            }
            if (Keyboard.IsKeyPressed(Key.DownArrow))
            {
                player.move(GameDirection.Down);
            }

            //Bullets Generation
            if (Keyboard.IsKeyPressed(Key.W))
            {
                Bullet b = new Bullet(Resources.bullet_up, player.CurrentCell.nextCell(GameDirection.Up), GameDirection.Up);
                bullets.Add(b);
            }
            if (Keyboard.IsKeyPressed(Key.A))
            {
                Bullet b = new Bullet(Resources.bullet_left, player.CurrentCell.nextCell(GameDirection.Left), GameDirection.Left);
                bullets.Add(b);
            }
            if (Keyboard.IsKeyPressed(Key.D))
            {
                Bullet b = new Bullet(Resources.bullet_right, player.CurrentCell.nextCell(GameDirection.Right), GameDirection.Right);
                bullets.Add(b);
            }
            if (Keyboard.IsKeyPressed(Key.S))
            {
                Bullet b = new Bullet(Resources.bullet_down, player.CurrentCell.nextCell(GameDirection.Down), GameDirection.Down);
                bullets.Add(b);
            }

            //Loop for moving bullets
            foreach(Bullet b in bullets)
            {
                if(b.Direction == GameDirection.Up)
                {
                    GameCell c = b.move(GameDirection.Up);
                    if (c == b.CurrentCell)
                    {
                        bullets.Remove(b);
                        break;
                    }
                }
                if (b.Direction == GameDirection.Left)
                {
                    GameCell c = b.move(GameDirection.Left);
                    if (c == b.CurrentCell)
                    {
                        bullets.Remove(b);
                        break;
                    }
                }
                if (b.Direction == GameDirection.Down)
                {
                    GameCell c = b.move(GameDirection.Down);
                    if (c == b.CurrentCell)
                    {
                        bullets.Remove(b);
                        break;
                    }
                }
                if (b.Direction == GameDirection.Right)
                {
                    GameCell c = b.move(GameDirection.Right);
                    if (c == b.CurrentCell)
                    {
                        bullets.Remove(b);
                        break;
                    }
                }
            }
            //Loop for checking collision with the enemies
            for (int i = 0; i < EnemyDL.enemies.Count; i++)
            {
                EnemyDL.enemies[i].move();
                if(Collisions.playerCollisionWithEnemy(player, EnemyDL.enemies[i]))
                {
                    player.Health -= 10;
                    if (player.Health < 0)
                    {
                        GameLoop.Enabled = false;
                        this.Hide();
                        EndGame(Resources.gameover);
                        break;
                    }
                }
            }
            //Loop for bullet detection with the enemies
            foreach(Bullet b in  bullets)
            {
                for(int i =0; i<EnemyDL.enemies.Count; i++)
                {
                    if(Collisions.playerCollisionWithEnemy(b, EnemyDL.enemies[i]))
                    {
                        EnemyDL.enemies[i].TakeDamage(b.damage);
                        player.Score+=10;
                        if (EnemyDL.enemies[i].Healths <=0 )
                        {
                            EnemyDL.enemies.Remove(EnemyDL.enemies[i]);
                            break;
                        }
                    }
                    
                }
                if(EnemyDL.enemies.Count <=0)
                {
                    GameLoop.Enabled = false;
                    this.Hide();
                    EndGame(Resources.gameover);
                    break;
                }
            }
        }

        private void UpdateProgressBar()
        {
            pbarAtlasHealth.Minimum = 0;
            pbarAtlasHealth.Maximum = 100;
            pbarAtlasHealth.Value = player.Health;

        }
        private void MakeProgressBars()
        {
            int i = 0;
            foreach (Enemy en in EnemyDL.enemies)
            {
                en.ProgressBar.Location = new System.Drawing.Point(500, 400 + i);
                i += 20;
                this.Controls.Add(en.ProgressBar);
            }
        }
        private void printCharacter(GameObject player)
        {
            this.Controls.Add(player.CurrentCell.pictureBox);
        }
        private void createLabel()
        {
            lbl.Location = new System.Drawing.Point(6, 400);
            lbl.ForeColor = Color.White;
            this.Controls.Add(lbl);
        }
        private void showLabel()
        {
            lbl.Text = "Score: " + player.Score;
        }
        private void printMaze(GameGrid grid)
        {
            for (int row = 0; row < grid.Rows; row++)
            {
                for (int col = 0; col < grid.Cols; col++)
                {
                    GameCell cell = grid.getCell(row, col);
                    setPictureLocation(cell);
                    this.Controls.Add(cell.pictureBox);
                }
            }
        }
        private void setPictureLocation(GameCell cell)
        {
            cell.pictureBox.Left = cell.Y * cell.pictureBox.Width;
            cell.pictureBox.Top = cell.X * cell.pictureBox.Height;
        }
        private void EndGame(Image img)
        {
            GameLoop.Enabled = false;
            frmGameOver form = new frmGameOver(img);
            DialogResult result = form.ShowDialog();
            if (result == DialogResult.Yes)
            {
                MainMenu frm = new MainMenu();

                this.Hide();
                frm.Show();
            }
            else if (result == DialogResult.No)
            {
                restart();
            }
        }
        private void restart()
        {
            GameLoop.Enabled = true;
            this.Controls.Clear();
            frmGame frmGame = new frmGame();
            frmGame.Show();
            Label lbl = new Label();
            this.Controls.Add(lbl);
            GameGrid grid = new GameGrid("maze.txt");
            GameCell startCell = new GameCell(12, 23, grid);
            GameCell startEnemyCell = new GameCell(1, 3, grid);
            player = new GameAtlas(Resources.player_ship, startCell);
            Enemy E1 = new VEnemy(Resources.alien_black, startEnemyCell, GameDirection.Up, 100);
            Enemy E2 = new HEnemy(Resources.alien_blue, startEnemyCell, GameDirection.Left, 100);
            Enemy E3 = new REnemy(Resources.alien_green, startEnemyCell, 100);
            EnemyDL.AddEnemy(E1);
            EnemyDL.AddEnemy(E2);
            EnemyDL.AddEnemy(E3);
            startCell.setGameObject(player);

            foreach (Enemy enemy in EnemyDL.enemies)
            {
                startEnemyCell.setGameObject(enemy);
            }
            MakeProgressBars();
            printCharacter(player);
            printMaze(grid);

        }
    }
}
