using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(IPlanetarySystem))]
public class PlanetarySystemObject : MonoBehaviour
{
    private IPlanetarySystem planetarySystem;

    [SerializeField]
    private double globalMass;

    public double GlobalMass
    { 
        set { globalMass = value;}
        get { return globalMass; }
    }

    private IPlanetarySystemFactory factory;

    private void Start()
    {
        factory = GetComponent<IPlanetarySystemFactory>();
        GeneratePlanetarySystem();
    }
    public void GeneratePlanetarySystem()
    {
        if (planetarySystem != null)
            RemovePlanetarySystem();
        planetarySystem = factory.Create(globalMass);

        List<IPlanetaryObject> planetObjects = planetarySystem.GetPlanetaryObjects();
        
        foreach (IPlanetaryObject planetObject in planetObjects)
        {
            planetObject.transform.SetParent(transform);
        }
    }

    

    public void RemovePlanetarySystem()
    {
        foreach (Transform planetObject in transform)
        {
            Destroy(planetObject.gameObject);
        }
    }

    private void Update()
    {
        if (planetarySystem != null)
        {
            List<IPlanetaryObject> planetObjects = planetarySystem.GetPlanetaryObjects();
            foreach (IPlanetaryObject planetaryObject in planetObjects)
            {
                // add center
                planetaryObject.transform.position += transform.position;
            }
        }
    }
}
