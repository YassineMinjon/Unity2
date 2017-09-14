using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningEnemy : Enemy, IDamageble
{ 	
	void Start ()
    {
        Health = 3;
	}

    public override void takeDamage(int damage)
    {
        base.takeDamage(damage);
    }

    protected override void move()
    {

    }
}
