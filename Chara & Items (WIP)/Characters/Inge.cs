﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ing : Character
{
    protected int[] stats = { 25, 15, 5, 40, 35, 35 };
   
    Ing(string name, int lvl = 0) : base(Character.Characterclass.ING, name, lvl)
    {
        this.name = name;
        for (int i = 0; i < 6; i++)
        {
            stats[i] += Random.Range(-2, 2);
        }
        base.life = stats[0];
    }
   /* protected int Life()
    { get: return stats[0]; }
    protected int Atk()
    { get: return stats[1]; }
    protected int Def()
    { get: return stats[2]; }
    protected int Matk()
    { get: return stats[3]; }
    protected int Mdef()
    { get: return stats[4]; }
    protected int Spd()
    { get: return stats[5]; }*/

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
