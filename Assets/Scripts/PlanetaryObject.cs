using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
public class PlanetaryObject : IPlanetaryObject
{
    private List<Color> colors;
    private TrailRenderer trail;

    protected void Awake()
    {
        ColorsGenerate();
        trail = GetComponent<TrailRenderer>();
        trail.enabled = false;
    }
    private void ColorsGenerate()
    {
        
        colors = new List<Color>();
        colors.Add(Color.red);
        colors.Add(Color.green);
        colors.Add(Color.blue);
        colors.Add(Color.white);
        colors.Add(Color.black);
        colors.Add(Color.yellow);
        colors.Add(Color.cyan);
        colors.Add(Color.gray);
    }
    public void GeneratePlanet(double mass, double orbitRadius, double speed)
    {
        massClass = new MassClass(mass);
        double initialHorizontalAngle = Random.Range(0, 360);
        orbit.SetOrbit(initialHorizontalAngle, 90, orbitRadius);
        this.speed = speed;
        Color currentColor = colors[Random.Range(0, colors.Count)];
        GetComponent<Renderer>().material.SetColor("_EmissionColor", currentColor);

        transform.localScale = new Vector3((float)massClass.Radius, (float)massClass.Radius, (float)massClass.Radius);
        transform.position = orbit.GetPosition(0);

        trail.enabled = true;
    }

}
