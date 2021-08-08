using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract public class IPlanetarySystemFactory : MonoBehaviour
{
    [SerializeField]
    protected GameObject planetPrefab;
    abstract public IPlanetarySystem Create(double mass);
   
}
