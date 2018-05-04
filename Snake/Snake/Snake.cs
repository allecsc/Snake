using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Snake
{
    public class Snake
    {
        private Rectangle[] snakeRec;
        private SolidBrush brush;
        private SolidBrush head;
        private Pen margin;
        private int x, y, width, height;

        public Rectangle[] SnakeRec
        {
            get
            {
                return snakeRec;
            }
        }

        public Snake()
        {           
            snakeRec = new Rectangle[3];
            head = new SolidBrush(Color.Green);
            brush = new SolidBrush(Color.LawnGreen);
            margin = new Pen(Color.Green);
            
            x = 20;
            y = 0;
            width = 9;
            height = 9;

            for (int i = 0; i < snakeRec.Length; ++i)
            {
                snakeRec[i] = new Rectangle(x, y, width, height);
                x -= 10;
            }
        }

        public void drawSnake(Graphics p)
        {
            foreach (Rectangle rec in snakeRec)
            {
                p.FillRectangle(brush, rec);
                p.DrawRectangle(margin, rec);
            }

            p.FillRectangle(head, snakeRec[0]);
        }

        public void drawSnake()
        {
            for (int i = snakeRec.Length - 1; i > 0; --i)
            {
                snakeRec[i] = snakeRec[i - 1];
            }
        }

        public void moveDown()
        {
            drawSnake();
            snakeRec[0].Y += 10;
        }

        public void moveUp()
        {
            drawSnake();
            snakeRec[0].Y -= 10;
        }

        public void moveRight()
        {
            drawSnake();
            snakeRec[0].X += 10;
        }

        public void moveLeft()
        {
            drawSnake();
            snakeRec[0].X -= 10;
        }

        public void growSnake()
        {
            List<Rectangle> rec = snakeRec.ToList();
            rec.Add(new Rectangle(snakeRec[snakeRec.Length - 1].X, snakeRec[snakeRec.Length - 1].Y, width, height));
            snakeRec = rec.ToArray();
        }

    }
}
