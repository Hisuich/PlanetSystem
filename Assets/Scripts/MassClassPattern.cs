using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MassClassPattern 
{
    private static List<MassClassPattern> massClassPatterns = new List<MassClassPattern>();
    
    // Define mass classes
    private static MassClassPattern Asteroidan = new MassClassPattern(0, 0.00001, 0, 0.03, "Asteroidan");
    private static MassClassPattern Mercurian = new MassClassPattern(0.00001, 0.1, 0.03, 0.7, "Mercurian");
    private static MassClassPattern Subterran = new MassClassPattern(0.1, 0.5, 0.5, 1.2, "Subterran");
    private static MassClassPattern Terran = new MassClassPattern(0.5, 2, 0.8, 1.9, "Terran");
    private static MassClassPattern Superterran = new MassClassPattern(2, 10, 1.3, 3.3, "Superterran");
    private static MassClassPattern Neptunian = new MassClassPattern(10, 50, 2.1, 5.7, "Neptunian");
    private static MassClassPattern Jovian = new MassClassPattern(50, 5000, 3.5, 27, "Jovian");


    public static MassClassPattern GetMassClassPattern(double mass)
    {
        foreach (var massClassPattern in massClassPatterns)
        {
            if (massClassPattern.minMass >= mass && massClassPattern.maxMass <= mass)
            {
                return massClassPattern;
            }
        }
        return massClassPatterns[massClassPatterns.Count-1];
    }

    private double minMass;

    private double maxMass;

    private double minRadius;

    private double maxRadius;

    private string className;

    public string ClassName
    { 
        get { return className; }
    }

    private MassClassPattern(double minMass, double maxMass, double minRadius, double maxRadius, string className)
    {
        this.minMass = minMass;
        this.maxMass = maxMass;
        this.minRadius = minRadius;
        this.maxRadius = maxRadius;
        this.className = className;

        massClassPatterns.Add(this);
    }

    public double GetRadiusByMass(double mass)
    {
        double sizeCoef = mass / maxMass;

        return maxRadius * sizeCoef;
    }

}
