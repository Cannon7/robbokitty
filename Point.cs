using System;
namespace RoboKitten;
{
    public class Point
    {
        private int _x = 0;
        private int _y = 0;
        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        public int GetXV()
        {
            return _x;
        }
        public int GetYV()
        {
            return _y;
        }
        public Point Addnumb(Point other)
        {
            int x = this._x + other.GetXV();
            int Y = this._y + other.GetYV();
        }
    }
}