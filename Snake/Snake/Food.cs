using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Snake
{
    public class Food
    {
        private int x, y, width, height;
        private SolidBrush brush;
        public Rectangle foodRec;

        public Food(Random r)
        {
            x = r.Next(0, 29) * 10;
            y = r.Next(0, 29) * 10;

            brush = new SolidBrush(Color.Red);

            width = 10;
            height = 10;

            foodRec = new Rectangle(x, y, width, height);
        }

        public void foodLoc(Random r)
        {
            x = r.Next(0, 29) * 10;
            y = r.Next(0, 29) * 10;           
        }

        public void drawFood(Graphics p)
        {
            foodRec.X = x;
            foodRec.Y = y;

            p.FillRectangle(brush, foodRec);
        }
    }
}
