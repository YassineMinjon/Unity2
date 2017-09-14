using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    protected int health;
    public int Health
    {
        get
        {
            return health;
        }
        
        set
        {
            health = value;
        }
    }

    protected float speed;
    public float Speed
    {
        get
        {
            return speed;
        }
        set
        {
            speed = value*Time.deltaTime;
        }
    }

    public virtual void Update()
    {
        move();
    }

    protected virtual void move()
    {
        Vector3.MoveTowards(gameObject.transform.position, Vector3.zero, speed);
    }

    public virtual void takeDamage(int damage)
    {
        health -= damage;
        if (health == 0)
        {
            die();
        }
    }

    public void die()
    {
        Destroy(gameObject);
    }
}
