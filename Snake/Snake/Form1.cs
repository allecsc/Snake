using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snake
{
    public partial class Form1 : Form
    {
        Graphics p;
        Snake snake = new Snake();
        Random r = new Random();
        Food food;
        int score = 0;
        bool paused = false;

        bool left = false;
        bool right = false;
        bool up = false;
        bool down = false;

        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 150;
            food = new Food(r);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Down && up == false)
            {
                up = false;
                right = false;
                left = false;
                down = true;
            }

            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                right = false;
                left = false;
                up = true;
            }

            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }

            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                left = false;
                right = true;
            }

            if (e.KeyData == Keys.Escape)
            {
                Application.Exit();
            }

            if ((e.KeyData == Keys.P || e.KeyData == Keys.Pause || e.KeyData == Keys.Space) && paused == false)
            {
               BeginPause();
               paused = true;
            }
            else if ((e.KeyData == Keys.P || e.KeyData == Keys.Pause || e.KeyData == Keys.Space) && paused == true)
            {
                EndPause();
                paused = false;
            }
        }

        private void BeginPause()
        {
            timer1.Enabled = false;
            pause_panel.Visible = true;
        }

        private void EndPause()
        {
            timer1.Enabled = true;
            pause_panel.Visible = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            p = e.Graphics;
            food.drawFood(p);
            snake.drawSnake(p);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (down)
            {
                snake.moveDown();
            }
            if (up)
            {
                snake.moveUp();
            }
            if (left)
            {
                snake.moveLeft();
            }
            if (right)
            {
                snake.moveRight();
            }

            for (int i = 0; i < snake.SnakeRec.Length; ++i)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    snake.growSnake();
                    food.foodLoc(r);
                  
                    score += 10;
                    toolStripStatusLabel2.Text = Convert.ToString(score);

                    if (score == 10) timer1.Interval = 140;
                    if (score == 20) timer1.Interval = 130;
                    if (score == 30) timer1.Interval = 120;
                    if (score == 40) timer1.Interval = 110;
                    if (score == 50) timer1.Interval = 100;
                    if (score == 100) timer1.Interval = 80;
                    if (score == 200) timer1.Interval = 70;
                    if (score == 300) timer1.Interval = 60;
                    if (score == 400) timer1.Interval = 50;
                    if (score == 500) timer1.Interval = 40;
                    if (score == 600) timer1.Interval = 30;
                    if (score == 700) timer1.Interval = 20;
                    if (score == 800) timer1.Interval = 10;
                    if (score == 900) timer1.Interval = 1;
                    if (score == 1000)
                    {
                        timer1.Enabled = false;
                        MessageBox.Show("You finished the game!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Application.Exit();
                    }
                }
            }

            Collision();

            this.Invalidate();
        }

        public void Collision()
        {
            for (int i = 1; i < snake.SnakeRec.Length; ++i)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    timer1.Enabled = false;
                    gameOver_panel.Visible = true;
                }
            }

            if (snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 290 || snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 290)
            {
                timer1.Enabled = false;
                gameOver_panel.Visible = true;                
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                timer1.Enabled = false;
                pause_panel.Visible = true;

                About a = new About();
                a.Show();
            }
        }

        private void restartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gameOver_panel_VisibleChanged(object sender, EventArgs e)
        {
            if (Visible == true)
            {
                restartButton.Focus();
            }
        }
    }
}
