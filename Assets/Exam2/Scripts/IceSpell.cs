using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceSpell : Spell
{
    private void Start()
    {
        SpellUse();
    }

    //Method
    public override void Cast()
    {
        Debug.Log($"Casting an Ice spell! Freeze the enemy!");
    }

    public void SpellUse()
    {
        Cast();
        Cast("Goblin");
        Cast("Goblin", 10);
    }
}
