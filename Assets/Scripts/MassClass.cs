using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MassClass
{
    private string className;
    public string ClassName
    { 
        get { return className; }
    }
    private double mass;
    public double Mass
    { 
        get { return mass; }
    }
    private double radius;
    public double Radius
    { 
        get { return radius; }
    }

    public MassClass(double mass)
    {
        MassClassPattern pattern = MassClassPattern.GetMassClassPattern(mass);

        this.mass = mass;

        radius = pattern.GetRadiusByMass(mass);

        className = pattern.ClassName;
    }
}
