using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    // Update is called once per frame
    private void OnCollisionEnter2d(Collision2D collision){
        if(collision.gameObject.tag == "Enemy"){
            collision.gameObject.GetComponent<Enemy>().EnemyDeath();
        }
    }
}
