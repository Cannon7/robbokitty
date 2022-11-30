using System;
namespace RoboKitten.Casting;

    public class Point
    {
        //GETS AND GIVES LOCATION
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
            int y = this._y + other.GetYV();
            return new Point(x, y);
        }
        public bool Equals(Point other)
        {
            return this._x == other.GetXV() && this._y == other.GetYV();
        }
        public Point Scale(int factor)
        {
            int x = this._x * factor;
            int y = this._y * factor;
            return new Point(x, y);
        }
    }
