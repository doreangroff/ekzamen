using System;

namespace ekzamen;

public class UnitTestClass
{
    public double CalcT(double v)
    {
        double t = Math.Round(2 * (Math.Round(v / 9.8, 2)), 2);
        return t;
    }
}