using System;

public class SpaceAge
{


    public SpaceAge(double seconds)
    {
        E = seconds / 31557600;
    }

    public double E
    { get; }

    public double OnEarth()
    {
        return E;
    }

    public double OnMercury()
    {
        return E / .2408467;
    }

    public double OnVenus()
    {
        return E / .61519726;
    }

    public double OnMars()
    {
        return E / 1.8808158;
    }

    public double OnJupiter()
    {
        return E / 11.862615;
    }

    public double OnSaturn()
    {
        return E / 29.447498;
    }

    public double OnUranus()
    {
        return E / 84.016846;
    }

    public double OnNeptune()
    {
        return E / 164.79132;
    }
}