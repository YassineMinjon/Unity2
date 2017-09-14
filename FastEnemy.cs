using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastEnemy : Enemy, IDamageble
{
    void Start()
    {
        Health = 2;
        Speed = 1;
    }

    public override void takeDamage(int damage)
    {
        base.takeDamage(damage);
    }
}
