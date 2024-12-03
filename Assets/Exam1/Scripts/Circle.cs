using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class Circle : Shape
{
    private float radius = 2f;

    //Method

    private void Start()
    {
        Init("Circle");
        Resize();
        CalculateArea();
    }

    public override float CalculateArea()
    {
        Debug.Log($"Circle radius: {radius}");
        float area =  (3.14f) * radius * radius ;
        Debug.Log($"{shapeName} area: {area}");
        return area;
    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log("Resizing Circle in Circle class");
    }

}
