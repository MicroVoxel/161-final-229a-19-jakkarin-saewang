using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSpell : Spell
{
    private void Start()
    {
        SpellUse();
    }

    //Method
    public override void Cast()
    {
        Debug.Log($"Casting a Fire spell! Burn them all!");
    }

    public void SpellUse()
    {
        Cast();
        Cast("Slime");
        Cast("Slime", 5);
    }
}
