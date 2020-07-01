using System;

public class SpaceAge
{


    public SpaceAge(double seconds)
    {
        EYear = seconds / 31557600;
    }

    public double EYear
    { get; }

    public double OnEarth()
    {
        return EYear;
    }

    public double OnMercury()
    {
        return EYear / .2408467;
    }

    public double OnVenus()
    {
        return EYear / .61519726;
    }

    public double OnMars()
    {
        return EYear / 1.8808158;
    }

    public double OnJupiter()
    {
        return EYear / 11.862615;
    }

    public double OnSaturn()
    {
        return EYear / 29.447498;
    }

    public double OnUranus()
    {
        return EYear / 84.016846;
    }

    public double OnNeptune()
    {
        return EYear / 164.79132;
    }
}