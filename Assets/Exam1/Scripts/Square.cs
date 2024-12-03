using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private int side = 2;

    //Method

    private void Start()
    {
        Init("Square");
        Resize();
        CalculateArea();
    }

    public override float CalculateArea()
    {
        Debug.Log($"Square side: {side}");
        int area = side * side;
        Debug.Log($"{shapeName} area: {area}");
        return area;
    }

    public override void Resize()
    {
        base.Resize();
        Debug.Log("Square is resized.");
    }
}
