using System;
namespace RoboKitten.Casting;
public class Colour
{
    //ASSIGNS COLORS
    private int _r = 0;
    private int _g = 0;
    private int _b = 0;
    private int _a = 255;
    public Colour(int r, int g, int b)
    {
        this._r = r;
        this._g = g;
        this._b = b;
    }
    public int GetAlpha()
    {
        return _a;
    }
    public int GetBlue()
    {
        return _b;
    }
    public int GetGreen()
    {
        return _g;
    }
    public int GetRed()
    {
        return _r;
    }
}
