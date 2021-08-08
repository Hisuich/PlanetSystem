using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class IPlanetarySystem
{
    protected List<IPlanetaryObject> planetaryObjects;

    
    public IPlanetarySystem()
    {
        planetaryObjects = new List<IPlanetaryObject>();
    }

    public List<IPlanetaryObject> GetPlanetaryObjects()
    {
        return planetaryObjects;
    }
    abstract protected void Update(float deltaTime);

    virtual public void AddPlanetaryObject(IPlanetaryObject planetaryObject)
    {
        planetaryObjects.Add(planetaryObject);
    }
}
