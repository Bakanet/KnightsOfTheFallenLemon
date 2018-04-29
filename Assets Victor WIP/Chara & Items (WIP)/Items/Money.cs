﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : Items
{

    int dmg;
    Money(string name, int lvl = 0, int dmg = 10): base (ItemType.WEAPON, name, lvl)
    {
        this.dmg = dmg;
    }

    public override void UpdateStats()
    {
        dmg += 5;
    }

    public override void UseItem(Character target)
    {
        throw new System.Exception("Special capacities not implemented yet");
    }

}
