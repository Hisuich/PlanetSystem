using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{
    private double horizontalAngle;
    private double verticalAngle;
    private double radius;

    public double Radius
    { 
        get { return radius; }
    }

    public void SetOrbit(double horizontalAngle, double verticalAngle, double radius)
    {
        this.horizontalAngle = horizontalAngle * Mathf.Deg2Rad;
        this.verticalAngle = verticalAngle * Mathf.Deg2Rad;
        this.radius = radius;
    }

    // Get positions by CurrentPlace
    // Current place is the value from 0 to 1 what define where is planet on orbit now
    public Vector3 GetPosition(double currentPlace)
    {
        float curHAngle = (float)horizontalAngle + (360 * (float)currentPlace * Mathf.Deg2Rad);
        float x = (float)(radius * Math.Sin(verticalAngle) * Math.Cos(curHAngle));
        float z = (float)(radius * Math.Sin(verticalAngle) * Math.Sin(curHAngle));
        float y = (float)(radius * Math.Cos(verticalAngle));

        return new Vector3(x, y, z);
    }

}
