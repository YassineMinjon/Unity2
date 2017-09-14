using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmoredEnemy : Enemy
{
	void Start ()
    {
        Health = 5;
	}

    public override void takeDamage(int damage)
    {
        base.takeDamage(damage);
    }
}
