using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindSpell : Spell
{
    private void Start()
    {
        SpellUse();
    }

    //Method
    public override void Cast()
    {
        Debug.Log($"Casting a Wind spell! Blow away!");
    }

    public void SpellUse()
    {
        Cast();
        Cast("Zombie");
        Cast("Zombie", 20);
    }
}
