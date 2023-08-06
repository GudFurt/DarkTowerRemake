using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int maxHealth;
    int currentHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void TakeDamage(int damage){
        currentHealth -= damage;
        if(currentHealth <= 0){
            EnemyDeath();
        }

    }

    public void EnemyDeath(){

        Debug.Log("Joe Biden");
    
    }
}
