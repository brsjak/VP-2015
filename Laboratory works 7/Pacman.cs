using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    class Pacman
    {
        public static readonly int RADIUS = 20;
        public int X;
        public int Y;
        private bool IsOpen;
        public enum DIRECTION
        {
            Up,
            Down,
            Left,
            Right
        }
        private DIRECTION Direction;
        private float Velocity;
        Brush brush;

        public Pacman()
        {
            Velocity = RADIUS;
            Direction = DIRECTION.Right;
            X = 7;
            Y = 5;
            brush = new SolidBrush(Color.Yellow);
        }
        public void ChangeDirection(DIRECTION direction)
        {
            Direction = direction;
        }
        public void Move(int width, int height)
        {
            if (Direction == DIRECTION.Right)
            {
                X += 1;
                if (X >= width)
                {
                    X = 0;
                }
            }
            else if (Direction == DIRECTION.Left)
            {
                X -= 1;
                if (X < 0)
                {
                    X = width - 1;
                }
            }
            else if (Direction == DIRECTION.Down)
            {
                Y += 1;
                if (Y >= height)
                {
                    Y = 0;
                }
            }
            else if (Direction == DIRECTION.Up)
            {
                Y -= 1;
                if (Y < 0)
                {
                    Y = height - 1;
                }
            }
            IsOpen = !IsOpen;
        }
        public void Draw(Graphics g)
        {
            if (IsOpen)
            {
                g.FillEllipse(brush, X * 2 * RADIUS, Y * 2 * RADIUS, RADIUS * 2, RADIUS * 2);
            }
            else
            {
                if (Direction == DIRECTION.Right)
                {
                    g.FillPie(brush, X * 2 * RADIUS, Y * 2 * RADIUS, RADIUS * 2, RADIUS * 2, 45, 270);
                }
                else if (Direction == DIRECTION.Left)
                {
                    g.FillPie(brush, X * 2 * RADIUS, Y * 2 * RADIUS, RADIUS * 2, RADIUS * 2, 225, 270);
                }
                else if (Direction == DIRECTION.Up)
                {
                    g.FillPie(brush, X * 2 * RADIUS, Y * 2 * RADIUS, RADIUS * 2, RADIUS * 2, 315, 270);
                }
                else if (Direction == DIRECTION.Down)
                {
                    g.FillPie(brush, X * 2 * RADIUS, Y * 2 * RADIUS, RADIUS * 2, RADIUS * 2, 135, 270);
                }
            }
        }
    }
}
