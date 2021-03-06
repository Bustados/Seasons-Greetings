﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public int health;
    public int maxHealth;
    public Transform locationCheck;

    // Update is called once per frame
    void Update () {
        if (locationCheck.position.y < -15)
        {
            Destroy(gameObject);
        }
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathTouch")
        {
            Destroy(gameObject);
        }
    }


    public void TakeDamage(int amount)
    {
        health -= amount;
        if( health < 1)
        {
            Destroy(gameObject);
        }

    }
}
