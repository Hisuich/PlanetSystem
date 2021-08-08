using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Orbit))]
public class IPlanetaryObject : MonoBehaviour
{
    protected MassClass massClass;

    [SerializeField]
    protected Orbit orbit;

    protected double speed;
    protected double orbitPosition;

    public double Mass
    { 
        get { return massClass.Mass; }
    }

    public double Radius
    { 
        get { return massClass.Radius; }
    }

    public string className
    { 
        get { return massClass.ClassName; }
    }

    virtual protected void Update()
    {
        orbitPosition += (Time.deltaTime * speed) / orbit.Radius;
        transform.position = orbit.GetPosition(orbitPosition);
    }
}
