using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlUI : MonoBehaviour
{
    [SerializeField]
    private PlanetarySystemObject planetarySystem;

    [SerializeField]
    private Button GeneratePlanetarySystem;

    [SerializeField]
    private InputField globalMass;

    protected void Start()
    {
        GeneratePlanetarySystem.onClick.AddListener(planetarySystem.GeneratePlanetarySystem);
        globalMass.onValueChanged.AddListener(SetGlobalMass);
        globalMass.text = planetarySystem.GlobalMass.ToString();
    }

    private void SetGlobalMass(string mass)
    {
        int global;
        bool parse = int.TryParse(mass, out global);

        if (parse)
        {
            planetarySystem.GlobalMass = global;
        }
    }
}
