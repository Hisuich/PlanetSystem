using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlanetarySystemFactory : IPlanetarySystemFactory
{
    public override IPlanetarySystem Create(double mass)
    {
        PlanetarySystem planetarySystem = new PlanetarySystem();

        int planetNumber = Random.Range(2, 10);

        double leftMass = mass;
        double prevOrbit = 0;
        for (int i = 1; i <= planetNumber; i++)
        {
            double planetMass;

            if (i == planetNumber)
                planetMass = leftMass;
            else
            {
                int coef = Random.Range(1, planetNumber);
                planetMass = ((double)coef / planetNumber) * leftMass;
                planetMass = Random.Range(0.00001f, (float)planetMass);
                leftMass -= planetMass;
            }

            MassClassPattern massClass = MassClassPattern.GetMassClassPattern(planetMass);
            double planetOrbit = prevOrbit + massClass.GetRadiusByMass(planetMass) + (Random.Range(1.0f, 10.0f)*5);
            
            prevOrbit = planetOrbit;

            double planetSpeed = Random.Range(0.8f, 1f);

            PlanetaryObject planet = Instantiate(planetPrefab).GetComponent<PlanetaryObject>();
            planet.GeneratePlanet(planetMass, planetOrbit, planetSpeed);
            planetarySystem.AddPlanetaryObject(planet);
        }

        return planetarySystem;
    }
}
