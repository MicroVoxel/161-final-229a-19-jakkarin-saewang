using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Spell : MonoBehaviour
{
    private void Start()
    {
        Cast();

    }

    //Method
    public virtual void Cast()
    {
        Debug.Log("Spell-Casting Simulation Started!");
        Debug.Log($"Casting a generic spell!");
    }

    public void Cast(string target)
    {
        Debug.Log($"Casting a spell on target: {target}!");
    }

    public void Cast(string target, int power)
    {
        Debug.Log($"Casting a spell on {target}! with power level: {power}.");
    }
}
